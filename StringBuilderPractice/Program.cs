using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("begin1");
            Console.WriteLine("enter numbers separated by hypen");
            string entry = Console.ReadLine();
            List<int> numbers = new List<int>();
            var arr = entry.Split('-');


            //check if numbers are consecutive

            for (var i = 0; i < arr.Length; i++)
            {
                var b = Convert.ToByte(arr[i]);
                //Console.WriteLine(b.GetType());
                numbers.Add(b);
            }



            foreach (var num in numbers)
            {             
                Console.WriteLine(num.GetType());               
            }
            Console.WriteLine("end1");



        }
    }
}
