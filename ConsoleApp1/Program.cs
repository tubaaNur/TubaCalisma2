using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TubaCalisma2;

namespace ConsoleApp1
{
    class Program
    {
       static void Main(string[] args)
        {
            CustomerManager customer = new CustomerManager();
            customer.FirstName = "Tuba";
            customer.LastName = "Yeşiltaş";
            customer.ID = 3;

            Console.WriteLine("CustomerId: "+customer.ID); 
            Console.WriteLine("Customer FirstName. "+customer.FirstName); 
            Console.WriteLine("Customer LastName: "+ customer.LastName);
            CustomerManager.Add();
            

            ProductManager productManager= new ProductManager();
            productManager.Name = "Bilgisayar";
            productManager.ID = 5;
            productManager.ProductCode = 8432;
            Console.WriteLine("Product Id:"+ productManager.ID);
            Console.WriteLine("Product Name: "+productManager.Name);
            Console.WriteLine("Product Code: " +productManager.ProductCode);
            //Console.ReadLine();
        }
    }
}
