using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBank
{
    // Tài khoản tiết kiệm KÉ THỪA Account
    class SavingAccount : Account
    {
        protected double rate; // tỉ lệ lãi suất
        protected double SavingMoney = 0;

        public SavingAccount(double initialize , double rate ) : base(initialize)        {
            this.rate = rate;
        }

        public override void Deposit(double money)
        {
            throw new NotImplementedException();
        }

        public double GetInterest()     // Lấy tiền lãi
        {
            return rate*this.SavingMoney;
        }

        public override void WithDraw(double money)
        {
            throw new NotImplementedException();
        }
    }
}
