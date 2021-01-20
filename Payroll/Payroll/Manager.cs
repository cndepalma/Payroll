using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    class Manager : Staff
    {
        private const float managerHourlyRate = 50;

        //Properties
        public int Allowance { get; private set; }
        //constructor 
        public Manager(string name) : base(name, managerHourlyRate){}

        public override void CalculatePay()
        {
            base.CalculatePay();
            Allowance = 1000;

            if (HoursWorked > 160)
                TotalPay = BasePay + Allowance;
        }

        public override string ToString()
        {
            return "\nName of Staff: " + NameOfStaff + "\nManager Hourly Rate: " + managerHourlyRate + "\nHours Worked: " +
                HoursWorked + "\nBase Pay: " + BasePay + " \nAllowance: " + Allowance + "\nTotal Pay: " + TotalPay;
        }
    }
}
