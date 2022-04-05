using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using TubaCalisma2;

namespace ConsoleApp1
{
    class Program
    {
        private static void name()
        {
            Console.WriteLine("Tuba");
            Console.WriteLine("Başar");
            Console.WriteLine("Özge");
        }

        public string List()
        {

            List<string> customer = new List<string>();
            customer.Add("Manisa");
            customer.Add("Çankırı");
            customer.Add("Artvin");
            customer.Add("Van");
            Console.WriteLine();
            return customer.ToString();
          
        }


        private static void AgeWrite(int age)
        {
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(age);
            }
        }
        static void Main(string[] args)
        {

            name();
            name();
            Console.Read();

            A2 a2 = new A2();
            a2.AgeWrite();

            List<string> list = new List<string>();
            list.ToList();

           
        }
    }
}
