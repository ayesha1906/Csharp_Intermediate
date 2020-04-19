using System;


namespace Exercise_4
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        protected DbConnection(string _constring)
        {
            if (String.IsNullOrEmpty(_constring))
                throw new InvalidOperationException("Empty string passed");

            ConnectionString = _constring;

        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();

    }
}
