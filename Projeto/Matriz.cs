using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Projeto
{
    class Matriz
    {
        public void ConectString()
        {
            char[] unwanted = new char[] { ';' };
            var allRows = File
                .ReadLines(@"C:\Users\Usuário\Downloads\136-637413282943515207\German_Cities.txt")
                 .Select(line => line.Split(unwanted).ToList())
                 .ToList();


            var matrix = new int[allRows.Count, allRows[0].Count];
            for (int row = 0; row != allRows.Count; row++)
            {                
                for (int col = 0; col != allRows[0].Count; col++)
                {
                    if(col == 0)
                    {
                        Console.Write($"{allRows[row][col]}");
                    }else
                        Console.Write($"  {allRows[row][col]}");

                    matrix[row, col] = Convert.ToInt32(allRows[row][col]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
