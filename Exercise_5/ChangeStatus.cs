using System;

namespace Exercise_5
{
    public class ChangeStatus : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Status Changed..");
        }
    }

}
