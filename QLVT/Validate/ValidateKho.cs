using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT.Validate
{
    class ValidateKho
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

        public bool validate(TextBox txtMaKho,TextBox txtTenKho,TextBox txtDiaChi)
        {
            if (isEmpty(txtMaKho))
            {
                MessageBox.Show("Mã kho không được để trống", "THÔNG BÁO", MessageBoxButtons.OK);
                txtMaKho.Focus();
                return false;
            }
            if (txtMaKho.Text.ToString().Trim().Length > 4)
            {
                MessageBox.Show("Độ dài tối đa của mã kho là 4 kí tự", "THÔNG BÁO", MessageBoxButtons.OK);
                txtMaKho.Focus();
                return false;
            }
            if (isEmpty(txtTenKho))
            {
                MessageBox.Show("Tên kho không được để trống", "THÔNG BÁO", MessageBoxButtons.OK);
                txtTenKho.Focus();
                return false;
            }
            if (isNumber(txtTenKho))
            {
                MessageBox.Show("Tên kho phải là chữ", "THÔNG BÁO", MessageBoxButtons.OK);
                txtTenKho.Focus();
                return false;
            }
            if (isEmpty(txtDiaChi))
            {
                MessageBox.Show("Địa chỉ không được để trống", "THÔNG BÁO", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }

            return true;
        }
    }
}
