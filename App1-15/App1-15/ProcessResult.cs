using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1_15
{
    public class ProcessResult
    {
        public readonly double Max;
        public readonly int Count;

        public ProcessResult(double max, int count)
        {
            Count = count;
            Max = max;
        }       
    }
}
