using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFive
{
    public class Math
    {
        public double Average(params int[] values)
        {
            double sum = 0;
            foreach(var value in values)
            {
                sum += value*1.0;
            }
            return FixedAnswers(sum / values.Length * 1.0);
        }

        double FixedAnswers(double number)
        {
            string answer = number.ToString("0.00");
            return Convert.ToDouble(answer);
        }
    }
}
