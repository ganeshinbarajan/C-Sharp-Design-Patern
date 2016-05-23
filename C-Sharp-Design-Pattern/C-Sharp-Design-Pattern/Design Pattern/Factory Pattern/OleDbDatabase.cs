using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace C_Sharp_Design_Pattern.Design_Pattern.Factory_Pattern
{
    
    public class OleDbDatabase : IDatabase
    {
        private OleDbConnection _con = null;
        private OleDbCommand _cmd = null;
        public IDbCommand DbCommand
        {
            get
            {
                _cmd = new OleDbCommand();
                _cmd.Connection = _con;
                return _cmd;
            }
        }

        public IDbConnection DbConnection
        {
            get
            {
                _con = new OleDbConnection("provider=microsoft.ace.oledb.12.0;Datasource=;uid=pwd=");
                return _con;
            }
        }
    }
}
