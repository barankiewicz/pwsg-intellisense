using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class AddWord : Form
    {
        public string name;
        public string txt;
        public AddWord()
        {
            InitializeComponent();
        }

        public AddWord(string text)
        {
            InitializeComponent();
            wordTextBox.Text = text;
        }

        private void addWordBtn_Click(object sender, EventArgs e)
        {
            string word = (string)wordTextBox.Text;
            bool flag = false;

            if (word.Length == 0)
                flag = true;



            for (int i = 0; i < word.Length; i++)
            {
                if (!Char.IsLetter(word[i]))
                {
                    err.SetError(wordTextBox, "New word can only consist of letters");
                    flag = true;
                }
            }

            if (flag)
            {
                MessageBox.Show("Validation error!");
            }
            else
            {
                name = word;
                Close();
            }
        }

        private void wordTextBox_TextChanged(object sender, EventArgs e)
        {
            var textbox = (TextBox)sender;
            var word = textbox.Text;
            bool flag = false;

            for(int i = 0; i < word.Length; i++)
            {
                if (!Char.IsLetter(word[i]))
                {
                    err.SetError(wordTextBox, "New word can only consist of letters");
                    flag = true;
                }
            }

            if (!flag)
                err.Clear();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddWord_Load(object sender, EventArgs e)
        {

        }
    }
}
