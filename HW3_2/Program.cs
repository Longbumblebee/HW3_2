using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_2
{
    class Program
    {
        private static string[,] _phoneBook = new string[,] { { "И.И. Иванов", "111222333" }, { "П.П.Петров", "333222111" }, { "С.С. Сидоров", "333111222" }, { "З.З. Зайцев", "444333111" }, { "В.В. Волков", "555444333" } };

        static void Main(string[] args)
        {
            int arrayRows = _phoneBook.GetUpperBound(0) + 1; 
            int arrayColumns = _phoneBook.Length / arrayRows; 

            for (int i = 0; i < arrayRows; i++) 
            {
                for (int j = 0; j < arrayColumns; j++) 
                {
                    Console.Write(_phoneBook[i, j] + " "); 
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}