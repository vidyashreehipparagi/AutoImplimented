using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoImplimented
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.rn = 101;
            student.name = "Vidyashree";
            student.percentage = 78;

            Console.WriteLine(student.rn);
            
        }

    }
}
