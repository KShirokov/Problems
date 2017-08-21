using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1_15
{
    public static class LengthsProcessor
    {
        public static ProcessResult Process(double etalon, double[] lengths)
        {
            var max = 0.0;
            var count = 0;

            for (var i = 0; i < lengths.Length; i++)
            {
                if (lengths[i] < etalon)
                {
                    count++;
                    max = Math.Max(max, etalon - lengths[i]);
                }
            }

            return new ProcessResult(max, count);
        }
    }
}
