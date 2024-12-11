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

namespace BT5_Soanthaovanban
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.Text = "Tahoma";
            toolStripComboBox2.Text = "14";
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                toolStripComboBox1.Items.Add(font.Name);
            }
            List<int> listSize = new List<int> { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (var s in listSize)
            {
                toolStripComboBox2.Items.Add(s);
            }
        }

        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richText.Clear();
            toolStripComboBox1.Text = "Tahoma";
            toolStripComboBox2.Text = "14";
            richText.Font = new Font("Tahoma", 14);
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Rich Text Format (*.rtf)|*.rtf|Text File (*.txt)|*.txt",
                Title = "Mở tập tin văn bản"
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog.FileName.EndsWith(".rtf"))
                    {
                        richText.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        richText.Text = File.ReadAllText(openFileDialog.FileName);
                    }
                }
            }
        }

        private void lưuNộiDungVănBảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Lưu tập tin văn bản",
                Filter = "Rich Text Format (*.rtf)|*.rtf|Text File (*.txt)|*.txt",
                DefaultExt = "rtf"
            })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    if (filePath.EndsWith(".rtf"))
                    {
                        richText.SaveFile(filePath, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        File.WriteAllText(filePath, richText.Text);
                    }

                    MessageBox.Show("Lưu tập tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richText.SelectedText))
            {
                // Lấy font hiện tại
                Font currentFont = richText.SelectionFont;

                // Nếu font chưa có kiểu Bold, thêm kiểu Bold
                if (currentFont != null)
                {
                    FontStyle newFontStyle = currentFont.Bold ? FontStyle.Regular : FontStyle.Bold;
                    richText.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn văn bản trước khi thực hiện chức năng in đậm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richText.SelectedText))
            {
                // Lấy font hiện tại
                Font currentFont = richText.SelectionFont;

                // Nếu font chưa có kiểu Italic, thêm kiểu Italic
                if (currentFont != null)
                {
                    FontStyle newFontStyle = currentFont.Italic ? FontStyle.Regular : FontStyle.Italic;
                    richText.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn văn bản trước khi thực hiện chức năng in nghiêng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richText.SelectedText))
            {
                // Lấy font hiện tại
                Font currentFont = richText.SelectionFont;

                // Nếu font chưa có kiểu Underline, thêm kiểu Underline
                if (currentFont != null)
                {
                    FontStyle newFontStyle = currentFont.Underline ? FontStyle.Regular : FontStyle.Underline;
                    richText.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn văn bản trước khi thực hiện chức năng gạch chân.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richText.Clear();
            toolStripComboBox1.Text = "Tahoma";
            toolStripComboBox2.Text = "14";
            richText.Font = new Font("Tahoma", 14);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Lưu tập tin văn bản",
                Filter = "Rich Text Format (*.rtf)|*.rtf|Text File (*.txt)|*.txt",
                DefaultExt = "rtf"
            })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    if (filePath.EndsWith(".rtf"))
                    {
                        richText.SaveFile(filePath, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        File.WriteAllText(filePath, richText.Text);
                    }

                    MessageBox.Show("Lưu tập tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
