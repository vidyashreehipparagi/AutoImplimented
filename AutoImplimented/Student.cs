using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoImplimented
{
    public class Student
    {
        private int rn { get; set; }
        private string name { get; set; }
        private double percentage { get; set; }

        public string PrintStudent()
        {
            return $"RollNo={rn},Name={name},Percentage={percentage}";
    }
}
