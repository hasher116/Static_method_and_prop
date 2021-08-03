using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_method_and_prop
{
    class Stavka
    {
        public static int Counter { get; private set; }
        public decimal Sum { get; private set; }
        public decimal Rate { get; private set; }
        private static decimal minSum;

        public static decimal MinSum
        {
            get { return minSum; }
            set { if (value > 0) minSum = value; }
        }

        public Stavka(decimal sum, decimal rate)
        {
            if (sum < MinSum) throw new Exception("Ошибка");
            Sum = sum;
            Rate = rate;
            Counter++;
        }

        public static decimal getSum(decimal sum, decimal rate, int period)
        {
            decimal result = sum;
            for (int i = 1; i <= period; i++)
            {
                result = result + (result * rate / 100);
            }
            return result;
        }
    }
}
