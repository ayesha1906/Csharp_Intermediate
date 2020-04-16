using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)

        {
            //Upcasting :---------

            Text text = new Text();
            Shape shape = text;  //Upcasting 

            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width); //100 bcoz both are pointing to the same object
            

            //   StreamReader reader = new StreamReader(new MemoryStream()); here the object we sent here will be automatically upcast to its parent class which here is Stream

            var list = new ArrayList(); //stores objects in a list
            list.Add("Ayesha");
            list.Add(1);
            list.Add(new Text());
            /*
             Object is the parent of all classes in .Net framework
             We can pass any object to this ADd method and no conversion is required.
             All of these objects will be implicitly converted to the base object class.
           
             */

            //But a better way is to use Generic list where we can store elements of one specific type like:

            var anotherList = new List<int>(); //or <Shape> or any other type

            //DownCasting :---

            Shape shape1 = new Text();  //shape1 object is of type Text

            Text text1 = (Text)shape1; // through this downcast the shape obj can access every property of its derived class i.e Text

        }
    }
}
