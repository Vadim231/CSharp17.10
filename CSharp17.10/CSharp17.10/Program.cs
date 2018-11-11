using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp17._10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int max = int.MinValue;
            int secondMax = int.MinValue;
            int sum = 0;
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    secondMax = max;//старый максимальный элемент присваеваем значению "второго максимального"
                    max = number;//новый максимальный элемент
                }
                else if (number > secondMax)//в случае, если число меньше max
                    secondMax = number;
            }
            foreach(int number in numbers)
            {
                //четные элементы:
                if (number % 2 == 0)
                    sum += number;
            }
            
            Console.WriteLine("Вторым максимальным значением в коллекции является: " + secondMax + " под индексом ["+ numbers.IndexOf(secondMax)+"]");
            Console.WriteLine("Сумма четных элементов: " + sum);
            Console.ReadLine();
        }
    }
}
