using System;
namespace PayrollProject
{
    public class Admin : Staff
    {
        //Inheritance
        private const float overtimeRate = 15.5f;
        private const float adminHourlyRate = 30f;

        public float Overtime { get; private set; }

        public Admin(string name) : base(name, adminHourlyRate){}

        public override void CalculatePay()
        {
            base.CalculatePay();

            if (HoursWorked > 40)
            {
                Overtime = overtimeRate * (HoursWorked - 40);
            }
        }

        public override string ToString()
        {
            return "\nName of Staff = " + NameOfStaff
                + "\nAdmin Hourly Rate = " + adminHourlyRate +
                "\nHours Worked = " + HoursWorked
                + "\nBasic Pay = " + BasicPay +
                "\nOvertime = " + Overtime +
                "\n\nTotal Pay = " + TotalPay;
        }
    }
}
