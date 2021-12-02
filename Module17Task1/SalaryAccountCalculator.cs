using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17Task1
{
    class SalaryAccountCalculator : IAccountCalculator
    {
        public Account account;
        public SalaryAccountCalculator(Account account)
        {
            this.account = account;
        }
        public void Calculate()
        {
            account.Interest = account.Balance * 0.5;
        }
    }
}
