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
            this.textBoxOrg = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonEnCrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonEncryptStep = new System.Windows.Forms.Button();
            this.buttonSaveMatrix = new System.Windows.Forms.Button();
            this.buttonLoadMatrix = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonLoadText = new System.Windows.Forms.Button();
            this.buttonSaveText = new System.Windows.Forms.Button();
            this.checkBoxShowMatrix = new System.Windows.Forms.CheckBox();
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
            // textBoxOrg
            // 
            this.textBoxOrg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxOrg.Location = new System.Drawing.Point(47, 469);
            this.textBoxOrg.Multiline = true;
            this.textBoxOrg.Name = "textBoxOrg";
            this.textBoxOrg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOrg.Size = new System.Drawing.Size(600, 64);
            this.textBoxOrg.TabIndex = 4;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxResult.Location = new System.Drawing.Point(47, 605);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResult.Size = new System.Drawing.Size(600, 64);
            this.textBoxResult.TabIndex = 5;
            // 
            // buttonEnCrypt
            // 
            this.buttonEnCrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEnCrypt.Location = new System.Drawing.Point(50, 557);
            this.buttonEnCrypt.Name = "buttonEnCrypt";
            this.buttonEnCrypt.Size = new System.Drawing.Size(75, 23);
            this.buttonEnCrypt.TabIndex = 6;
            this.buttonEnCrypt.Text = "加密";
            this.buttonEnCrypt.UseVisualStyleBackColor = true;
            this.buttonEnCrypt.Click += new System.EventHandler(this.buttonEnCrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDecrypt.Location = new System.Drawing.Point(147, 557);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(75, 23);
            this.buttonDecrypt.TabIndex = 7;
            this.buttonDecrypt.Text = "解密";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonEncryptStep
            // 
            this.buttonEncryptStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEncryptStep.Location = new System.Drawing.Point(354, 557);
            this.buttonEncryptStep.Name = "buttonEncryptStep";
            this.buttonEncryptStep.Size = new System.Drawing.Size(75, 23);
            this.buttonEncryptStep.TabIndex = 8;
            this.buttonEncryptStep.Text = "加密一步";
            this.buttonEncryptStep.UseVisualStyleBackColor = true;
            this.buttonEncryptStep.Click += new System.EventHandler(this.buttonEncryptStep_Click);
            // 
            // buttonSaveMatrix
            // 
            this.buttonSaveMatrix.Location = new System.Drawing.Point(159, 12);
            this.buttonSaveMatrix.Name = "buttonSaveMatrix";
            this.buttonSaveMatrix.Size = new System.Drawing.Size(78, 34);
            this.buttonSaveMatrix.TabIndex = 9;
            this.buttonSaveMatrix.Text = "保存矩阵";
            this.buttonSaveMatrix.UseVisualStyleBackColor = true;
            this.buttonSaveMatrix.Click += new System.EventHandler(this.buttonSaveMatrix_Click);
            // 
            // buttonLoadMatrix
            // 
            this.buttonLoadMatrix.Location = new System.Drawing.Point(269, 12);
            this.buttonLoadMatrix.Name = "buttonLoadMatrix";
            this.buttonLoadMatrix.Size = new System.Drawing.Size(78, 34);
            this.buttonLoadMatrix.TabIndex = 10;
            this.buttonLoadMatrix.Text = "载入矩阵";
            this.buttonLoadMatrix.UseVisualStyleBackColor = true;
            this.buttonLoadMatrix.Click += new System.EventHandler(this.buttonLoadMatrix_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClear.Location = new System.Drawing.Point(50, 686);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "清空";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonLoadText
            // 
            this.buttonLoadText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLoadText.Location = new System.Drawing.Point(247, 557);
            this.buttonLoadText.Name = "buttonLoadText";
            this.buttonLoadText.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadText.TabIndex = 12;
            this.buttonLoadText.Text = "载入文本";
            this.buttonLoadText.UseVisualStyleBackColor = true;
            this.buttonLoadText.Click += new System.EventHandler(this.buttonLoadText_Click);
            // 
            // buttonSaveText
            // 
            this.buttonSaveText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSaveText.Location = new System.Drawing.Point(147, 686);
            this.buttonSaveText.Name = "buttonSaveText";
            this.buttonSaveText.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveText.TabIndex = 13;
            this.buttonSaveText.Text = "保存文本";
            this.buttonSaveText.UseVisualStyleBackColor = true;
            this.buttonSaveText.Click += new System.EventHandler(this.buttonSaveText_Click);
            // 
            // checkBoxShowMatrix
            // 
            this.checkBoxShowMatrix.AutoSize = true;
            this.checkBoxShowMatrix.Checked = true;
            this.checkBoxShowMatrix.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowMatrix.Location = new System.Drawing.Point(440, 22);
            this.checkBoxShowMatrix.Name = "checkBoxShowMatrix";
            this.checkBoxShowMatrix.Size = new System.Drawing.Size(72, 16);
            this.checkBoxShowMatrix.TabIndex = 15;
            this.checkBoxShowMatrix.Text = "显示矩阵";
            this.checkBoxShowMatrix.UseVisualStyleBackColor = true;
            this.checkBoxShowMatrix.CheckedChanged += new System.EventHandler(this.checkBoxShowMatrix_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 744);
            this.Controls.Add(this.checkBoxShowMatrix);
            this.Controls.Add(this.buttonSaveText);
            this.Controls.Add(this.buttonLoadText);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonLoadMatrix);
            this.Controls.Add(this.buttonSaveMatrix);
            this.Controls.Add(this.buttonEncryptStep);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEnCrypt);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxOrg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonGenerateMat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlockEncrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerateMat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxOrg;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonEnCrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonEncryptStep;
        private System.Windows.Forms.Button buttonSaveMatrix;
        private System.Windows.Forms.Button buttonLoadMatrix;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonLoadText;
        private System.Windows.Forms.Button buttonSaveText;
        private System.Windows.Forms.CheckBox checkBoxShowMatrix;
    }
}

