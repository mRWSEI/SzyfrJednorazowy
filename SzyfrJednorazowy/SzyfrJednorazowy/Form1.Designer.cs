namespace SzyfrJednorazowy
{
    partial class FrmCipher
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
            this.textBoxTextToCipher = new System.Windows.Forms.TextBox();
            this.lblTextToCipher = new System.Windows.Forms.Label();
            this.labelPrivateKey = new System.Windows.Forms.Label();
            this.textBoxPrivateKey = new System.Windows.Forms.TextBox();
            this.labelCipheredText = new System.Windows.Forms.Label();
            this.textBoxCipheredText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxTextToCipher
            // 
            this.textBoxTextToCipher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTextToCipher.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxTextToCipher.Location = new System.Drawing.Point(12, 25);
            this.textBoxTextToCipher.Multiline = true;
            this.textBoxTextToCipher.Name = "textBoxTextToCipher";
            this.textBoxTextToCipher.Size = new System.Drawing.Size(398, 98);
            this.textBoxTextToCipher.TabIndex = 0;
            this.textBoxTextToCipher.TextChanged += new System.EventHandler(this.textBoxTextToCipher_TextChanged);
            // 
            // lblTextToCipher
            // 
            this.lblTextToCipher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextToCipher.AutoSize = true;
            this.lblTextToCipher.Location = new System.Drawing.Point(12, 9);
            this.lblTextToCipher.Name = "lblTextToCipher";
            this.lblTextToCipher.Size = new System.Drawing.Size(73, 13);
            this.lblTextToCipher.TabIndex = 1;
            this.lblTextToCipher.Text = "Text to Cipher";
            // 
            // labelPrivateKey
            // 
            this.labelPrivateKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrivateKey.AutoSize = true;
            this.labelPrivateKey.Location = new System.Drawing.Point(12, 132);
            this.labelPrivateKey.Name = "labelPrivateKey";
            this.labelPrivateKey.Size = new System.Drawing.Size(58, 13);
            this.labelPrivateKey.TabIndex = 3;
            this.labelPrivateKey.Text = "PrivateKey";
            // 
            // textBoxPrivateKey
            // 
            this.textBoxPrivateKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrivateKey.Location = new System.Drawing.Point(12, 148);
            this.textBoxPrivateKey.Multiline = true;
            this.textBoxPrivateKey.Name = "textBoxPrivateKey";
            this.textBoxPrivateKey.Size = new System.Drawing.Size(398, 98);
            this.textBoxPrivateKey.TabIndex = 2;
            // 
            // labelCipheredText
            // 
            this.labelCipheredText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCipheredText.AutoSize = true;
            this.labelCipheredText.Location = new System.Drawing.Point(12, 255);
            this.labelCipheredText.Name = "labelCipheredText";
            this.labelCipheredText.Size = new System.Drawing.Size(70, 13);
            this.labelCipheredText.TabIndex = 5;
            this.labelCipheredText.Text = "CipheredText";
            // 
            // textBoxCipheredText
            // 
            this.textBoxCipheredText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCipheredText.Location = new System.Drawing.Point(12, 271);
            this.textBoxCipheredText.Multiline = true;
            this.textBoxCipheredText.Name = "textBoxCipheredText";
            this.textBoxCipheredText.Size = new System.Drawing.Size(398, 98);
            this.textBoxCipheredText.TabIndex = 4;
            // 
            // FrmCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 381);
            this.Controls.Add(this.labelCipheredText);
            this.Controls.Add(this.textBoxCipheredText);
            this.Controls.Add(this.labelPrivateKey);
            this.Controls.Add(this.textBoxPrivateKey);
            this.Controls.Add(this.lblTextToCipher);
            this.Controls.Add(this.textBoxTextToCipher);
            this.Name = "FrmCipher";
            this.Text = "CipherText";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTextToCipher;
        private System.Windows.Forms.Label lblTextToCipher;
        private System.Windows.Forms.Label labelPrivateKey;
        private System.Windows.Forms.TextBox textBoxPrivateKey;
        private System.Windows.Forms.Label labelCipheredText;
        private System.Windows.Forms.TextBox textBoxCipheredText;
    }
}

