using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToggleSwitch.Utils;

namespace Wordpad_Killer
{
    public partial class WordpadKiller : Form
    {


        FontStyle fontStyle;

        bool isBold = false;
        bool isUnderlined = false;
        bool isItalic = false;

        public double FontSize { get; set; }


        public WordpadKiller()
        {
            InitializeComponent();
            sizecbox.TextChanged += Sizecbox_TextChanged;
            
            
            sizecbox.Text = Math.Round(textarea.Font.Size).ToString();
            
        }

      
        private void Sizecbox_TextChanged(object sender, EventArgs e)
        {
             
           textarea.Font = new Font(textarea.Font.FontFamily, float.Parse(sizecbox.Text));
         

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fontscbox.Items.AddRange(FontFamily.Families);
            fontscbox.DisplayMember = "Name";
            fontscbox.SelectedIndex = 0;
        }

      

        private void Alignment(object sender, EventArgs e)
        {
            var btn = sender as Button;

            switch (btn.Name)
            {
                case "leftbtn":
                    {
                        textarea.SelectionAlignment = HorizontalAlignment.Left;
                        break;
                    }
                case "centerbtn":
                    {
                        textarea.SelectionAlignment = HorizontalAlignment.Center;
                        break;
                    }
                case "rightbtn":
                    {
                        textarea.SelectionAlignment = HorizontalAlignment.Right;
                        break;
                    }
            }

        }

         

       
        private void colorbtn_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();

            c.ShowDialog();

            textarea.SelectionColor = c.Color;

        }

        private void SizeChangning(object sender, EventArgs e)
        {            

          textarea.SelectionFont = new Font(fontscbox.Text, Convert.ToInt32(sizecbox.Text));
        }

        private void FontStyleChangning(object sender, EventArgs e)
        {
            var style = sender as Button;
                        
            switch (style.Name)
            {

                case "boldbtn":
                    {
                        if (isBold)
                        {
                            isBold = false;
                            boldbtn.BackColor = Color.LightGray;
                        }
                        else
                        {
                            isBold = true;
                            boldbtn.BackColor = Color.White;

                        }

                        if (!string.IsNullOrEmpty(textarea.Text))
                        {
                            textarea.SelectionFont = new Font(fontscbox.Text, textarea.Font.Size, GetStyle());
                        }


                        break;
                    }
                case "underlinebtn":
                    {

                        if (isUnderlined)
                        {
                            isUnderlined = false;
                            underlinebtn.BackColor = Color.LightGray;

                        }
                        else
                        {
                            isUnderlined = true;
                            underlinebtn.BackColor = Color.White;

                        }

                        if (!string.IsNullOrEmpty(textarea.Text))
                        {
                            textarea.SelectionFont = new Font(fontscbox.Text, textarea.Font.Size, GetStyle());
                        }

                        break;
                    }
                case "italicbtn":
                    {

                        if (isItalic)
                        {
                            isItalic = false;
                            italicbtn.BackColor = Color.LightGray;

                        }
                        else
                        {
                            isItalic = true;
                            italicbtn.BackColor = Color.White;


                        }
                        if (!string.IsNullOrEmpty(textarea.Text))
                        {
                            textarea.SelectionFont = new Font(fontscbox.Text, textarea.Font.Size, GetStyle());
                        }

                        break;
                    }
                default:
                    break;
            }
          
        }
        private FontStyle GetStyle()
        {
            FontStyle Style = FontStyle.Regular;

            if (isBold)
            {
                Style = Style | FontStyle.Bold;
            }
            if (isItalic)
            {
                Style = Style | FontStyle.Italic;
            }
            if (isUnderlined)
            {
                Style = Style | FontStyle.Underline;
            }

            return Style;
        }

        private void FontChangning(object sender, EventArgs e)
        {
            if (textarea.Text.Length > 0)
            {
                textarea.SelectionFont = new Font(fontscbox.Text, textarea.Text.Length);

            }
            
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            textarea.Undo();
        }

        private void Do_Click(object sender, EventArgs e)
        {
            textarea.Redo();
        }
         
        private void Savebtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();

            sv.ShowDialog();

            textarea.SaveFile($"{sv.FileName}.rtf");
        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();

            of.Filter = "rtf files (*.rtf)|*.rtf|All files (*.*)|*.*";
            of.ShowDialog();
            textarea.LoadFile($"{of.FileName}");
        }

        private void copy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textarea.SelectedText))
            {
                Clipboard.SetText(textarea.SelectedText);
            }
        }

        private void paste_Click(object sender, EventArgs e)
        {
                textarea.SelectedText = Clipboard.GetText();
        }

        private void Tooltip(object sender, EventArgs e)
        {
            var btn = sender as Button;

            switch (btn.Name)
            {
                case "undo":
                    {
                        toolTip1.Show("Undo", sender as Button);
                        break;
                    }
                 case "redo":
                    {
                        toolTip1.Show("Redo", sender as Button);
                        break;
                    }
                case "copy":
                    {
                        toolTip1.Show("Copy", sender as Button);
                        break;
                    }
                case "paste":
                    {
                        toolTip1.Show("Paste", sender as Button);
                        break;
                    }
                case "boldbtn":
                    {
                        toolTip1.Show("Bold", sender as Button);
                        break;
                    }
                case "italicbtn":
                    {
                        toolTip1.Show("Italic", sender as Button);
                        break;
                    }
                case "underlinebtn":
                    {
                        toolTip1.Show("Underline", sender as Button);
                        break;
                    }
                case "leftbtn":
                    {
                        toolTip1.Show("Left Alignment", sender as Button);
                        break;
                    }
                case "rightbtn":
                    {
                        toolTip1.Show("Right Alignment", sender as Button);
                        break;
                    }
                case "centerbtn":
                    {
                        toolTip1.Show("Center Alignment", sender as Button);
                        break;
                    }
                case "colorbtn":
                    {
                        toolTip1.Show("Color picker", sender as Button);
                        break;
                    }
                case "Loadbtn":
                    {
                        toolTip1.Show("Load file", sender as Button);
                        break;

                    }
                case "Savebtn":
                    {
                        toolTip1.Show("Save file", sender as Button);
                        break;
                    }
            }
        }
    }
}
