using System;
using System.Collections.Generic;

namespace Exercise_3
{
    public class Stack
    {
        private readonly List<object> _list = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Cannot add null object to stack");

            _list.Add(obj);
           
            
        }
        public void Display()
        {
            Console.WriteLine("After Pushing on to stack elements are :");
            foreach (var no in _list)
                Console.WriteLine(no);
        }

        public object Pop()
        {
            if (_list.Count==0)
                throw new InvalidOperationException("There are no elements in the stack");

            var index = _list.Count - 1;
            var toReturn = _list[index];

            _list.RemoveAt(index);

            return (toReturn);
        }

        public void Clear()
        {
            _list.Clear();
        }

    }

   
    class Exercise_Stack
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            
            var elemnt = new int[5];
            for(int i=0; i<5;i++)
            {
                Console.WriteLine("Enter Number {0}: ",i+1);
                elemnt[i] =Convert.ToInt32(Console.ReadLine());
                stack.Push(elemnt[i]);
            }
          
            /*
            int ini = 0;
            int max = 5;
            for (int i = ini; i <= max; i++)
                stack.Push(i);
            */

            stack.Display();

            //stack.Clear();
            Console.WriteLine("Popping the elements from stack: ");

            for (int i =0; i <5; i++)
                Console.WriteLine(stack.Pop());

           
        }
    }
}
