using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT.Validate
{
    class ValidateCTPN
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
            if (int.Parse(txt.Text.ToString().Trim()) <= value)
            {
                return false;
            }
            return true;
        }

        public bool validate(TextBox txtSoLg, TextBox txtDonGia)
        {
            if (isEmpty(txtSoLg))
            {
                MessageBox.Show("Số lượng không được để trống", "THÔNG BÁO GHI", MessageBoxButtons.OK);
                txtSoLg.Focus();
                return false;
            }
            if (!isNumber(txtSoLg))
            {
                MessageBox.Show("Số lượng là số", "THÔNG BÁO GHI", MessageBoxButtons.OK);
                txtSoLg.Focus();
                return false;
            }
            if (!isRightFloat(txtSoLg, 0))
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "THÔNG BÁO GHI", MessageBoxButtons.OK);
                txtSoLg.Focus();
                return false;
            }
            if (!isNumber(txtDonGia))
            {
                MessageBox.Show("Đơn giá là số", "THÔNG BÁO GHI", MessageBoxButtons.OK);
                txtDonGia.Focus();
                return false;
            }
            if (isEmpty(txtDonGia))
            {
                MessageBox.Show("Đơn giá không được để trống", "THÔNG BÁO GHI", MessageBoxButtons.OK);
                txtDonGia.Focus();
                return false;
            }
            if (!isRightInt(txtDonGia, 0))
            {
                MessageBox.Show("Giá tối thiểu là 0", "THÔNG BÁO GHI", MessageBoxButtons.OK);
                txtDonGia.Focus();
                return false;
            }

            return true;
        }
    }
}
