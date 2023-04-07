using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takrorlash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array of row : ");
            int row = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < row;i++)
            {
                Console.Write($"{i} ");
                for(int j = 0; j < i;j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine(" ");
            }

        }
    }
}
