using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace C_Sharp_Design_Pattern.Design_Pattern.Factory_Pattern
{
    public class SQLServerDataBase : IDatabase
    {
        private SqlConnection _con = null;
        private SqlCommand _command = null;
        public IDbCommand DbCommand
        {
            get
            {
                _command = new SqlCommand();
                _command.Connection = _con;
                return _command;
            }
        }

        public IDbConnection DbConnection
        {
            get
            {
                _con = new SqlConnection("Data Source= servername;Initial catalog=Test;integrated security=sspi");
                return _con;
            }
        }
    }
}
