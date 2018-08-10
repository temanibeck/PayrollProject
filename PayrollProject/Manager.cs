using System;
namespace PayrollProject
{
    public class Manager : Staff
    {
        private const float managerHourlyRate = 50;
        public int Allowance { get; private set; }


        public Manager(string name) : base(name, managerHourlyRate){}

        public override void CalculatePay()
        {
            base.CalculatePay();
            Allowance = 0;

            if (HoursWorked > 40)
            {
                Allowance = 1000;
                TotalPay = BasicPay + Allowance;
            }
        }

        public override string ToString()
        {
            return "\nName of Staff = " + NameOfStaff
                + "\nManager Hourly Rate = " + managerHourlyRate +
                "\nHours Worked = " + HoursWorked
                + "\nBasic Pay = " + BasicPay +
                "\nAllowance = " + Allowance +
                "\n\nTotal Pay = " + TotalPay;
        }
    }
}
