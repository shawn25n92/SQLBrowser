using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLBrowser
{
    public class SQLBDataSource
    {
        public string AuthenticationMode { get; set; }
        public string Server { get; set; }
        public string Database { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        
        public SQLBDataSource(string Server, string Database, string UserID, string Password)
        {
            this.AuthenticationMode = "sqlauth";
            this.Server = Server;
            this.Database = Database;
            this.UserID = UserID;
            this.Password = Password;
        }
        public SQLBDataSource(string Server, string Database)
        {
            this.AuthenticationMode = "winauth";
            this.Server = Server;
            this.Database = Database;
        }
        public string GetConnectionString()
        {
            string ConnectionString = "";
            if(this.AuthenticationMode == "sqlauth")
            {
                ConnectionString = String.Format(
                    "server={0};" +
                    "database={1};" +
                    "user id={2};" +
                    "password={3}",
                    this.Server,
                    this.Database,
                    this.UserID,
                    this.Password
                    );
            }
            else if (this.AuthenticationMode == "winauth")
            {
                ConnectionString = String.Format(
                    "server={0}" +
                    "database={1}" +
                    "trusted_connection={2}",
                    this.Server,
                    this.Database,
                    true
                    );
            }
            return ConnectionString;
        }
    }
}
