using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters;

namespace lab11
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите шестизначное число");
            string a = Console.ReadLine();
            if (a.Length != 6)
            {
                Console.WriteLine("число не шестизначное");
                return;
            }
            int first = 0;
            int last = 0;
            for (int i = 0; i < 3; i++)
            {
                first += int.Parse(a[i].ToString());
                last += int.Parse(a[i + 3].ToString());
            }
            if (first == last)
            {
                Console.WriteLine("число счастливое");
            }
            else Console.WriteLine("число несчастливое");
        }

    }
}



