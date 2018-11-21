using ConsoleApp_BlockEncrypt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_BlockEncypt
{
    public partial class Form1 : Form
    {
        private Matrix mat;
        private int step = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerateMat_Click(object sender, EventArgs e)
        {
            mat = new Matrix();
            mat.GenerateMat();
            DisplayMatrix();

        }

        private void DisplayMatrix()
        {
            char[,] charmat = mat.GetMatrix();
            panel1.Controls.Clear();
            for (int i = 0; i < charmat.GetLength(0); i++)
            {
                for (int j = 0; j < charmat.GetLength(1); j++)
                {
                    panel1.Controls.Add(new Label() { Name = string.Format("{0}-{1}", i, j), Font = new Font("YaHei", 20, FontStyle.Bold), BorderStyle = BorderStyle.Fixed3D, Text = charmat[i, j].ToString(), Height = 50, Width = 50, Location = new Point(j * 50, i * 50) });
                }
            }
        }

        private void buttonEnCrypt_Click(object sender, EventArgs e)
        {
            if (mat == null)
            {
                MessageBox.Show("没有任何可用矩阵！请首先生成或载入矩阵");
                return;
            }
            BlockEncrypt blockEncrypt = new BlockEncrypt(mat);
            textBoxResult.Text = blockEncrypt.Encrypt(textBoxOrg.Text);
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            if (mat == null)
            {
                MessageBox.Show("没有任何可用矩阵！请首先生成或载入矩阵");
                return;
            }
            BlockEncrypt blockEncrypt = new BlockEncrypt(mat);
            textBoxResult.Text = blockEncrypt.Decrypt(textBoxOrg.Text);
        }

        private void buttonEncryptStep_Click(object sender, EventArgs e)
        {
            foreach (var item in panel1.Controls)
            {
                if (item is Label)
                {
                    (item as Label).BackColor = Color.Empty;
                }
            }
            if (step ==1)
            {
                textBoxResult.Text = "";
            }
            if (step <= textBoxOrg.Text.Length / 2)
            {
                BlockEncrypt blockEncrypt = new BlockEncrypt(mat);
                Position position;
                textBoxResult.Text += blockEncrypt.EncryptByStep(textBoxOrg.Text, step, out position);
                var lA = panel1.Controls.Find(string.Format("{0}-{1}", position.rowIndexOfA, position.colIndexOfA), true);
                var lA2 = panel1.Controls.Find(string.Format("{0}-{1}", position.rowIndexOfB, position.colIndexOfA), true);
                var lB = panel1.Controls.Find(string.Format("{0}-{1}", position.rowIndexOfB, position.colIndexOfB), true);
                var lB2 = panel1.Controls.Find(string.Format("{0}-{1}", position.rowIndexOfA, position.colIndexOfB), true);
                if (lA.Length==1 && lA2.Length == 1 && lB.Length == 1 && lB2.Length == 1)
                {
                    (lA[0] as Label).BackColor = Color.Green;
                    (lB[0] as Label).BackColor = Color.Green;
                    (lA2[0] as Label).BackColor = Color.Yellow;
                    (lB2[0] as Label).BackColor = Color.Yellow;
                }
                
                step++;
            }
            else
            {
                if (textBoxResult.Text.Length == textBoxOrg.Text.Length-1)
                {
                    textBoxResult.Text += textBoxOrg.Text.Last();
                }
                else
                {
                    step = 1;
                    textBoxResult.Text = "";
                }
            }
        }

        private void buttonSaveMatrix_Click(object sender, EventArgs e)
        {
            if (mat == null)
            {
                MessageBox.Show("请首先生成矩阵，才能保存");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "matrix files (*.bin)|*.bin";
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string saveFileFullName = saveFileDialog.FileName;
                //保存矩阵数据
                // 创建文件
                try
                {
                    IFormatter serializer = new BinaryFormatter();
                    using (FileStream fs = new FileStream(saveFileFullName, FileMode.Create, FileAccess.Write))
                    {
                        serializer.Serialize(fs, mat);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("序列化出错！" + ex.ToString());
                }
            }

            
            
        }

        private void buttonLoadMatrix_Click(object sender, EventArgs e)
        {
            //读取矩阵数据
            OpenFileDialog openFileDialog1 = new OpenFileDialog();//打开文件对话框
            // openFileDialog1.InitialDirectory = "c:\\";//初始化路径
            openFileDialog1.Filter = "matrix files (*.bin)|*.bin|All files (*.*)|*.*";//过滤选项设置，文本文件，所有文件。
            openFileDialog1.FilterIndex = 1;//当前使用第二个过滤字符串
            openFileDialog1.RestoreDirectory = true;//对话框关闭时恢复原目录
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileFullName = openFileDialog1.FileName;
                try
                {
                    IFormatter serializer = new BinaryFormatter();

                    FileStream fs = new FileStream(fileFullName, FileMode.Open, FileAccess.Read);
                    mat = serializer.Deserialize(fs) as Matrix;
                    fs.Close();
                    DisplayMatrix();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("反序列化出错！" + ex.ToString());
                }
            }
            
            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
            step = 1;
        }

        private void buttonLoadText_Click(object sender, EventArgs e)
        {
            //读取矩阵数据
            OpenFileDialog openFileDialog = new OpenFileDialog();//打开文件对话框
            openFileDialog.Filter = "text files (*.txt)|*.txt|All files (*.*)|*.*";//过滤选项设置，文本文件，所有文件。
            openFileDialog.FilterIndex = 1;//当前使用第二个过滤字符串
            openFileDialog.RestoreDirectory = true;//对话框关闭时恢复原目录
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileFullName = openFileDialog.FileName;
                try
                {
                    using (var reader = new StreamReader(fileFullName))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            textBoxOrg.Text += line + "\r\n";
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("文件读取出错！" + ex.ToString());
                }
            }
        }

        private void buttonSaveText_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "")
            {
                MessageBox.Show("保存的文本为空");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "text files (*.txt)|*.txt";
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string saveFileFullName = saveFileDialog.FileName;
                //保存矩阵数据
                // 创建文件
                try
                {
                    using (var writer = new StreamWriter(saveFileFullName))
                    {
                        writer.Write(textBoxResult.Text);

                    }
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("序列化出错！" + ex.ToString());
                }
            }
        }

        private void checkBoxShowMatrix_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowMatrix.Checked)
            {
                panel1.Visible = true;
                // this.MinimumSize = new Size(this.Width, this.Height + panel1.Height);
                this.Height = this.Height + panel1.Height;
            }
            else
            {
                panel1.Visible = false;
                // this.MinimumSize = new Size(this.Width, this.Height - panel1.Height);
                this.Height = this.Height - panel1.Height;
            }
        }
    }
}
