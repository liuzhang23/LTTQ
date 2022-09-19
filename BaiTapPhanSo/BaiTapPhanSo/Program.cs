using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapPhanSo
{
    class Program

    {

        static void Main(string[] args)
        {
            int chon, a, d, c;
            Phanso ps1 = new Phanso();
            Phanso ps2 = new Phanso();
            Phanso ps3 = new Phanso();
            do
            {
                Console.WriteLine();
                Console.WriteLine("**************************MENU************************");
                Console.WriteLine("   1. Tong");
                Console.WriteLine("   2. Hieu");
                Console.WriteLine("   3. Tich");
                Console.WriteLine("   4. Thuong");
                Console.WriteLine("   5. Kiem tra 1 phan so toi gian");
                Console.WriteLine("   6. Rut gon phan so");
                Console.WriteLine("   7. Thoat");
                chon = Int32.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        {
                            Console.WriteLine("Nhap phan so 1");
                            ps1.NhapPhanso();
                            Console.WriteLine("Nhap phan so 2");
                            ps2.NhapPhanso();
                            ps3 = ps1.CongPS(ps2);
                            Console.Write("Tong cua hai phan so: ");
                            ps3.XuatPhanSo();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Nhap phan so 1");
                            ps1.NhapPhanso();
                            Console.WriteLine("Nhap phan so 2");
                            ps2.NhapPhanso();
                            ps3 = ps1.TruPS(ps2);
                            Console.Write("Hieu cua hai phan so :");
                            ps3.XuatPhanSo();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Nhap phan so 1");
                            ps1.NhapPhanso();
                            Console.WriteLine("Nhap phan so 2");
                            ps2.NhapPhanso();
                            ps3 = ps1.NhanPS(ps2);
                            Console.Write("Tich cua hai phan so :");
                            ps3.XuatPhanSo();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Nhap phan so 1");
                            ps1.NhapPhanso();
                            Console.WriteLine("Nhap phan so 2");
                            ps2.NhapPhanso();
                            ps3 = ps1.ChiaPS(ps2);
                            Console.Write("Hieu cua hai phan so :");
                            ps3.XuatPhanSo();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Nhap phan so can kiem tra");
                            ps1.NhapPhanso();
                            if (ps1.UCLN() > 1)
                            {
                                Console.WriteLine("Phan so chua toi gian");
                            } else
                            {
                                Console.WriteLine("Phan so da toi gian");
                            }
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Nhap phan so can rut gon");
                            ps1.NhapPhanso();
                            ps3 = ps1.RutGon();
                            Console.Write("Phan so sau khi rut gon: ");
                            ps3.XuatPhanSo();
                            break;
                        }
                    case 7: goto ketthuc;
                }
            }
            while (chon != 7);

            Console.ReadLine();

        ketthuc:;

        }

    }

}

