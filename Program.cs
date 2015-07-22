using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SematicTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int foo = 5;
            int alter = 5;
        }

        void Hinzufügen(Person produkt)
        {
            
        }
    }

    struct A
    {
        public int Value { get; set; }
        public static A operator +(A a1, A a2)
        {
            return new A
            {
                Value = a1.Value + a2.Value
            };
        }
    }

    struct B : A
    {
        
    }

    class Person
    {
        public string Firstname;
        public string Lastname;
        public int Age;
    }
}
