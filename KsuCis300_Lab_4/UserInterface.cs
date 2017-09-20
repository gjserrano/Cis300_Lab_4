using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KsuCis300_Lab_4
{
    public partial class UserInterface : Form
    {
        /// <summary>
        /// Initializes the UserInterface
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The EventHandler for the "Open..." section of the uxMenuStrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(uxOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    uxTextBox.Text = File.ReadAllText(uxOpenFileDialog.FileName);
                }
                catch(Exception ex)
                {
                    DisplayError(ex);
                }
            }
        }

        /// <summary>
        /// The EventHandler for the "Save As..." section of the MenuStrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(uxSaveFileDialog.FileName, uxTextBox.Text);
            }
            catch(Exception ex)
            {
                DisplayError(ex);
            }
        }

        /// <summary>
        /// A method created to Display errors
        /// </summary>
        /// <param name="ex">The error being displayed</param>
        private void DisplayError(Exception ex)
        {
            MessageBox.Show("The following error occured: " + ex);
        }

        /// <summary>
        /// Rotates the given character c n positions through the alphabet whose first
        /// letter is firstLetter and whose number of letters is alphabetLen. alphabetLen
        /// must be positive.
        /// </summary>
        /// <param name="c">The character to rotate.</param>
        /// <param name="n">The number of positions to rotate c.</param>
        /// <param name="firstLetter">The first letter of the alphabet.</param>
        /// <param name="alphabetLen">The number of letters in the alphabet.</param>
        /// <returns>The result of the rotation.</returns>
        private char Rotate(char c, int n, char firstLetter, int alphabetLen)
        {
            return (char)(firstLetter + (c - firstLetter + n) % alphabetLen);
        }

        /// <summary>
        /// Encrypts a specified character
        /// </summary>
        /// <param name="inputC">The character being encrypted</param>
        /// <returns></returns>
        private char Encrypt(char inputC)
        {
            char returnChar = 'a';

            if(inputC >= 'a' && inputC <= 'z')
            {
                returnChar = Rotate(inputC, 13, 'a', 26);
            }

            else if(inputC >= 'A' && inputC <= 'Z')
            {
                returnChar = Rotate(inputC, 13, 'A', 26);
            }

            else
            {
                returnChar = inputC;
            }

            return returnChar;
        }

        /// <summary>
        /// The EventHandler for the "With String..." section of the uxMenuStrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxWithString_Click(object sender, EventArgs e)
        {
            string text = uxTextBox.Text;
            string emptyString = "";

            foreach(char ch in text)
            {
                emptyString += Encrypt(ch);
            }

            uxTextBox.Text = emptyString;
        }

        /// <summary>
        /// The EventHandler for the "With StringBuilder..." Section of the uxMenuStrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxWithStringBuilder_Click(object sender, EventArgs e)
        {
            StringBuilder build = new StringBuilder();

            string text = uxTextBox.Text;

            foreach(char ch in text)
            {
                build.Append(Encrypt(ch));
            }

            uxTextBox.Text = build.ToString();
        }
    }
}