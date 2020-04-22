namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
          var dbMigrator = new DbMigrator(new ConsoleLogger());
            //or through FileLogger
          var dbMigrator1 = new DbMigrator(new FileLogger(@"D:\VisualStudioCodes\C# Intermediate\Extensibility\Extensibility\log.txt"));
            
            dbMigrator.Migrate();
            dbMigrator1.Migrate(); //creates a log.txt file and shows output in it 

        }
    }
}
