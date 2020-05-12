using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startree
{
    class Program
    {
        static void Main(string[] args)
        {
            //라인 총 8줄에 마지막 별 개수 15
            for(int i = 0; i < 8; i++)
            {
                for(int j = 8 - i; j > 1; j--)
                {
                    Console.Write(" ");//라인 신경 쓴거임
                }
                for(int j = 0; j <= (2 * i); j++)//별찍는거임
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
