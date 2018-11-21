using ConsoleApp_BlockEncrypt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            char[,] charmat = mat.GetMatrix();
            panel1.Controls.Clear();
            for (int i = 0; i < charmat.GetLength(0); i++)
            {
                for (int j = 0; j < charmat.GetLength(1); j++)
                {
                    panel1.Controls.Add(new Label() { Name=string.Format("{0}-{1}",i,j), Font= new Font("YaHei", 20, FontStyle.Bold), BorderStyle= BorderStyle.Fixed3D, Text = charmat[i,j].ToString(), Height=50, Width = 50, Location = new Point(j * 50, i*50) });
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
            if (step <= textBoxOrg.Text.Length / 2)
            {
                BlockEncrypt blockEncrypt = new BlockEncrypt(mat);
                Position position;
                textBoxResult.Text += blockEncrypt.EncryptByStep(textBoxOrg.Text, step, out position);
                var lA = panel1.Controls.Find(string.Format("{0}-{1}", position.rowIndexOfA, position.colIndexOfA), true);
                var lA2 = panel1.Controls.Find(string.Format("{0}-{1}", position.rowIndexOfB, position.colIndexOfA), true);
                var lB = panel1.Controls.Find(string.Format("{0}-{1}", position.rowIndexOfB, position.colIndexOfB), true);
                var lB2 = panel1.Controls.Find(string.Format("{0}-{1}", position.rowIndexOfA, position.colIndexOfB), true);
                (lA[0] as Label).BackColor = Color.Green;
                (lB[0] as Label).BackColor = Color.Green;
                (lA2[0] as Label).BackColor = Color.Yellow;
                (lB2[0] as Label).BackColor = Color.Yellow;
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
    }
}
