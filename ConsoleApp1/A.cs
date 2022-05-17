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

    }
}
