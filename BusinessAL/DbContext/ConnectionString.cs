using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAL.DbContext
{
    public class ConnectionString
    {
        public string DefaultConnectionString { get; private set; }
        public ConnectionString(string connectionString)
        {
            DefaultConnectionString = connectionString;
        }
    }

    public interface IConnectionString
    {
        string DefaultConnectionString { get; }
    }
}
