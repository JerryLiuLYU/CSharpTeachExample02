namespace WinForm_BlockEncypt
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
            this.buttonGenerateMat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxOrg = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonEnCrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGenerateMat
            // 
            this.buttonGenerateMat.Location = new System.Drawing.Point(47, 12);
            this.buttonGenerateMat.Name = "buttonGenerateMat";
            this.buttonGenerateMat.Size = new System.Drawing.Size(78, 34);
            this.buttonGenerateMat.TabIndex = 0;
            this.buttonGenerateMat.Text = "生成矩阵";
            this.buttonGenerateMat.UseVisualStyleBackColor = true;
            this.buttonGenerateMat.Click += new System.EventHandler(this.buttonGenerateMat_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(47, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 400);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "测试label的生成";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "载入矩阵";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBoxOrg
            // 
            this.textBoxOrg.Location = new System.Drawing.Point(47, 469);
            this.textBoxOrg.Multiline = true;
            this.textBoxOrg.Name = "textBoxOrg";
            this.textBoxOrg.Size = new System.Drawing.Size(600, 64);
            this.textBoxOrg.TabIndex = 4;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(47, 600);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(600, 64);
            this.textBoxResult.TabIndex = 5;
            // 
            // buttonEnCrypt
            // 
            this.buttonEnCrypt.Location = new System.Drawing.Point(65, 557);
            this.buttonEnCrypt.Name = "buttonEnCrypt";
            this.buttonEnCrypt.Size = new System.Drawing.Size(75, 23);
            this.buttonEnCrypt.TabIndex = 6;
            this.buttonEnCrypt.Text = "加密";
            this.buttonEnCrypt.UseVisualStyleBackColor = true;
            this.buttonEnCrypt.Click += new System.EventHandler(this.buttonEnCrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(561, 557);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(75, 23);
            this.buttonDecrypt.TabIndex = 7;
            this.buttonDecrypt.Text = "解密";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 687);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEnCrypt);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxOrg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonGenerateMat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerateMat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxOrg;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonEnCrypt;
        private System.Windows.Forms.Button buttonDecrypt;
    }
}

