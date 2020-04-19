using System;

namespace Exercise_4
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string _constring) : base(_constring)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Oracle Connection established.");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Oracle Connection Closed.");
        }
    }
}
