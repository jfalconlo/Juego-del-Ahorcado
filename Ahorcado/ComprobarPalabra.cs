using System;
using System.Windows.Forms;

namespace Ahorcado
{
    public partial class ComprobarPalabra : Form
    {
        public ComprobarPalabra()
        {
            InitializeComponent();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            if (textBoxComprobarPalabra.Text.Length < 0)
            {

            }
            else
            {
                DialogResult = DialogResult.OK;
            }
            this.Close();
        }
    }
}
