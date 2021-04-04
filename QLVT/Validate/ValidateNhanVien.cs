using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT.Validate
{
    class ValidateNhanVien
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

        private bool isRightFloat(TextBox txt, float value)
        {
            if (float.Parse(txt.Text.ToString().Replace(",", "")) < value)
            {
                return false;
            }
            return true;
        }

        private bool isRightInt(TextBox txt, int value)
        {
            if (int.Parse(txt.Text.ToString()) < value)
            {
                return false;
            }
            return true;
        }


        public bool validate(TextBox txtMANV, TextBox txtHO,TextBox txtTEN,TextBox txtDIACHI,TextBox txtLUONG)
        {
            if (isEmpty(txtMANV))
            {
                MessageBox.Show("Mã nhân viên không được để trống!", "THÔNG BÁO GHI", MessageBoxButtons.OK);
                txtMANV.Focus();
                return false;
            }
            if (!isNumber(txtMANV))
            {
                MessageBox.Show("Mã nhân viên phải là số!", "THÔNG BÁO GHI", MessageBoxButtons.OK);
                txtMANV.Focus();
                return false;
            }
            if (isEmpty(txtHO))
            {
                MessageBox.Show("Họ nhân viên không được để trống!", "THÔNG BÁO GHI", MessageBoxButtons.OK);
                txtHO.Focus();
                return false;
            }
            if (isNumber(txtHO))
            {
                MessageBox.Show("Họ nhân viên phải là chữ!", "THÔNG BÁO GHI", MessageBoxButtons.OK);
                txtHO.Focus();
                return false;
            }
            if (isEmpty(txtTEN))
            {
                MessageBox.Show("Tên nhân viên không được để trống!", "THÔNG BÁO GHI", MessageBoxButtons.OK);
                txtTEN.Focus();
                return false;
            }
            if (isNumber(txtTEN))
            {
                MessageBox.Show("Tên nhân viên phải là chữ!", "THÔNG BÁO GHI", MessageBoxButtons.OK);
                txtTEN.Focus();
                return false;
            }
            if (isEmpty(txtDIACHI))
            {
                MessageBox.Show("Địa chỉ không được để trống!", "THÔNG BÁO GHI", MessageBoxButtons.OK);
                txtDIACHI.Focus();
                return false;
            }
            if (isEmpty(txtLUONG))
            {
                MessageBox.Show("Lương không được để trống!", "THÔNG BÁO GHI", MessageBoxButtons.OK);
                txtLUONG.Focus();
                return false;
            }
            if (!isNumber(txtLUONG))
            {
                MessageBox.Show("Lương phải là số!", "THÔNG BÁO GHI", MessageBoxButtons.OK);
                txtLUONG.Focus();
                return false;
            }
            if (!isRightFloat(txtLUONG, 4000000))
            {
                MessageBox.Show("Lương tối thiểu phải là 4.000.000!", "THÔNG BÁO GHI", MessageBoxButtons.OK);
                txtLUONG.Focus();
                return false;
            }

            return true;
        }
    }
}
