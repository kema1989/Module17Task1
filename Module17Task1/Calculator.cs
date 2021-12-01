using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17Task1
{
    public static class Calculator
    {
        public static void CalculateInterest(IAccountCalculator account)
        {
            account.Calculate();
        }
    }
}
