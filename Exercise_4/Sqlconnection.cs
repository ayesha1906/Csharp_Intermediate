using System;

namespace Exercise_4
{
    public class Sqlconnection : DbConnection
    {
        public Sqlconnection(string _constring) : base(_constring)
        {

        }

        public override void OpenConnection()
        {
            Console.WriteLine("Sql Connection established.");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Sql Connection Closed.");
        }


    }
}
