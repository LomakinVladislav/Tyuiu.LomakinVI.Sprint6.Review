using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tyuiu.LomakinVI.Sprint6.TaskReview.V19.Lib
{
    public class DataService
    {
        public int MatrixCalc(int[,] matrix, int r, int k, int l)
        {
            int sum = 0;
            while (k <= l)
            {
                if (k % 2 == 0)
                {
                    sum += matrix[r, k];
                }
                k++;
            }
            return sum;
        }

    }
}
