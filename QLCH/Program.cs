using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCH
{
    class Program
    {
        static void Main(string[] args)
        {            
            List<HangHoa> DSHangHoa = new List<HangHoa>();

            Console.WriteLine("Quan Ly Cua Hang");
            Console.WriteLine("");

            bool Thoat = false;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("1. Them mat hang");
                Console.WriteLine("2. Xoa mat hang");
                Console.WriteLine("3. Sua mat hang");
                Console.WriteLine("4. Tim kiem mat hang");
                Console.WriteLine("5. Thoat");
                Console.WriteLine("");

                int LuaChon = int.Parse(Console.ReadLine());
                if (LuaChon == 1)
                {
                    HangHoa hanghoa = NhapMatHang();
                    DSHangHoa.Add(hanghoa);
                }else if(LuaChon == 2)
                {
                    Console.WriteLine("Nhap ma so hang can xoa: ");
                    int maso = int.Parse(Console.ReadLine());
                    XoaMatHang(DSHangHoa, maso);
                }
                else if(LuaChon == 3)
                {
                    Console.WriteLine("Nhap ma so hang can sua: ");
                    int maso = int.Parse(Console.ReadLine());
                    DSHangHoa = SuaThongTinHang(DSHangHoa, maso);
                }
                else if(LuaChon == 4)
                {
                    Console.WriteLine("Nhap ma so hang hoa can tim: ");
                    int maso = int.Parse(Console.ReadLine());
                    TiKiemHangHoa(DSHangHoa, maso);
                }else if(LuaChon == 5)
                {
                    Thoat = true;
                }
            } while (!Thoat);

        }

        public static HangHoa NhapMatHang()
        {
            HangHoa A;

            Console.WriteLine("Nhap ma so: ");
            A.MaSo = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap ten hang: ");
            A.TenHang = Console.ReadLine();

            Console.WriteLine("Nhap han su dung: ");
            A.HanSuDung = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Nhap ten cong ty san xuat: ");
            A.CtySX = Console.ReadLine();

            Console.WriteLine("Nhap nam san xuat: ");
            A.NamSanXuat = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap loai hang: ");
            A.Loai = Console.ReadLine();

            return A;
        }

        private static List<HangHoa> SuaThongTinHang(List<HangHoa> dSHangHoa, int maso)
        {
            for (int i =0; i < dSHangHoa.Count; i++)
            {
                if(maso == dSHangHoa[i].MaSo)
                {
                    Console.WriteLine("Nhap lai thong tin: ");
                    dSHangHoa[i] = NhapMatHang();
                }
            }
            return dSHangHoa;
        }

        private static void XoaMatHang(List<HangHoa> DSHangHoa, int maso)
        {
            for(int i = 0; i < DSHangHoa.Count; i++)
            {
                if(maso == DSHangHoa[i].MaSo)
                {
                    DSHangHoa.RemoveAt(i);
                }
            }
        }

        private static void TiKiemHangHoa(List<HangHoa> DSHangHoa, int maso)
        {
            for(int i = 0; i < DSHangHoa.Count; i++)
            {
                if(maso == DSHangHoa[i].MaSo)
                {
                    Console.WriteLine($"Thong tin hang hoa: ");
                    Console.WriteLine("");
                    Console.WriteLine($"Maso: {DSHangHoa[i].MaSo}");
                    Console.WriteLine($"Ten hang: {DSHangHoa[i].TenHang}");
                    Console.WriteLine($"Hang su dung: {DSHangHoa[i].HanSuDung}");
                    Console.WriteLine($"Cong ty san xuat: {DSHangHoa[i].CtySX}");
                    Console.WriteLine($"Nam san xuat: {DSHangHoa[i].NamSanXuat}");
                    Console.WriteLine($"Loai hang: {DSHangHoa[i].Loai}");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Khong tim thay mat hang. Vui long nhap lai");
                }
            }
        }

        public struct HangHoa
        {
            public int MaSo;
            public string TenHang;
            public DateTime HanSuDung;
            public string CtySX;
            public int NamSanXuat;
            public string Loai;
        }

        
    }
}
