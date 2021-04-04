using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT.Validate
{
    class ValidateDH
    {
        private bool isNumber(TextBox txt)
        {
            String str = txt.Text.ToString().Trim();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] < 48 || str[i] > 57)
                {
                    return false;
                }
            }
            return true;
        }

        private bool isEmpty(TextBox txt)
        {
            if (txt.Text.ToString().Trim() == "")
            {
                return true;
            }
            return false;
        }

        public bool validate(TextBox txtNhaCC) 
        {
            if (isEmpty(txtNhaCC))
            {
                MessageBox.Show("Nhà cung cấp không được trống!", "THÔNG BÁO GHI", MessageBoxButtons.OK);
                txtNhaCC.Focus();
                return false;
            }
            if (isNumber(txtNhaCC))
            {
                MessageBox.Show("Nhà cung cấp phải là chữ!", "THÔNG BÁO GHI", MessageBoxButtons.OK);
                txtNhaCC.Focus();
                return false;
            }

            return true;
        }
    }
}
