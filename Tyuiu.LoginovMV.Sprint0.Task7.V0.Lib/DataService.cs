using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tyuiu.LoginovMV.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] a, int[] b)
        {
            int[] resultArrays = new int[5];
            for (var i = 0;i<resultArrays.Length;i++)
            {
                resultArrays[i] = a[i] + b[i];
            }
            return resultArrays;
        }
    }
}
