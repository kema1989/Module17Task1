using System;

namespace Module17Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account() { Type = "Обычный", Balance = 37500};

            Calculator.CalculateInterest(new NormalAccountCalculator(account1));

            Account account2 = new Account() { Type = "Зарплатный", Balance = 20000 };

            Calculator.CalculateInterest(new SalaryAccountCalculator(account2));

            Console.WriteLine($"1. Тип счета: {account1.Type}, баланс счета: {account1.Balance}, процентная ставка: {account1.Interest}");
            Console.WriteLine($"2. Тип счета: {account2.Type}, баланс счета: {account2.Balance}, процентная ставка: {account2.Interest}");
        }
    }
}
