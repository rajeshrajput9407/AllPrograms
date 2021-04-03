namespace ConsoleApp.partailClass {
      partial class PartialClass {
        public PartialClass()
        {
            System.Console.WriteLine("partail class constructor");           
        }

    }
     public partial class PartialClass {
        public PartialClass(string name)
        {
            System.Console.WriteLine("parameter partail class constructor");
        }

        public void ShowMessage()
        {
            System.Console.WriteLine("this is method of PartialClass");
        }

    }
    public class A {

    }
    public class Test: PartialClass {

        public Test()
        {
            System.Console.WriteLine("constructor of test class");
        }
    }
}
