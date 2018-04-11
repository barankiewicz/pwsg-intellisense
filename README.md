# pwsg-intellisense
a (very) basic implementation of IntelliSense in WinForms. Written as part of the GUI programming course on MiNI, WUT. This application has a set of features we had to implement on our own during the course:

## Part 1
*  ###    Appearance:
    *   Appears in the middle of the screen
    *   Minimal app size is 400x300
    *   Text Box scales appropriately when the window's size changes
    *   Text Box: Calibri font, 12pt
    *   Menu: "Load" button that opens a 'Choose file' window. Said window only allows the user to select .txt files. If the user selects anything else, he will be notified and this action will fail.

* ###   Intellisense p. 1:
    *   When user starts writing, a small window appears beneath the cursor
    *   The intellisense bar is always beneath the cursor
    *   Suggested words are always in alphabetical order
* ###  Intellisense p. 2:
    *   The size of the letters is ignored
    *   'Up' and 'Down' arrows allow user to choose a word from the suggested words list
    *   Typing letters shortens the suggestions list to words that start with an appropriate (typed) prefix
    *   If no in the dictionary fit the prefix, the intellisense window disappears
    *   Pressing TAB when there is at least 1 suggested word makes it auto-complete in the textBox
    
## Part 2

*  ### Misc:
    *  User can add his own words to the dictionary (they can only consist of letters)
    *  There is an 'Export' button that allows user to save the dictionary to .txt
*  ### Dictionary panel:
    * Doesn't change it's width when the app is resized. You can change it's width using the grey bar next to it.
    *  User can select and delete items from the dictionary. User can delete multiple items at once.
    *  Under the panel there are buttons: "Add new word", and "Sort" - their functions are self-explanatory
*  ### "Add new word" window:
    *  It appears in the middle of it's parent window
    *  User can't change it's size, maximalize or minimalize it
    *  It allows to add a new word to the dictionary
    *  When 'Add New Word' window is active, the main app window is inactive
    *  If user tries to add an illegal word, the window won't let him
    *  User can also right-click on the word in the main textbox and add it to the dictionary from context menu level
*  ### Font:
    * You make the textbox font bold, italic, underlined. You can also change the font, font's color and the background color
*  ### Drag&Drop:
    *   You can load a new dictionary by draggin a .txt file on the dictionary panel
