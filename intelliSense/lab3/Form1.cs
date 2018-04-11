using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        bool descending;
        List<string> names;

        int startPosition;
        string word = "";
        string font = "Calibri";
        Color color = Color.Black;

        public Form1()
        {
            InitializeComponent();
            descending = false;
            names = new List<string>();
            startPosition = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            intellisense.Hide();
            textBox.ContextMenuStrip = contextMenuStrip;
            InstalledFontCollection fonts = new InstalledFontCollection();
            foreach (FontFamily family in fonts.Families)
            {
                toolStripComboBox.Items.Add(family.Name);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opf.ShowDialog();
        }

        private List<string> filterList(List<string> names, string text)
        {
            return names.Where(s => s.StartsWith(text,StringComparison.CurrentCultureIgnoreCase)).ToList();
        }

        private async Task<List<string>> filterListAsync(List<string> names, string text)
        {
            return await Task<List<string>>.Run(() => filterList(names, text));
        }

        private void opf_FileOk(object sender, CancelEventArgs e)
        {
            var opf = (OpenFileDialog)sender;

            if(opf.SafeFileName.Substring(opf.SafeFileName.Length-3) != "txt")
            {
                MessageBox.Show("Invalid file selected", "You must select a .txt file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }
            var fs = opf.OpenFile();
            var sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                names.Add(sr.ReadLine().ToLower());
            }
            refreshList(intellisense, names);
            refreshList(namesList, names);
            sr.Close();
            fs.Close();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Immediately end if:
            if (names.Count == 0)
                return;

            //We have some names loaded up
            int i = this.textBox.SelectionStart;
            char currentChar = e.KeyChar;

            if (Char.IsLetter(currentChar))
            {
                //intellisense.Items.
                word += currentChar;
                var nam = intellisense.Items.Cast<string>().ToList();
                List<string> filtered = filterList(nam, word);

                if(intellisense.SelectedIndices.Count != 0)
                {
                    string sel = (string)intellisense.Items[intellisense.SelectedIndex];
                    if(filtered.Contains(sel))
                        filtered.Insert(0, sel);
                }
                refreshList(intellisense, filtered);
                var pos = textBox.GetPositionFromCharIndex(textBox.SelectionStart);
                int height = (int)intellisense.Font.Size;
                pos.Offset(0, 3*height);
                intellisense.Location = pos;
                intellisense.SelectedIndex = 0;
                intellisense.Show();
                if (filtered.Count == 0)
                {
                    word = "";
                    startPosition = textBox.SelectionStart;
                    intellisense.Hide();
                    refreshList(intellisense, names);
                }
                return;
            }
            else
            {
                word = "";
                startPosition = textBox.SelectionStart;
                intellisense.Hide();
                if(names.Count != intellisense.Items.Count)
                    refreshList(intellisense, names);
            }
        }


        private void textBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //Immediately end if:
            if (names.Count == 0)
                return;

            //We have some names loaded up
            int i = this.textBox.SelectionStart;
            char currentChar = (char)e.KeyCode;

            if (!Char.IsLetter(currentChar))
            {
                switch (e.KeyData)
                {
                    case Keys.Tab:
                        if(intellisense.SelectedIndices.Count == 0)
                        {
                            intellisense.SelectedIndex = 0;
                        }
                        string selected = ((string)intellisense.SelectedItem).Substring(word.Length);
                        textBox.Text += selected;
                        word = "";
                        intellisense.Hide();
                        refreshList(intellisense, names);
                        textBox.SelectionStart = textBox.Text.Length;
                        break;
                    case Keys.Up:
                        if (this.intellisense.Visible)
                        {
                            if (this.intellisense.SelectedIndex > 0)
                                this.intellisense.SelectedIndex--;
                        }
                        break;
                    case Keys.Down:
                        if (this.intellisense.Visible)
                        {
                            if (this.intellisense.SelectedIndex < this.intellisense.Items.Count - 1)
                                this.intellisense.SelectedIndex++;
                        }
                        break;
                }
            }
        }

        private void sfd_FileOk(object sender, CancelEventArgs e)
        {
            var sfd = (SaveFileDialog)sender;

            if(namesList.Items.Count == 0)
            {
                MessageBox.Show("You cannot export an empty list", "First add some words to the list", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }

            var fs = sfd.OpenFile();
            var sr = new StreamWriter(fs);

            foreach (string s in namesList.Items)
            {
                sr.WriteLine(s);
            }
            sr.Close();
            fs.Close();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfd.ShowDialog();
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            names.Sort();
            if (descending)
                names.Reverse();

            refreshList(intellisense, names);
            refreshList(namesList, names);
            descending = !descending;
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            AddWord add = new AddWord();
            add.ShowDialog();

            if(add.name == null)
            {
                return;
            }
            else if (names.Contains(add.name))
            {
                MessageBox.Show("This word is already in the list!");
                return;
            }
            else
            {
                namesList.Items.Add(add.name);
                intellisense.Items.Add(add.name);
                names.Add(add.name);
            }
        }

        private void namesList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string fileName = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void namesList_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string fileName = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];

                if (fileName.Substring(fileName.Length - 3) != "txt")
                {
                    MessageBox.Show("Invalid file selected", "You must select a .txt file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Effect = DragDropEffects.None;
                    return;
                }
                var fs = new FileStream(fileName, FileMode.Open);
                var sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    names.Add(sr.ReadLine().ToLower());
                }
                refreshList(intellisense, names);
                refreshList(namesList, names);
            }
        }

        private void boldBtn_Click(object sender, EventArgs e)
        {
            bool flag = textBox.SelectionFont.Bold;
            var btn = (ToolStripButton)sender;

            if (flag)
            {
                btn.BackColor = Color.AliceBlue;
            }
            else
            {
                btn.BackColor = Color.DarkGray;
            }
            textBox.Font = new Font(font, 12, getFontStyle() ^ FontStyle.Bold);
            textBox.SelectAll();
            textBox.SelectionColor = color;
            textBox.Select(textBox.Text.Length, 0);
            textBox.SelectionLength = 0;
        }

        private void italicBtn_Click(object sender, EventArgs e)
        {
            bool flag = textBox.SelectionFont.Italic;
            var btn = (ToolStripButton)sender;

            if (flag)
            {
                btn.BackColor = Color.AliceBlue;
            }
            else
            {
                btn.BackColor = Color.DarkGray;
            }
            // Set font of selected text
            // You can use FontStyle.Bold | FontStyle.Italic to apply more than one style
            textBox.Font = new Font(font, 12, getFontStyle() ^ FontStyle.Italic);
            textBox.SelectAll();
            textBox.SelectionColor = color;
            textBox.Select(textBox.Text.Length, 0);
            textBox.SelectionLength = 0;
        }

        private void underlineBtn_Click(object sender, EventArgs e)
        {
            bool flag = textBox.SelectionFont.Underline;
            var btn = (ToolStripButton)sender;

            if (flag)
            {
                btn.BackColor = Color.AliceBlue;
            }
            else
            {
                btn.BackColor = Color.DarkGray;
            }
            // Set font of selected text
            // You can use FontStyle.Bold | FontStyle.Italic to apply more than one style
            if(font != "")
            {
                textBox.Font = new Font(font, 12, getFontStyle() ^ FontStyle.Underline);
            }
            else
            {
                textBox.Font = new Font(font, 12, textBox.Font.Style ^ FontStyle.Underline);
            }
            
            textBox.SelectAll();
            textBox.SelectionColor = color;
            textBox.Select(textBox.Text.Length, 0);
            textBox.SelectionLength = 0;
        }

        private void textColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Remember selection
                int selstart = textBox.SelectionStart;
                int sellength = textBox.Text.Length;

                // Set font of selected text
                // You can use FontStyle.Bold | FontStyle.Italic to apply more than one style
                textBox.Select(0, sellength);
                textBox.SelectionColor = colorDialog.Color;
                color = colorDialog.Color;
                textBox.Select(sellength, 0);
                textBox.SelectionLength = 0;
            }
        }

        private void backColorText_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                textBox.BackColor = colorDialog.Color;
        }

        private void namesList_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            List<object> toRemove = new List<object>();
            if(e.KeyCode == Keys.Delete)
            {
                foreach(object o in namesList.SelectedItems)
                {
                    toRemove.Add(o);

                }
                foreach(object o in toRemove)
                {
                    namesList.Items.Remove(o);
                    intellisense.Items.Remove(o);
                }
                refreshObj(namesList.Items, names);
            }
        }

        private void refreshList(ListBox l, List<string> nam)
        {
            var obj = nam.Cast<object>().ToArray();
            l.Items.Clear();
            l.Items.AddRange(obj);
        }

        private async void refreshListAsync(ListBox l, List<string> nam)
        {
            await Task.Run(() => refreshList(l, nam));
        }

        private void refreshObj(ListBox.ObjectCollection obj, List<string> names)
        {
            var str = obj.Cast<string>().ToList();

            names.Clear();

            for (int i = 0; i < str.Count; i++)
                names.Add(str[i]);
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (textBox.Text.Length == 0)
            {
                e.Cancel = true;
                return;
            }
            else
            {
                contextMenuStrip.Items[0].Text = "Add " + textBox.Text;
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddWord add = new AddWord(textBox.Text);
            add.ShowDialog();

            if (add.name == null)
            {
                return;
            }
            else if (names.Contains(add.name))
            {
                MessageBox.Show("This word is already in the list!");
                return;
            }
            else
            {
                namesList.Items.Add(add.name);
                intellisense.Items.Add(add.name);
                names.Add(add.name);
            }
            contextMenuStrip.Items[0].Text = "Add ";
        }

        private void toolStripComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (toolStripComboBox.SelectedItem == null)
                return;

            FontStyle st = getFontStyle();
            // Remember selection
            int selstart = textBox.SelectionStart;
            textBox.SelectAll();

            // Set font of selected text
            
            textBox.SelectionFont = new Font(toolStripComboBox.SelectedItem.ToString(), 12, st);
            font = toolStripComboBox.SelectedItem.ToString();
            textBox.SelectionColor = color;

            // Set cursor after selected text
            textBox.SelectionLength = 0;
            textBox.SelectionStart = selstart;
        }

        private void toolStrip1_DragEnter(object sender, DragEventArgs e)
        {
            var toolStrip = (ToolStrip)sender;
            MessageBox.Show(toolStrip.Dock.ToString());
        }

        private void toolStrip1_DragLeave(object sender, EventArgs e)
        {
            var toolStrip = (ToolStrip)sender;
            MessageBox.Show(toolStrip.Dock.ToString());

        }

        private void toolStrip1_DragDrop(object sender, DragEventArgs e)
        {
            var toolStrip = (ToolStrip)sender;
            MessageBox.Show(toolStrip.Dock.ToString());

        }

        private void toolStrip1_DragOver(object sender, DragEventArgs e)
        {
            var toolStrip = (ToolStrip)sender;
            MessageBox.Show(toolStrip.Dock.ToString());
        }

        private FontStyle getFontStyle()
        {
            FontStyle ret = FontStyle.Regular;

            int selstart = textBox.SelectionStart;
            textBox.SelectAll();
            if (textBox.SelectionFont.Style.HasFlag(FontStyle.Bold))
                ret |= FontStyle.Bold;

            if (textBox.SelectionFont.Style.HasFlag(FontStyle.Italic))
                ret |= FontStyle.Italic;

            if (textBox.SelectionFont.Style.HasFlag(FontStyle.Underline))
                ret |= FontStyle.Underline;

            textBox.SelectionLength = 0;
            textBox.SelectionStart = selstart;
            return ret;
        }
    }
}
