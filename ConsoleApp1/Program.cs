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
            CustomerManagers customerManagers = new CustomerManagers();
            customerManagers.Logger = new SQLLogger();//Yeni loglama ihtiyacı duyduğunda sadece new kısmını değiştirirsin..
            customerManagers.Add();

            DataBase data = new SqlServer();
            data.Delete();
            data.Update();

            DataBase data2 = new Oracle();
            data2.Delete();
            data2.Update();
            
            //Base-override örneği 
            Schooll scholl = new Schooll();
            scholl.AddS();
            Students student = new Students();
            student.AddS();

            //Inheritiance array ile Örneği
            //Schooll[] scholl = new Schooll[2]
            //{
            //    new Schooll
            //    {
            //        Name="Kurtuluş Ortaokulu"
            //    },
            //    new Students
            //    {
            //        Name ="Başar"
            //    }
            //};
            //foreach (var schooll in scholl)
            //{
            //    Console.WriteLine(schooll.Name);
            //}
            //Console.ReadLine();
            // PersonManager classı kullanarak ekleme
            PersonManager manager = new PersonManager();
            manager.Add(new Student { Adress = "İstanbul" });


            Customer customer = new Customer();
            customer.Adress = "İstanbul";
            customer.Email = "yesiltastubanu@gmail.com";
            customer.CustomerCode = 4;
            Console.WriteLine("Müşteri Adresi: " + customer.Adress);
            Console.WriteLine("Müşteri EMail: " + customer.Email);
            Console.Write("Müşteri Kodu: " + customer.CustomerCode);
            Console.WriteLine();
            customer.Add();
            customer.Update();


            //Interface üzerinden nesne oluşturma Örneği
            IPerson customer2 = new Customer();
            customer2.Adress = "İstanbul";
            customer2.Email = "yesiltastubanu@gmail.com";
            //customer2.CustomerCode = 4; (Interface de tanımladığım özellik değil)
            Console.WriteLine("Müşteri Adresi: " + customer2.Adress);
            Console.WriteLine("Müşteri EMail: " + customer2.Email);
            // Console.Write("Müşteri Kodu: " + customer2.CustomerCode); (Interface de tanımladığım özellik değil)
            Console.WriteLine();
            customer2.Add();
            customer2.Update();


            //CLASS İÇİN ÖRNEK
            CustomerManager customer3 = new CustomerManager();
            customer3.FirstName = "Tuba";
            customer3.LastName = "Yeşiltaş";
            customer3.ID = 3;

            Console.WriteLine("CustomerId: " + customer3.ID);
            Console.WriteLine("Customer FirstName. " + customer3.FirstName);
            Console.WriteLine("Customer LastName: " + customer3.LastName);
            CustomerManager.Add();


            ProductManager productManager = new ProductManager();
            productManager.Name = "Bilgisayar";
            productManager.ID = 5;
            productManager.ProductCode = 8432;
            Console.WriteLine("Product Id:" + productManager.ID);
            Console.WriteLine("Product Name: " + productManager.Name);
            Console.WriteLine("Product Code: " + productManager.ProductCode);

            Console.ReadLine();//Uygulamayı durdurur.
        }

        abstract class DataBase
        {
            public void Delete()
            {
                Console.WriteLine("Silindi.");
            }
            public abstract void Update();
        }
        class SqlServer : DataBase
        {
            public override void Update()
            {
                Console.WriteLine("SQL SERVER GÜNCELLENDİ.");
            }
        }
        class Oracle : DataBase
        {
            public override void Update()
            {
                Console.WriteLine("ORACLE GÜNCELLENDİ.");
            }
        }
    }
}
