using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVT
{
    static class SP
    {
        //public static float runSPGiaVT()
        //{
        //    String strLenh = "DECLARE @return_value int \n" +
        //                       "EXEC	@return_value = [dbo].[sp_KiemtraMaDatHang_TonTai] \n" +
        //                       "@MasoDDH =N'" +  + "'\n" +
        //                       "SELECT  'Return Value' = @return_value \n";

        //    Program.myReader = Program.ExecSqlDataReader(strLenh);
        //    if (Program.myReader == null)
        //    {
        //        return float.NaN;
        //    }

        //    if (Program.myReader.Read())
        //    {
        //        return Program.myReader.GetFloat(0);
            
        //    }
        //    return float.NaN;
        //}

        public static bool isCTDDH(String maDTH,String maVT)
        {
            String strLenh = "DECLARE @return_value int \n" +
                            "EXEC @return_value = [dbo].[sp_KiemtraCTDH_TonTai] \n" +
                            "@MasoDDH = N'" + maDTH + "' , @MaVT = N'" + maVT + "' \n" +
                            "SELECT  'Return Value' = @return_value";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null)
            {
                return false;
            }

            if (Program.myReader.Read())
            {
                if(Program.myReader.GetInt32(0)==1)
                {
                   // Program.myReader.Close();
                    return true;
                }
            }

            Program.myReader.Close();
            return false;
        }

        public static bool updateCTDDH(String maDTH, String maVT,int soLg,float donGia)
        {
            String strLenh = "DECLARE @return_value int \n" +
                            "EXEC @return_value = [dbo].[sp_UpdateChiTietDatHang] \n" +
                            "@MasoDDH = N'"+maDTH+"', "+
                            "@MaVT = N'"+maVT+"', "+
		                    "@SoLg = "+soLg+", "+
		                    "@DonGia = "+donGia+"\n" +
                            "SELECT  'Return Value' = @return_value";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null)
            {
                return false;
            }

            if (Program.myReader.Read())
            {
                if (Program.myReader.GetInt32(0) == 1)
                {
                    Program.myReader.Close();
                    return true;
                }
            }

            Program.myReader.Close();
            return false;
        }

        public static bool isDDH(String maDDH)
        {
            String strLenh = "DECLARE @return_value int \n" +
                                "EXEC	@return_value = [dbo].[sp_KiemtraMaDatHang_TonTai] \n" +
                                "@MasoDDH =N'" + maDDH + "'\n" +
                                "SELECT  'Return Value' = @return_value \n";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null)
            {
                //Program.myReader.Close();
                return false;
            }
            if (Program.myReader.Read())
            {
                if (Program.myReader.GetInt32(0) == 1)
                {
                    Program.myReader.Close();
                    return true;
                }

            }

            Program.myReader.Close();
            return false;
        }

        public static bool register(String login,String user,String pass,String role)
        {
            String strLenh = "DECLARE @return_value int \n" +
                                "EXEC	@return_value = [dbo].[[Sp_TaoTaiKhoan]] \n" +
                                "@LGNAME = N'"+login+"', "+
                                "@PASS = N'" + pass + "', " +
                                "@USERNAME = N'" + user + "', " +
                                "@ROLE = N'" + role + "' \n" +
                                "SELECT  'Return Value' = @return_value \n";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null)
            {
                return false;
            }
            if (Program.myReader.Read())
            {
                if (Program.myReader.GetInt32(0) == 1)
                {
                    Program.myReader.Close();
                    return true;
                }
            }

            Program.myReader.Close();
            return false;
        }

        public static bool isAccount(String userName)
        {
            String strLenh = "DECLARE @return_value int \n" +
                                "EXEC	@return_value = [dbo].[SP_KiemtraTaiKhoan_TonTai] \n" +
                                "@UserName =N'" + userName + "'\n" +
                                "SELECT  'Return Value' = @return_value \n";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null)
            {
                return false;
            }
            if (Program.myReader.Read())
            {
                if (Program.myReader.GetInt32(0) == 1)
                {
                    Program.myReader.Close();
                    return true;
                }

            }

            Program.myReader.Close();
            return false;
        }

        public static bool isDelDatHang(String maDDH)
        {
            String strLenh = "DECLARE @return_value int \n" +
                                "EXEC	@return_value = [dbo].[SP_KiemtraXoa_DATHANG] \n" +
                                "@MADDH =N'" + maDDH + "'\n" +
                                "SELECT  'Return Value' = @return_value \n";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null)
            {
                return false;
            }
            if (Program.myReader.Read())
            {
                if (Program.myReader.GetInt32(0) == 1)
                {
                    Program.myReader.Close();
                    return true;
                }

            }

            Program.myReader.Close();
            return false;
        }

        public static String sinhMaKho()
        {
            String maKho = "";
            string strLenh = "EXEC SP_SINHMA_KHO ";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader.Read())
            {
                maKho = Program.myReader.GetString(0);
            }
            String num = "";
            maKho = maKho.Substring(2, 2);
            Console.WriteLine(maKho);
            int n = int.Parse(maKho) + 1;
            Console.WriteLine(n);
            if (n < 10)
            {
                num = "0" + n;
            }
            if(Program.mChinhanh == 0)
            {
                maKho = "N" + 1 + num;
            }
            else
            {
                maKho = "N" + 2 + num;
            }
            Program.myReader.Close();
            return maKho;
        }
    }

}
