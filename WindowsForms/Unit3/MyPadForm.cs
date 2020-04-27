using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.Unit3
{
    /// <summary>
    /// Task 3.7 - 3.10 & 3.13
    /// This class works as a notepad where the user can type
    /// into the mainRichTextBox, the size of the typed text
    /// can be changed using the scroll bar at the bottom &
    /// the menu strip has 3 boxes which contain subboxes, from
    /// the file box, the user can save and load their documents
    /// aswell as close them, in the edit box they can cut, copy
    /// paste and undo whats in the mainRichTextBox, and in the 
    /// format box from the menu string the user can change the
    /// font of the text, the colour of the text and the background
    /// colour of the mainRichTextBox. 
    /// Author: Shamial Rashid 21905385
    /// </summary>
    public partial class MyPadForm : Form
    {
        private int fontSize = 0;
        public MyPadForm()
        {
            InitializeComponent();
        }

        private void cutText(object sender, EventArgs e)
        {
            mainRichTextBox.Cut();
        }

        private void copyText(object sender, EventArgs e)
        {
            mainRichTextBox.Copy();
        }

        private void pasteText(object sender, EventArgs e)
        {
            mainRichTextBox.Paste();
        }

        private void undoTyping(object sender, EventArgs e)
        {
            mainRichTextBox.Undo();
        }

        private void quitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveFile(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            mainRichTextBox.SaveFile(saveFileDialog.FileName);
        }

        private void openFile(object sender, EventArgs e)
        {
            mainRichTextBox.LoadFile(openFileDialog.FileName);
        }

        private void changeFont(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            mainRichTextBox.Font = fontDialog.Font;
        }

        private void changeBackgroundColour(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            mainRichTextBox.BackColor = colorDialog.Color;
        }

        private void changeForegroundColour(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            mainRichTextBox.ForeColor = colorDialog.Color;
        }

        private void moveScrollBar(object sender, ScrollEventArgs e)
        {
            Font fontsize = new Font(mainRichTextBox.Font.Name, horizontalScrollBar.Value, FontStyle.Regular);
            mainRichTextBox.SelectionFont = fontsize;
            fontSize = horizontalScrollBar.Value;
        }

        private void changeText(object sender, EventArgs e)
        {

        }
    }
}
