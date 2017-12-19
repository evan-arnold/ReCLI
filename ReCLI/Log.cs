using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReCLI
{
    public sealed class Log
    {
        public RichTextBox RichTextBox { get; set; }
        public Log(RichTextBox richTextBox)
        {
            RichTextBox = richTextBox;
            RichTextBox.TextChanged += new EventHandler(RichTextBox_TextChanged);
        }
        delegate void SetTextCallback(string text);

        void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckKeyword((char)CharType.Success, Color.Green, 0);
            CheckKeyword((char)CharType.Information, Color.Blue, 0);
            CheckKeyword((char)CharType.Warning, Color.Yellow, 0);
            CheckKeyword((char)CharType.Error, Color.Red, 0);
        }
        private void CheckKeyword(char word, Color color, int startIndex)
        {
            if (this.RichTextBox.Text.Contains(word))
            {
                string sWord = word.ToString();
                int index = -1;
                int selectStart = this.RichTextBox.SelectionStart;

                while ((index = this.RichTextBox.Text.IndexOf(sWord, (index + 1))) != -1)
                {
                    this.RichTextBox.Select((index + startIndex), sWord.Length);
                    this.RichTextBox.SelectionColor = color;
                    this.RichTextBox.Select(selectStart, 0);
                    this.RichTextBox.SelectionColor = Color.Black;
                }
            }
        }
        public void Clear()
        {
            RichTextBox.Text = "Log:";
        }
        public void WriteTimestamp(string input)
        {
            RichTextBox.Text = RichTextBox.Text + Environment.NewLine + String.Format("[{0:d/M/yyyy HH:mm:ss}] " + input, DateTime.Now);
        }
        public void Write(string input)
        {
            if (RichTextBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(Write);
                RichTextBox.Invoke(d, new object[] { input });
            }
            else
            {
                RichTextBox.Text = RichTextBox.Text + Environment.NewLine + input;
            }
        }
        public void Write(string input, int type)
        {
            if (RichTextBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(Write);
                RichTextBox.Invoke(d, new object[] { input });
            }
            else
            {
                RichTextBox.Text = RichTextBox.Text + Environment.NewLine + input + Type(type);
            }
        }
        private string Type(int type)
        {
            string sType = " [";
            switch (type)
            {
                case 0:
                    sType = sType + (char)CharType.Success;
                    break;
                case 1:
                    sType = sType + (char)CharType.Information;
                    break;
                case 2:
                    sType = sType + (char)CharType.Warning;
                    break;
                case 3:
                    sType = sType + (char)CharType.Error;
                    break;
                default:
                    sType = sType + (char)CharType.Unknown;
                    break;
            }
            sType = sType + "]";
            return sType;
        }

        public enum MessageType : int
        {
            Success = 0,
            Information = 1,
            Warning = 2,
            Error = 3
        }
        public enum CharType : int
        {
            Success = '✓',
            Information = 'i',
            Warning = '!',
            Error = 'X',
            Unknown = '?'
        }
    }
}
