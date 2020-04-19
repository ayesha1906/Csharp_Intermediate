using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter which connection you want (sql/oracle) ? ");
                var choice = Console.ReadLine();

                if (choice.ToLower() == "sql")
                {
                    var sqlconn = new Sqlconnection("Database name ans password");
                    sqlconn.OpenConnection();
                    sqlconn.CloseConnection();
                }
                else if(choice.ToLower()=="oracle")

                {
                    var oracleconn = new OracleConnection("Database name ans password");
                    oracleconn.OpenConnection();
                    oracleconn.CloseConnection();
                }
                else
                {
                    Console.WriteLine("Wrong choice !");
                }

            }
            catch (System.Exception)
            {

                throw;
            }
           
        }
    }
}
