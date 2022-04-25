using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TubaCalisma2;

namespace TubaCalisma2
{
    class CustomerManager
    {
        //Field
        public string Name;
        //Property
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public static void Add()
        {

            Console.WriteLine(" Kaydedilen müşteri adını giriniz: ");
            Console.ReadLine(); //Konsolu ekranda tutar. Kullanıcıdan değer almamı sağlar. 
        }

    }
}
