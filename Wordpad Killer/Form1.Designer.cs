namespace Wordpad_Killer
{
    partial class WordpadKiller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordpadKiller));
            this.textarea = new System.Windows.Forms.RichTextBox();
            this.fontlbl = new System.Windows.Forms.Label();
            this.fontstylelbl = new System.Windows.Forms.Label();
            this.alignment = new System.Windows.Forms.Label();
            this.colorlbl = new System.Windows.Forms.Label();
            this.sizelbl = new System.Windows.Forms.Label();
            this.fontscbox = new System.Windows.Forms.ComboBox();
            this.sizecbox = new System.Windows.Forms.ComboBox();
            this.leftbtn = new System.Windows.Forms.Button();
            this.centerbtn = new System.Windows.Forms.Button();
            this.rightbtn = new System.Windows.Forms.Button();
            this.Loadbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.italicbtn = new System.Windows.Forms.Button();
            this.underlinebtn = new System.Windows.Forms.Button();
            this.boldbtn = new System.Windows.Forms.Button();
            this.colorbtn = new System.Windows.Forms.Button();
            this.redo = new System.Windows.Forms.Button();
            this.undo = new System.Windows.Forms.Button();
            this.copy = new System.Windows.Forms.Button();
            this.paste = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // textarea
            // 
            this.textarea.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textarea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textarea.Location = new System.Drawing.Point(4, 61);
            this.textarea.Name = "textarea";
            this.textarea.Size = new System.Drawing.Size(1112, 497);
            this.textarea.TabIndex = 0;
            this.textarea.Text = "";
            // 
            // fontlbl
            // 
            this.fontlbl.AutoSize = true;
            this.fontlbl.Location = new System.Drawing.Point(52, 9);
            this.fontlbl.Name = "fontlbl";
            this.fontlbl.Size = new System.Drawing.Size(28, 13);
            this.fontlbl.TabIndex = 5;
            this.fontlbl.Text = "Font";
            // 
            // fontstylelbl
            // 
            this.fontstylelbl.AutoSize = true;
            this.fontstylelbl.Location = new System.Drawing.Point(437, 9);
            this.fontstylelbl.Name = "fontstylelbl";
            this.fontstylelbl.Size = new System.Drawing.Size(54, 13);
            this.fontstylelbl.TabIndex = 6;
            this.fontstylelbl.Text = "Font Style";
            // 
            // alignment
            // 
            this.alignment.AutoSize = true;
            this.alignment.Location = new System.Drawing.Point(619, 9);
            this.alignment.Name = "alignment";
            this.alignment.Size = new System.Drawing.Size(53, 13);
            this.alignment.TabIndex = 7;
            this.alignment.Text = "Alignment";
            // 
            // colorlbl
            // 
            this.colorlbl.AutoSize = true;
            this.colorlbl.Location = new System.Drawing.Point(796, 9);
            this.colorlbl.Name = "colorlbl";
            this.colorlbl.Size = new System.Drawing.Size(31, 13);
            this.colorlbl.TabIndex = 8;
            this.colorlbl.Text = "Color";
            // 
            // sizelbl
            // 
            this.sizelbl.AutoSize = true;
            this.sizelbl.Location = new System.Drawing.Point(347, 9);
            this.sizelbl.Name = "sizelbl";
            this.sizelbl.Size = new System.Drawing.Size(27, 13);
            this.sizelbl.TabIndex = 9;
            this.sizelbl.Text = "Size";
            // 
            // fontscbox
            // 
            this.fontscbox.FormattingEnabled = true;
            this.fontscbox.Location = new System.Drawing.Point(12, 34);
            this.fontscbox.Name = "fontscbox";
            this.fontscbox.Size = new System.Drawing.Size(121, 21);
            this.fontscbox.TabIndex = 10;
            this.fontscbox.SelectedIndexChanged += new System.EventHandler(this.FontChangning);
            // 
            // sizecbox
            // 
            this.sizecbox.FormattingEnabled = true;
            this.sizecbox.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70"});
            this.sizecbox.Location = new System.Drawing.Point(335, 33);
            this.sizecbox.Name = "sizecbox";
            this.sizecbox.Size = new System.Drawing.Size(40, 21);
            this.sizecbox.TabIndex = 11;
            this.sizecbox.SelectedIndexChanged += new System.EventHandler(this.SizeChangning);
            // 
            // leftbtn
            // 
            this.leftbtn.Location = new System.Drawing.Point(586, 34);
            this.leftbtn.Name = "leftbtn";
            this.leftbtn.Size = new System.Drawing.Size(33, 21);
            this.leftbtn.TabIndex = 12;
            this.leftbtn.Text = "L";
            this.leftbtn.UseVisualStyleBackColor = true;
            this.leftbtn.Click += new System.EventHandler(this.Alignment);
            this.leftbtn.MouseHover += new System.EventHandler(this.Tooltip);
            // 
            // centerbtn
            // 
            this.centerbtn.Location = new System.Drawing.Point(624, 34);
            this.centerbtn.Name = "centerbtn";
            this.centerbtn.Size = new System.Drawing.Size(33, 21);
            this.centerbtn.TabIndex = 13;
            this.centerbtn.Text = "C";
            this.centerbtn.UseVisualStyleBackColor = true;
            this.centerbtn.Click += new System.EventHandler(this.Alignment);
            this.centerbtn.MouseHover += new System.EventHandler(this.Tooltip);
            // 
            // rightbtn
            // 
            this.rightbtn.Location = new System.Drawing.Point(660, 34);
            this.rightbtn.Name = "rightbtn";
            this.rightbtn.Size = new System.Drawing.Size(33, 21);
            this.rightbtn.TabIndex = 14;
            this.rightbtn.Text = "R";
            this.rightbtn.UseVisualStyleBackColor = true;
            this.rightbtn.Click += new System.EventHandler(this.Alignment);
            this.rightbtn.MouseHover += new System.EventHandler(this.Tooltip);
            // 
            // Loadbtn
            // 
            this.Loadbtn.Location = new System.Drawing.Point(960, 4);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(133, 21);
            this.Loadbtn.TabIndex = 16;
            this.Loadbtn.Text = "LOAD";
            this.Loadbtn.UseVisualStyleBackColor = true;
            this.Loadbtn.Click += new System.EventHandler(this.Loadbtn_Click);
            this.Loadbtn.MouseHover += new System.EventHandler(this.Tooltip);
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(960, 32);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(133, 21);
            this.Savebtn.TabIndex = 17;
            this.Savebtn.Text = "SAVE";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            this.Savebtn.MouseHover += new System.EventHandler(this.Tooltip);
            // 
            // italicbtn
            // 
            this.italicbtn.BackColor = System.Drawing.Color.LightGray;
            this.italicbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.italicbtn.Location = new System.Drawing.Point(486, 34);
            this.italicbtn.Name = "italicbtn";
            this.italicbtn.Size = new System.Drawing.Size(33, 21);
            this.italicbtn.TabIndex = 20;
            this.italicbtn.Text = "I";
            this.italicbtn.UseVisualStyleBackColor = false;
            this.italicbtn.Click += new System.EventHandler(this.FontStyleChangning);
            this.italicbtn.MouseHover += new System.EventHandler(this.Tooltip);
            // 
            // underlinebtn
            // 
            this.underlinebtn.BackColor = System.Drawing.Color.LightGray;
            this.underlinebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.underlinebtn.Location = new System.Drawing.Point(447, 34);
            this.underlinebtn.Name = "underlinebtn";
            this.underlinebtn.Size = new System.Drawing.Size(33, 21);
            this.underlinebtn.TabIndex = 19;
            this.underlinebtn.Text = "U";
            this.underlinebtn.UseVisualStyleBackColor = false;
            this.underlinebtn.Click += new System.EventHandler(this.FontStyleChangning);
            this.underlinebtn.MouseHover += new System.EventHandler(this.Tooltip);
            // 
            // boldbtn
            // 
            this.boldbtn.BackColor = System.Drawing.Color.LightGray;
            this.boldbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boldbtn.Location = new System.Drawing.Point(410, 34);
            this.boldbtn.Name = "boldbtn";
            this.boldbtn.Size = new System.Drawing.Size(33, 21);
            this.boldbtn.TabIndex = 18;
            this.boldbtn.Text = "B";
            this.boldbtn.UseVisualStyleBackColor = false;
            this.boldbtn.Click += new System.EventHandler(this.FontStyleChangning);
            this.boldbtn.MouseHover += new System.EventHandler(this.Tooltip);
            // 
            // colorbtn
            // 
            this.colorbtn.Location = new System.Drawing.Point(789, 34);
            this.colorbtn.Name = "colorbtn";
            this.colorbtn.Size = new System.Drawing.Size(42, 21);
            this.colorbtn.TabIndex = 21;
            this.colorbtn.Text = ">";
            this.colorbtn.UseVisualStyleBackColor = true;
            this.colorbtn.Click += new System.EventHandler(this.colorbtn_Click);
            this.colorbtn.MouseHover += new System.EventHandler(this.Tooltip);
            // 
            // redo
            // 
            this.redo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.redo.Location = new System.Drawing.Point(270, 32);
            this.redo.Name = "redo";
            this.redo.Size = new System.Drawing.Size(31, 21);
            this.redo.TabIndex = 22;
            this.redo.Text = "->";
            this.redo.UseVisualStyleBackColor = false;
            this.redo.Click += new System.EventHandler(this.Do_Click);
            this.redo.MouseHover += new System.EventHandler(this.Tooltip);
            // 
            // undo
            // 
            this.undo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.undo.Location = new System.Drawing.Point(233, 32);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(31, 21);
            this.undo.TabIndex = 23;
            this.undo.Text = "<-";
            this.undo.UseVisualStyleBackColor = false;
            this.undo.Click += new System.EventHandler(this.Undo_Click);
            this.undo.MouseHover += new System.EventHandler(this.Tooltip);
            // 
            // copy
            // 
            this.copy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.copy.Font = new System.Drawing.Font("Microsoft Tai Le", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copy.Location = new System.Drawing.Point(149, 32);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(39, 21);
            this.copy.TabIndex = 24;
            this.copy.Text = "copy";
            this.copy.UseVisualStyleBackColor = false;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            this.copy.MouseHover += new System.EventHandler(this.Tooltip);
            // 
            // paste
            // 
            this.paste.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.paste.Font = new System.Drawing.Font("Microsoft Tai Le", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paste.Location = new System.Drawing.Point(191, 32);
            this.paste.Name = "paste";
            this.paste.Size = new System.Drawing.Size(39, 21);
            this.paste.TabIndex = 25;
            this.paste.Text = "paste";
            this.paste.UseVisualStyleBackColor = false;
            this.paste.Click += new System.EventHandler(this.paste_Click);
            this.paste.MouseHover += new System.EventHandler(this.Tooltip);
            // 
            // WordpadKiller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1120, 570);
            this.Controls.Add(this.paste);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.undo);
            this.Controls.Add(this.redo);
            this.Controls.Add(this.colorbtn);
            this.Controls.Add(this.italicbtn);
            this.Controls.Add(this.underlinebtn);
            this.Controls.Add(this.boldbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.rightbtn);
            this.Controls.Add(this.centerbtn);
            this.Controls.Add(this.leftbtn);
            this.Controls.Add(this.sizecbox);
            this.Controls.Add(this.fontscbox);
            this.Controls.Add(this.sizelbl);
            this.Controls.Add(this.colorlbl);
            this.Controls.Add(this.alignment);
            this.Controls.Add(this.fontstylelbl);
            this.Controls.Add(this.fontlbl);
            this.Controls.Add(this.textarea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1136, 609);
            this.MinimumSize = new System.Drawing.Size(1136, 609);
            this.Name = "WordpadKiller";
            this.Text = "Wordpad Killer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textarea;
        private System.Windows.Forms.Label fontlbl;
        private System.Windows.Forms.Label fontstylelbl;
        private System.Windows.Forms.Label alignment;
        private System.Windows.Forms.Label colorlbl;
        private System.Windows.Forms.Label sizelbl;
        private System.Windows.Forms.ComboBox fontscbox;
        private System.Windows.Forms.ComboBox sizecbox;
        private System.Windows.Forms.Button leftbtn;
        private System.Windows.Forms.Button centerbtn;
        private System.Windows.Forms.Button rightbtn;
        private System.Windows.Forms.Button Loadbtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button italicbtn;
        private System.Windows.Forms.Button underlinebtn;
        private System.Windows.Forms.Button boldbtn;
        private System.Windows.Forms.Button colorbtn;
        private System.Windows.Forms.Button redo;
        private System.Windows.Forms.Button undo;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.Button paste;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

