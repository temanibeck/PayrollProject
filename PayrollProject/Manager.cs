using System;
namespace PayrollProject
{
    public class Manager : Staff
    {
        private const float managerHourlyRate = 50;
        public int Allowance { get; private set; }


        public Manager(string name)
        {
            
        }
    }
}
