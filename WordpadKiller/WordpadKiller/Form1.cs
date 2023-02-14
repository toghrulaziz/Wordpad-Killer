using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WordpadKiller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox_font_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontFamily fontFamily = new FontFamily("Arial");
            if (comboBox_font.SelectedItem.ToString() != null)
            {
                string styleName = comboBox_font.SelectedItem.ToString();
                fontFamily = new FontFamily(styleName);
            }

            richTextBox1.SelectionFont = new Font(fontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
        }

        private void numericUpDown_size_ValueChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, (int)numericUpDown_size.Value);
        }

        private void button_font1_Click(object sender, EventArgs e)
        {
            FontStyle selectedStyle = FontStyle.Bold;
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, selectedStyle);
        }

        private void button_font2_Click(object sender, EventArgs e)
        {
            FontStyle selectedStyle = FontStyle.Underline;
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, selectedStyle);
        }

        private void button_font3_Click(object sender, EventArgs e)
        {
            FontStyle selectedStyle = FontStyle.Italic;
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, selectedStyle);
        }

        private void button_aleft_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void button_acentre_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button_aright_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void comboBox_colors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_colors.SelectedIndex == 0)
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.BackColor = colorDialog.Color;
                }
            }
            else if (comboBox_colors.SelectedIndex == 1)
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.ForeColor = colorDialog.Color;
                }
            }

        }

        private void button_load_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = textBox_load.Text;
            if (File.Exists(openFileDialog1.FileName))
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("File does not exist!");
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = textBox_save.Text;
            if (File.Exists(saveFileDialog1.FileName))
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }
            else
            {
                MessageBox.Show("File does not exist!");
            }
        }

    }
}
