using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVT.Class
{
    class Kho
    {
        private String maKho;
        private String tenKho;
        private String diaChi;
        private String maCN;
        private int TTX;

        public Kho()
        {

        }
        public Kho(string maKho, string tenKho, string diaChi, string maCN, int tTX)
        {
            this.MaKho = maKho;
            this.TenKho = tenKho;
            this.DiaChi = diaChi;
            this.MaCN = maCN;
            this.TTX1 = tTX;
        }

        public string MaKho { get => maKho; set => maKho = value; }
        public string TenKho { get => tenKho; set => tenKho = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string MaCN { get => maCN; set => maCN = value; }
        public int TTX1 { get => TTX; set => TTX = value; }
    }
}
