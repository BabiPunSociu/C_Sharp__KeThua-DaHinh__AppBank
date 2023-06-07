using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBank
{
    abstract class Account
    {
        protected double Balance;  // Số tiền trong tài khoản

        public Account(double inialize = 0) // số tiền ban đầu
        {
            Balance = inialize;
        }

        public abstract void Deposit(double money); // Số tiền cần gửi


        public abstract void WithDraw(double money); // Số tiền cần rút
        

        public double GetBalance()     // Kiểm tra số dư tài khoản
        {
            return Balance;
        }
    }
}
