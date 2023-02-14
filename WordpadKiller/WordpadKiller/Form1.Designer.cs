namespace WordpadKiller
{
    partial class Form1
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
            this.label_font = new System.Windows.Forms.Label();
            this.label_size = new System.Windows.Forms.Label();
            this.label_fontstyle = new System.Windows.Forms.Label();
            this.label_alignment = new System.Windows.Forms.Label();
            this.label_color = new System.Windows.Forms.Label();
            this.comboBox_font = new System.Windows.Forms.ComboBox();
            this.button_font1 = new System.Windows.Forms.Button();
            this.button_font2 = new System.Windows.Forms.Button();
            this.button_font3 = new System.Windows.Forms.Button();
            this.button_aleft = new System.Windows.Forms.Button();
            this.button_acentre = new System.Windows.Forms.Button();
            this.button_aright = new System.Windows.Forms.Button();
            this.comboBox_colors = new System.Windows.Forms.ComboBox();
            this.textBox_load = new System.Windows.Forms.TextBox();
            this.textBox_save = new System.Windows.Forms.TextBox();
            this.button_load = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.numericUpDown_size = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_size)).BeginInit();
            this.SuspendLayout();
            // 
            // label_font
            // 
            this.label_font.AutoSize = true;
            this.label_font.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_font.Location = new System.Drawing.Point(48, 10);
            this.label_font.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_font.Name = "label_font";
            this.label_font.Size = new System.Drawing.Size(42, 18);
            this.label_font.TabIndex = 0;
            this.label_font.Text = "Font";
            // 
            // label_size
            // 
            this.label_size.AutoSize = true;
            this.label_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_size.Location = new System.Drawing.Point(155, 10);
            this.label_size.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(41, 18);
            this.label_size.TabIndex = 1;
            this.label_size.Text = "Size";
            // 
            // label_fontstyle
            // 
            this.label_fontstyle.AutoSize = true;
            this.label_fontstyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_fontstyle.Location = new System.Drawing.Point(264, 10);
            this.label_fontstyle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_fontstyle.Name = "label_fontstyle";
            this.label_fontstyle.Size = new System.Drawing.Size(79, 18);
            this.label_fontstyle.TabIndex = 2;
            this.label_fontstyle.Text = "FontStyle";
            // 
            // label_alignment
            // 
            this.label_alignment.AutoSize = true;
            this.label_alignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_alignment.Location = new System.Drawing.Point(408, 10);
            this.label_alignment.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_alignment.Name = "label_alignment";
            this.label_alignment.Size = new System.Drawing.Size(81, 18);
            this.label_alignment.TabIndex = 3;
            this.label_alignment.Text = "Alignment";
            // 
            // label_color
            // 
            this.label_color.AutoSize = true;
            this.label_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_color.Location = new System.Drawing.Point(561, 10);
            this.label_color.Name = "label_color";
            this.label_color.Size = new System.Drawing.Size(50, 18);
            this.label_color.TabIndex = 4;
            this.label_color.Text = "Color";
            // 
            // comboBox_font
            // 
            this.comboBox_font.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_font.FormattingEnabled = true;
            this.comboBox_font.Items.AddRange(new object[] {
            "Algerian",
            "Arial Narrow",
            "Impact",
            "Verdana",
            "Jokerman",
            "Cooper Black",
            "Marlett",
            "Arial"});
            this.comboBox_font.Location = new System.Drawing.Point(26, 44);
            this.comboBox_font.Name = "comboBox_font";
            this.comboBox_font.Size = new System.Drawing.Size(101, 26);
            this.comboBox_font.TabIndex = 5;
            this.comboBox_font.SelectedIndexChanged += new System.EventHandler(this.comboBox_font_SelectedIndexChanged);
            // 
            // button_font1
            // 
            this.button_font1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_font1.Location = new System.Drawing.Point(256, 41);
            this.button_font1.Name = "button_font1";
            this.button_font1.Size = new System.Drawing.Size(25, 28);
            this.button_font1.TabIndex = 7;
            this.button_font1.Text = "B";
            this.button_font1.UseVisualStyleBackColor = true;
            this.button_font1.Click += new System.EventHandler(this.button_font1_Click);
            // 
            // button_font2
            // 
            this.button_font2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_font2.Location = new System.Drawing.Point(287, 41);
            this.button_font2.Name = "button_font2";
            this.button_font2.Size = new System.Drawing.Size(25, 28);
            this.button_font2.TabIndex = 8;
            this.button_font2.Text = "U";
            this.button_font2.UseVisualStyleBackColor = true;
            this.button_font2.Click += new System.EventHandler(this.button_font2_Click);
            // 
            // button_font3
            // 
            this.button_font3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_font3.Location = new System.Drawing.Point(318, 42);
            this.button_font3.Name = "button_font3";
            this.button_font3.Size = new System.Drawing.Size(25, 28);
            this.button_font3.TabIndex = 9;
            this.button_font3.Text = "I";
            this.button_font3.UseVisualStyleBackColor = true;
            this.button_font3.Click += new System.EventHandler(this.button_font3_Click);
            // 
            // button_aleft
            // 
            this.button_aleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_aleft.Location = new System.Drawing.Point(402, 42);
            this.button_aleft.Name = "button_aleft";
            this.button_aleft.Size = new System.Drawing.Size(25, 28);
            this.button_aleft.TabIndex = 7;
            this.button_aleft.Text = "L";
            this.button_aleft.UseVisualStyleBackColor = true;
            this.button_aleft.Click += new System.EventHandler(this.button_aleft_Click);
            // 
            // button_acentre
            // 
            this.button_acentre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_acentre.Location = new System.Drawing.Point(433, 42);
            this.button_acentre.Name = "button_acentre";
            this.button_acentre.Size = new System.Drawing.Size(25, 28);
            this.button_acentre.TabIndex = 7;
            this.button_acentre.Text = "C";
            this.button_acentre.UseVisualStyleBackColor = true;
            this.button_acentre.Click += new System.EventHandler(this.button_acentre_Click);
            // 
            // button_aright
            // 
            this.button_aright.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_aright.Location = new System.Drawing.Point(464, 42);
            this.button_aright.Name = "button_aright";
            this.button_aright.Size = new System.Drawing.Size(25, 28);
            this.button_aright.TabIndex = 7;
            this.button_aright.Text = "R";
            this.button_aright.UseVisualStyleBackColor = true;
            this.button_aright.Click += new System.EventHandler(this.button_aright_Click);
            // 
            // comboBox_colors
            // 
            this.comboBox_colors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_colors.FormattingEnabled = true;
            this.comboBox_colors.Items.AddRange(new object[] {
            "BackColor",
            "ForeColor"});
            this.comboBox_colors.Location = new System.Drawing.Point(532, 43);
            this.comboBox_colors.Name = "comboBox_colors";
            this.comboBox_colors.Size = new System.Drawing.Size(100, 26);
            this.comboBox_colors.TabIndex = 10;
            this.comboBox_colors.SelectedIndexChanged += new System.EventHandler(this.comboBox_colors_SelectedIndexChanged);
            // 
            // textBox_load
            // 
            this.textBox_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_load.Location = new System.Drawing.Point(698, 10);
            this.textBox_load.Name = "textBox_load";
            this.textBox_load.Size = new System.Drawing.Size(211, 24);
            this.textBox_load.TabIndex = 11;
            // 
            // textBox_save
            // 
            this.textBox_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_save.Location = new System.Drawing.Point(698, 44);
            this.textBox_save.Name = "textBox_save";
            this.textBox_save.Size = new System.Drawing.Size(211, 24);
            this.textBox_save.TabIndex = 11;
            // 
            // button_load
            // 
            this.button_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_load.Location = new System.Drawing.Point(915, 10);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(75, 25);
            this.button_load.TabIndex = 12;
            this.button_load.Text = "Load";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save.Location = new System.Drawing.Point(915, 43);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 26);
            this.button_save.TabIndex = 12;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(26, 100);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(964, 395);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // numericUpDown_size
            // 
            this.numericUpDown_size.Location = new System.Drawing.Point(149, 44);
            this.numericUpDown_size.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.numericUpDown_size.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown_size.Name = "numericUpDown_size";
            this.numericUpDown_size.Size = new System.Drawing.Size(67, 26);
            this.numericUpDown_size.TabIndex = 14;
            this.numericUpDown_size.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown_size.ValueChanged += new System.EventHandler(this.numericUpDown_size_ValueChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.numericUpDown_size);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.textBox_save);
            this.Controls.Add(this.textBox_load);
            this.Controls.Add(this.comboBox_colors);
            this.Controls.Add(this.button_font3);
            this.Controls.Add(this.button_font2);
            this.Controls.Add(this.button_aright);
            this.Controls.Add(this.button_acentre);
            this.Controls.Add(this.button_aleft);
            this.Controls.Add(this.button_font1);
            this.Controls.Add(this.comboBox_font);
            this.Controls.Add(this.label_color);
            this.Controls.Add(this.label_alignment);
            this.Controls.Add(this.label_fontstyle);
            this.Controls.Add(this.label_size);
            this.Controls.Add(this.label_font);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_font;
        private System.Windows.Forms.Label label_size;
        private System.Windows.Forms.Label label_fontstyle;
        private System.Windows.Forms.Label label_alignment;
        private System.Windows.Forms.Label label_color;
        private System.Windows.Forms.ComboBox comboBox_font;
        private System.Windows.Forms.Button button_font1;
        private System.Windows.Forms.Button button_font2;
        private System.Windows.Forms.Button button_font3;
        private System.Windows.Forms.Button button_aleft;
        private System.Windows.Forms.Button button_acentre;
        private System.Windows.Forms.Button button_aright;
        private System.Windows.Forms.ComboBox comboBox_colors;
        private System.Windows.Forms.TextBox textBox_load;
        private System.Windows.Forms.TextBox textBox_save;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NumericUpDown numericUpDown_size;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

