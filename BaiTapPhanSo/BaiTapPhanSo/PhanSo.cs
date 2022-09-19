using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapPhanSo
{
    class Phanso
    {
        int tu, mau;
        public Phanso()
        {
            tu = 0;
            mau = 1;
        }
        public Phanso(int x)
        {
            tu = x;
            mau = 1;
        }
        public Phanso(int t, int m)
        {
            tu = t;
            mau = m;
        }
        public void NhapPhanso()
        {
            Console.Write("Tu so = ");
            this.tu = int.Parse(Console.ReadLine());
            Console.Write("mau so = ");
            do
                this.mau = int.Parse(Console.ReadLine());
            while (this.mau == 0);
        }
        public void XuatPhanSo()
        {
            Console.WriteLine("{0}/{1}", tu, mau);
        }
        public Phanso CongPS(Phanso ps1)
        {
            int ts = tu * ps1.mau + mau * ps1.tu;
            int ms = mau * ps1.mau;
            Phanso ketqua = new Phanso(ts, ms);
            return ketqua;
        }
        public Phanso TruPS(Phanso ps1)
        {
            int ts = tu * ps1.mau - mau * ps1.tu;
            int ms = mau * ps1.mau;
            Phanso ketqua = new Phanso(ts, ms);
            return ketqua;
        }

        public Phanso NhanPS(Phanso ps1)
        {
            int ts = tu * ps1.tu;
            int ms = mau * ps1.mau;
            Phanso ketqua = new Phanso(ts, ms);
            return ketqua;
        }
        public Phanso ChiaPS(Phanso ps1)
        {
            int ts = tu * ps1.mau;
            int ms = mau * ps1.tu;
            Phanso ketqua = new Phanso(ts, ms);
            return ketqua;
        }
        public int UCLN()
        {
            while (tu != mau)
                if (tu > mau) tu = tu - mau;
                else mau = mau - tu;
            return tu;
        }

        public Phanso RutGon()
        {
            int ts = tu;
            int ms = mau;
            while (tu != mau)
                if (tu > mau) tu = tu - mau;
                else mau = mau - tu;
            ts = ts / tu; ms = ms / tu;
            Phanso ketqua = new Phanso(ts, ms);
            return ketqua;
        }

    }
}