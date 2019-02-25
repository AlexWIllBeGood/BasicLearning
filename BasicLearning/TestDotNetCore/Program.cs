using Npgsql;
using System;
using System.Data;
using System.Windows.Input;

namespace TestDotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //IDbConnection connection;

            //connection = new NpgsqlConnection("Server=168.33.162.63;Database=FYUNDB;user id=sa;password=fanyun@2018;");
            //Console.WriteLine(GetServerVersion(connection));
            //Console.ReadKey();

            TestContext tc = new TestContext();
            string PKID = Guid.NewGuid().ToString("N");
            tc.Student.Add(new Entities.Student() { PKID = PKID, Name = "Alex", Age = 25, Major = "SoftwareEngineer" });
            tc.SaveChanges();

        }
        public static string GetServerVersion(IDbConnection connection)
        {
            ConnectionState originalState = connection.State;
            if (originalState != ConnectionState.Open)
            {
                connection.Open();
            }
            try
            {
                IDbCommand command = connection.CreateCommand();
                command.CommandText = "select count(*) from dbo.fy_employee";
                return command.ExecuteScalar().ToString();
            }
            finally
            {
                if (originalState == ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }
    }
}
