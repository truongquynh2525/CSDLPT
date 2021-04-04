using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT.Validate
{
    class ValidateVatTu
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
            if (float.Parse(txt.Text.ToString().Trim().Replace(",", "")) < value)
            {
                return false;
            }
            return true;
        }

        private bool isRightInt(TextBox txt, int value)
        {
            if (int.Parse(txt.Text.ToString().Trim()) < value)
            {
                return false;
            }
            return true;
        }

        public bool validate(TextBox txtMAVT,TextBox txtTENVT,TextBox txtDVT,TextBox txtSLT)
        {
            if (isEmpty(txtMAVT))
            {
                MessageBox.Show("Vật tư không được để trống", "THÔNG BÁO GHI", MessageBoxButtons.OK);
                txtMAVT.Focus();
                return false;
            }
            if (isEmpty(txtTENVT))
            {
                MessageBox.Show("Tên vật tư không được để trống", "THÔNG BÁO GHI", MessageBoxButtons.OK);
                txtTENVT.Focus();
                return false;
            }
            if (isNumber(txtTENVT))
            {
                MessageBox.Show("Tên vật tư phải là chữ", "THÔNG BÁO GHI", MessageBoxButtons.OK);
                txtTENVT.Focus();
                return false;
            }
            if (isEmpty(txtDVT))
            {
                MessageBox.Show("Đơn vị tồn không được để trống", "THÔNG BÁO GHI", MessageBoxButtons.OK);
                txtDVT.Focus();
                return false;
            }
            if (isNumber(txtDVT))
            {
                MessageBox.Show("Đơn vị tồn phải là chữ", "THÔNG BÁO GHI", MessageBoxButtons.OK);
                txtDVT.Focus();
                return false;
            }
            if (isEmpty(txtSLT))
            {
                MessageBox.Show("Số lượng tồn không được để trống", "THÔNG BÁO GHI", MessageBoxButtons.OK);
                txtSLT.Focus();
                return false;
            }
            if (!isNumber(txtSLT))
            {
                MessageBox.Show("Số lượng tồn phải là số", "THÔNG BÁO GHI", MessageBoxButtons.OK);
                txtSLT.Focus();
                return false;
            }

            return true;
        }
    }
}
