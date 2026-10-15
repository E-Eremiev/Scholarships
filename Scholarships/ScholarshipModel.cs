using System;

namespace Scholarships
{
    
    public class ScholarshipModel
    {
        private double income;
        public double Income
        {
            get { return income; }
            set
            {
                if (value > 650.00)
                {
                    throw new ArgumentOutOfRangeException("Max value = 650.00!");
                }
                income = value;
            }
        }

        private double grade;
        
        public double Grade
        {
            get { return grade; }
            set
            {
                if (value > 6.0)
                {
                    throw new ArgumentOutOfRangeException("Max value = 6.00!");
                }
                grade = value;
            }
        }
        private double minSalary;
        public double MinSalary
        {
            get { return minSalary; }
            set
            {
                if (value > 650.00)
                {
                    throw new ArgumentOutOfRangeException("Max value =  650.00!");
                }
                minSalary = value;
            }
        }
    }
}
