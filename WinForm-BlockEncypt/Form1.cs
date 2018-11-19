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
                    panel1.Controls.Add(new Label() { Font= new Font("YaHei", 20, FontStyle.Bold), BorderStyle= BorderStyle.Fixed3D, Text = charmat[i,j].ToString(), Height=50, Width = 50, Location = new Point(j * 50, i*50) });
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {       

            for (int i = 0; i < 10; i++)
            {
                panel1.Controls.Add(new Label() {Text=i.ToString(), Width=20, Location= new Point(i*20,0) });
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
    }
}
