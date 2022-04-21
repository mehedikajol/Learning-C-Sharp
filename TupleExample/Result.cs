using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleExample
{
    public class Result
    {
        public string Subject { get; set; }
        public double Grade { get; set; }

        public Result(string subject, double grade)
        {
            Subject = subject;
            Grade = grade;
        }
    }
}
