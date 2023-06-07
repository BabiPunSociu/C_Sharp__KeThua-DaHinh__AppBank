using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBank
{
    class Program
    {
        public static void Main()
        {
            CheckAccount taikhoan = new CheckAccount(1000000, 0.01, 1000);

            Console.WriteLine("So tien dang co trong tai khoan la: "+ taikhoan.GetBalance()+" vnd");

            Console.Write("Nhập số tiền bạn muốn gửi: ");
            double guiTien = Convert.ToDouble(Console.ReadLine());
            taikhoan.Deposit(guiTien);

            Console.Write("\nSo tien lai: {0,n}", taikhoan.GetInterest());
            Console.Write("\nTien trong tai khoan sau khi nhan lai la: "+ taikhoan.GetBalance() +"vnd");

            Console.Write("\nNhap so tien can rut: ");
            taikhoan.WithDraw(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("So tien dang co trong tai khoan la: "+ taikhoan.GetBalance() + " vnd");
        }
    }
}