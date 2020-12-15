using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            bool isWork = true;
            int sum1 = 0;
            string inputUser;
            
            while (isWork)
            {
                Console.Write("Enter Number!");
                inputUser = Console.ReadLine();
                
                bool isNum = int.TryParse(inputUser, out sum1);
                if (isNum)
                {
                    numbers.Add(Convert.ToInt32(inputUser));
                }
                else if (inputUser == "sum" )
                {
                    foreach (var item in numbers)
                    {
                        sum1 += item;
                    }
                    Console.Write("Сумма всех эленментов массива: " + sum1);
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (inputUser == "exit")
                {
                    isWork = false;
                    //HellWorld
                }
               
            }

        }
    }
}
