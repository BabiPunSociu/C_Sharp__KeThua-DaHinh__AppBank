using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBank
{
    internal class CheckAccount : SavingAccount
    {
        protected double FeeTransfer;  // Phí giao dịch

        public CheckAccount(double Balance, double rate, double feeTransfer) : base(Balance, rate)
        {
            FeeTransfer = feeTransfer;
        }

        public override void Deposit(double money)
        {
            if (money <= 0)
                Console.WriteLine("Số tiền cần gửi phải lớn hơn 0 vnd");
            else
            {
                Balance -= money;
                Balance -= FeeTransfer;
                SavingMoney = money;
                Console.WriteLine("Đã gửi thành công " + money + " vnd");
            }
        }

        public override void WithDraw(double money)
        {
            if (money <= 0)
                Console.WriteLine("Số tiền cần rút phải lớn hơn 0 vnd");
            else
            {
                if (Balance - money < FeeTransfer)
                    Console.WriteLine("Số dư tài khoản không đủ ...");
                else
                {
                    Balance -= money;
                    Balance -= FeeTransfer;
                    Console.WriteLine("Bạn đã rút thành công " + money + " vnd");
                }
            }
        }

        public new double GetInterest()
        {
            Balance -= FeeTransfer;
            double result = rate * SavingMoney;
            Balance += result;
            return result;
        }
    }    
}
