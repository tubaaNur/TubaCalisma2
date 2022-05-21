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

            A a3 = new A();
            //a3.askos("Tuba");
            //var response =  a3.askos("İrem");
            //Console.WriteLine("1. Sayı değeri giriniz: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2. Sayı değeri giriniz: ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Sayı değerleri: "+(a)+" "+(b));
            //a3.toplama(a,b);

            //Console.WriteLine("Dizinin 1. elemanını giriniz: ");
            //int s1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Dizinin 2. elemanını giriniz: ");
            //int s2 = Convert.ToInt32(Console.ReadLine()); 
            //Console.WriteLine("Dizinin 3. elemanını giriniz: ");
            //int s3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Dizi elemanları: " + (s1) + "" + (s2) + "" + (s3));
            //a3.list(s1,s2,s3);

            //    Console.WriteLine("Metni giriniz: ");
            //    string a = Convert.ToString(Console.ReadLine());
            //    a3.buyukdondur(a);

            //    Console.WriteLine("Metni giriniz: ");
            //    string b = Convert.ToString(Console.ReadLine());
            //    a3.kucukdondur(b);
            //}

            // Polymorhism örneği
            /* a3.List();
            B a3= new B(); */
            A a4 = new B();
            //a3.List();
            //bool t = true;
            //bool f = false;

            a3.askos("irem");
            a3.askos("Tuba");

            Console.WriteLine("Yaşı giriniz: ");
            Console.ReadLine();
            Console.WriteLine(a3.Name);
            Console.WriteLine(a3.Adress);

            /* a3.Name = "Tuba";
            Console.WriteLine(a3.Name); */


            //Liste çağırma
            Students students = new Students();
            students.List();

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
            //Schooll scholl = new Schooll();
            //scholl.AddS();
            //Students student = new Students();
            //student.AddS();


            //Inheritiance array ile Örneği
            Schooll[] scholl = new Schooll[2]
            {
                new Schooll
                {
                    Name="Kurtuluş Ortaokulu"
                },
                new Students
                {
                    Name ="Başar"
                }
            };
            foreach (var schooll in scholl)
            {
                Console.WriteLine(schooll.Name);
            }
            Console.ReadLine();

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
            /*customer2.CustomerCode = 4;*/ // (Interface de tanımladığım özellik değil)
            Console.WriteLine("Müşteri Adresi: " + customer2.Adress);
            Console.WriteLine("Müşteri EMail: " + customer2.Email+"\n"); 
            // Console.Write("Müşteri Kodu: " + customer2.CustomerCode); (Interface de tanımladığım özellik değil)
            //Console.WriteLine();
            customer2.Add(); 
            customer2.Update();


            //CLASS İÇİN ÖRNEK
            CustomerManager customer3 = new CustomerManager();
            customer3.FirstName = "Tuba";
            customer3.LastName = "Yeşiltaş";
            customer3.ID = 3;

            Console.WriteLine("CustomerId: " + customer3.ID);
            Console.WriteLine($"CustomerId: {customer3.ID}"); 
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
