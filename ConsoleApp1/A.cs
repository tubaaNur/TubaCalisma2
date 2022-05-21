using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubaCalisma2
{
    class A
    {

        public string Name { get; set; }
        public string Adress { get; set; }
        public int Age { get; set; }

        public virtual string List()
        {
            List<string> list = new List<string>();
            list.Add(Name = "Başar");
            list.Add(Adress = "İstanbul");
            return list.ToString();
        }

        //public List<string> List12(string a )
        //{ 

      
    
            // List12method çağır. parametre olarak string ifade. fonk da iremi gönderirsen true tubayı gönderirsem false dönsün

        

        public bool askos(string a)
        {
            if(a== "İrem")
            {
                return true;
            }
           else if (a == "Tuba")
            {
                return false;
            }
            return false;
        }


        public int Agee()
        {
            int age = 0;
            return age;
        }
    }

    class B : A
    {
        public string Message { get; set; }
        public override string List()
        {
            List<string> list = new List<string>();
            list.Add(Message = "Güncelenen liste: ");
            list.Add(Name = "Tuba");
            list.Add(Adress = "Isparta");
            return list.ToString();
        }


        //iki sayıyı dışardan alan ve toplamlarını döndüren method
        //public bool askos(string a)
        //{
        //    if (a == "İrem")
        //    {
        //        Console.WriteLine("True");
        //        return true;
        //    }

        //    else if (a == "Tuba")
        //    {
        //        return false; 
        //    }
        //    return false;

        //}

        //public int toplama(int a, int b)
        //{
        //    int toplam = a + b;
        //    Console.WriteLine("Sayıların toplamı: " + (toplam));
        //    return toplam;
        //}

        //kullanıcıdan liste alan yazdıran
        //public bool list(int s1, int s2, int s3)
        //{

        //    List<int> list = new List<int>();

        //    if ((s1 % 2 == 0 || s2 % 2 == 0 || s3 % 2 == 0))
        //    {
        //        return true;
        //    }
        //    else if (s1 % 2 == 1 || s2 % 2 == 1 || s3 % 2 == 1)
        //    {
        //        return false;
        //    }

        //    return false;
        //}

    }
}
