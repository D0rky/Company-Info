using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4350Review_AdamMartinezJr
{

    class Employee
    {
        private readonly string firstN;
        private readonly string lastN;
        private readonly double wage;
        private double weekHrsWkd;
        private const double regHrsAmt = 40;
        private double regPay;
        private double otPay;

        public Employee(string firstN, string lastN, double wage)
        {
            this.firstN = firstN;
            this.lastN = lastN;
            this.wage = wage;
        }

        public void SetWeekHrsWkd(double hours)
        {
            weekHrsWkd = hours;
        }

        private void CalculatePay()
        {
            // Calculate regular pay (up to 40 hours)
            if (weekHrsWkd <= regHrsAmt)
            {
                regPay = weekHrsWkd * wage;
                otPay = 0;
            }
            else
            {
                // Calculate regular pay for the first 40 hours
                regPay = regHrsAmt * wage;

                // Calculate overtime pay for hours worked beyond 40
                otPay = (weekHrsWkd - regHrsAmt) * (wage * 1.5);
            }
        }

        public double GetTotalPay()
        {
            CalculatePay(); // Calculate pay before retrieving total pay
            return regPay + otPay;
        }

        public string GetFirstName()
        {
            return firstN;
        }

        public string GetLastName()
        {
            return lastN;
        }
    }

}
