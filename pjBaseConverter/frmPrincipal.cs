using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjBaseConverter
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtDecimal_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtDecimal.TextLength != 0)
            {
                long Hex = Convert.ToInt64(txtDecimal.Text);
                string Base16 = Convert.ToString(Hex, 16);
                txtHex.Text = Base16;

                long Octal = Convert.ToInt64(txtDecimal.Text);
                string Base8 = Convert.ToString(Octal, 8);
                txtOctal.Text = Base8;

                long Binary = Convert.ToInt64(txtDecimal.Text);
                string Base2 = Convert.ToString(Binary, 2);
                txtBinary.Text = Base2;

                long Base5 = base10ToBase5(Convert.ToInt64(txtDecimal.Text));
                txtBase5.Text = Base5.ToString();
            }
            else
            {
                txtHex.Text = "";
                txtOctal.Text = "";
                txtBinary.Text = "";
                txtBase5.Text = "";
            }
        }

        private void txtHex_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f') || c == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void txtHex_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtHex.TextLength != 0)
            {
                long Decimal = Convert.ToInt64(txtHex.Text, 16);
                string Base10 = Convert.ToString(Decimal);
                txtDecimal.Text = Base10;

                string Base8 = Convert.ToString(Decimal, 8);
                txtOctal.Text = Base8;

                string Base2 = Convert.ToString(Decimal, 2);
                txtBinary.Text = Base2;

                string Base5 = base10ToBase5(Decimal).ToString();
                txtBase5.Text = Base5;
            }
            else
            {
                txtDecimal.Text = "";
                txtOctal.Text = "";
                txtBinary.Text = "";
                txtBase5.Text = "";
            }
        }

        private void txtOctal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '7') || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void txtOctal_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtOctal.TextLength != 0)
            {
                long Decimal = Convert.ToInt64(txtOctal.Text, 8);
                string Base10 = Convert.ToString(Decimal);
                txtDecimal.Text = Base10;

                string Base16 = Convert.ToString(Decimal, 16);
                txtHex.Text = Base16;

                string Base2 = Convert.ToString(Decimal, 2);
                txtBinary.Text = Base2;

                string Base5 = base10ToBase5(Decimal).ToString();
                txtBase5.Text = Base5;
            }
            else
            {
                txtDecimal.Text = "";
                txtHex.Text = "";
                txtBinary.Text = "";
                txtBase5.Text = "";
            }
        }

        private void txtBinary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '1') || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void txtBinary_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtBinary.TextLength != 0)
            {
                long Decimal = Convert.ToInt64(txtBinary.Text, 2);
                string Base10 = Convert.ToString(Decimal);
                txtDecimal.Text = Base10;

                string Base8 = Convert.ToString(Decimal, 8);
                txtOctal.Text = Base8;

                string Base16 = Convert.ToString(Decimal, 16);
                txtHex.Text = Base16;

                string Base5 = base10ToBase5(Decimal).ToString();
                txtBase5.Text = Base5;
            }
            else
            {
                txtDecimal.Text = "";
                txtHex.Text = "";
                txtOctal.Text = "";
                txtBase5.Text = "";
            }
        }

        private void txtBase5_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtBase5.TextLength != 0)
            {
                long result = base5ToBase10(txtBase5.Text);

                string Base10 = Convert.ToString(result, 10);
                txtDecimal.Text = Base10;

                string Base8 = Convert.ToString(result, 8);
                txtOctal.Text = Base8;

                string Base16 = Convert.ToString(result, 16);
                txtHex.Text = Base16;

                string Base2 = Convert.ToString(result, 2);
                txtBinary.Text = Base2;

            }
            else
            {
                txtDecimal.Text = "";
                txtHex.Text = "";
                txtOctal.Text = "";
                txtBinary.Text = "";
            }
        }
        private void txtBase5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '4') || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private long base5ToBase10(string base5String)
        {
            char[] vector = base5String.ToArray();
            int fator = base5String.Length - 1;
            int j = 0;
            long dec = 0;
            int separador = 0;
            while (fator >= 0)
            {
                separador = Convert.ToInt32(vector[j].ToString());
                dec += (separador * (long)(Math.Pow(5, fator)));
                j++;
                fator--;
            }
            return dec;
        }

        private long base10ToBase5 (long dec)
        {

            string octalNumber = "";

            while(dec != 0)
            {
                octalNumber = Convert.ToString(dec % 5) + octalNumber;
                dec = dec / 5;
            }

            if (octalNumber.Length != 0)
            {
                Int64.TryParse(octalNumber, out long retorno);
                return retorno;
            }
                return 0;
        }
    }
}
