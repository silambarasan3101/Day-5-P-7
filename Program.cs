using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_P_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("Apple");
            list.Add("Banana");
            list.Add("Cherry");
            list.Add("Date");
            list.Add("ElderBerry");
            Console.WriteLine("The total number of elements " + list.Count);
            Console.WriteLine("Does the element \"Date\" contains in the list?\n True \t False");
            Console.WriteLine("\t" + list.Contains("Date"));
            Console.WriteLine("Enter the index number");
            int ind = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value");
            string element = Console.ReadLine();
            list.Insert(ind, element);
            Console.WriteLine("Enter the element to remove");
            string removable = Console.ReadLine();
            list.Remove(removable);
            foreach (string item in list)
                Console.WriteLine(item);
            Console.ReadKey();
        }
    }
}
