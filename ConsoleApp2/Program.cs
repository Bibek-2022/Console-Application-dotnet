using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Test name = new Test();
            
            string userName = "";
            int userAge = 0;
            int currentYear = 0;
                
            Console.Write("Please enter your name: ");
            userName = Console.ReadLine();
            Console.Write("Please enter your age: ");
            userAge = Convert.ToInt32(Console.ReadLine());
             Console.Write("Please enter the current year: ");
            currentYear = Convert.ToInt32(Console.ReadLine());
            
        Console.WriteLine("Hello World! My name is {0} and I am {1}years old.I was born in { 2}.", userName, userAge, currentYear);
        }

        class Staff
        {
            private string nameOfStaff;
            private const int hourlyRate = 30;
            private int hWorked;
        }
        public void PrintMessage()
        {
            Console.WriteLine("Calculating Pay…");
        }
        private int hWorked;
        public int HoursWorked
        {
            get
            {
                return hWorked;
            }
            set
            {
                hWorked = value;
            }
        }
        public int CalculatePay()
        {
            PrintMessage();
            int staffPay;
            staffPay = hWorked * 20;
            if (hWorked > 0)
                return staffPay;
            else
                return 0;
        }
        public int CalculatePay(int bonus, int allowance)
        {
            PrintMessage();
            if (hWorked > 0)
                return hWorked * 30 + bonus + allowance;
            else
                return 0;
        }
    }
}
