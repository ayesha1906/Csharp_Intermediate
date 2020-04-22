using System;


namespace Inheritance
{
    interface IInterface1
    {
        void Method1();
        void Method2();
        void Method3();

    }
    interface IInterface2
    {
        void Method2();
        void Method3();
    }
    class MyClass1
    {
        public void M1()
        {
            Console.WriteLine("M1 from MyClass2");
        }
    }

    class MyClass2: MyClass1, IInterface1, IInterface2 // Both interfaces 
    {
        public void Method1()
        {
            Console.WriteLine("Method 1 of interface");
        }

        public void Method2()    // This method will be common for both interfaces ; but if we want different
                                 //implementations then we can do it as shown for method 3
        {
            Console.WriteLine("Method 2 of interface");
        }
         void IInterface1.Method3()
        {
            Console.WriteLine("Method 3 from interface 1");
        }
            void IInterface2.Method3()
        {
            Console.WriteLine( "Method 3 from Interface 2");
        }
        
    }
    class Inheritance_Ex
    {
        static void Main(string[] args)
        {
            MyClass2 myclass2 = new MyClass2();
            myclass2.Method1();
            myclass2.Method2();
            // we cannot access method3 through myclass2 , so we can:

            IInterface1 i1 = new MyClass2();
            i1.Method3();

            IInterface2 i2 = new MyClass2();
            i2.Method3();
        }
    }
}
