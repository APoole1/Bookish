using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dapper;

namespace Bookish
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            var SqlString = "SELECT TOP 100 [Name] FROM [Person]";
            var ourCustomers = (List<Person>)db.Query<Person>(SqlString);
            Console.WriteLine(ourCustomers[0].Name);
            Console.ReadLine();
        }
    }
}
