using System;
namespace PayrollProject
{
    public class Admin : Staff
    {
        private const float overtimeRate = 15.5f;
        private const float adminHourlyRate = 30f;

        public float Overtime { get; private set; }

        public Admin(string name) : base(name, adminHourlyRate){}

        public override void CalculatePay()
        {
            base.CalculatePay();
            float Allowance = 1000;

            if (HoursWorked > 40)
            {
                Overtime = overtimeRate * (HoursWorked - 40);
            }
        }

        public override string ToString()
        {
            return "\nNameOfStaff = " + NameOfStaff
                + "\nadminHourlyRate = " + adminHourlyRate +
                "\nHoursWorked = " + HoursWorked
                + "\nBasicPay = " + BasicPay +
                "\nOvertime = " + Overtime +
                "\n\nTotalPay = " + TotalPay;
        }
    }
}
