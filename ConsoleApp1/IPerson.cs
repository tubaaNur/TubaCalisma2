using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TubaCalisma2;

namespace TubaCalisma2
{
     interface IPerson
    {
        void Add();
        void Update();
        string Email { get; set; }
        string Adress { get; set; }
    }

    class Customer : IPerson
    {
        public string Email { get; set; }
        public string Adress { get; set; }
        public int CustomerCode { get; set; }

        public void Add()
        {

            Console.WriteLine("Customer Eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Customer Güncellendi.");

        }
    }
        class Student : IPerson
        {
            public string Email { get; set; } 
            public string Adress { get; set; }
            public string Bolum { get; set; }
            public void Add()
            {
                Console.WriteLine("Öğrenci eklendi.");
            }

            public void Update()
            {
                Console.WriteLine("Öğrenci güncellendi.");
            }
        }

        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.Adress);            }
        }
    }


