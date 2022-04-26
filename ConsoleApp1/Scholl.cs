using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TubaCalisma2;


namespace TubaCalisma2
{
    class Schooll
    {
        public virtual void AddS()
        {
            Console.WriteLine("Okul Eklendi.");
        }
        
        public string Name { get; set; }
        public string Location { get; set; }

    }
    class Students : Schooll
    {
        public int SchollNo { get; set; }
        public override void AddS()
        {
            Console.WriteLine("Öğrenci eklendi.");
            base.AddS(); 

        }
        //Parametresiz string döndüren liste 
        //public string List()
        //{
        //    List<string> list = new List<string>();
        //    list.Add(Name="Başar"); 
        //    list.Add(Location="Isparta"); 
        //    return list.ToString();
        //}
    }
    
}
