using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Design_Pattern.Design_Pattern.Factory_Pattern
{
    public class DatabaseFactory
    {
        public static IDatabase CreateDatabase(string Db_Type)
        {
            if(Db_Type.Equals("SqlServer"))
            {
                return new SQLServerDataBase();
            }
            else if(Db_Type.Equals("OleDB"))
            {
                return new OleDbDatabase();
            }
            return null;
        }
    }
}
