using ConsoleApp.operators;
using ConsoleApp.partailClass;
using System;

namespace ConsoleApp {
    class Program {
        static void Main(string[] args)
        {
            // Class A Object
            // Console.WriteLine("Class A a = new A()");
            //A a = new A();

            //Console.WriteLine("");
            // Class B Object
            //  Console.WriteLine("Class B b = new B()");
            // B b = new B();
            // A a = new A();

            // PartialClass obj2 = new PartialClass();
            // obj2.ShowMessage();

            //PartialClass obj = new PartialClass("1234");
            // Test tst = new Test();
            OperatorClass operatorClass = new OperatorClass();
            operatorClass.OperatorMessages();

        }
    }

    class A {
        public A() // Second Call
        {
            Console.WriteLine("Default A constructor");
        }
        static A() // First Call
        {
            Console.WriteLine("static A constructor");
        }
    }

    class B : A {
        public B()
        {
            Console.WriteLine("Default B constructor");
        }
        static B()
        {
            Console.WriteLine("static B constructor");
        }
    }
}
