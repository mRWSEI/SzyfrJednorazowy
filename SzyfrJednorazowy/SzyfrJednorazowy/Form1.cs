using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzyfrJednorazowy
{
    public partial class FrmCipher : Form
    {
        public FrmCipher()
        {
            InitializeComponent();
        }

        private void textBoxTextToCipher_TextChanged(object sender, EventArgs e)
        {
            CipherLib.OTPCipher cipher = new CipherLib.OTPCipher(textBoxTextToCipher.Text ?? "");
            textBoxPrivateKey.Text = cipher.GeneratePrivateKey();
            textBoxCipheredText.Text = cipher.CipherMessage();
        }
    }
}
