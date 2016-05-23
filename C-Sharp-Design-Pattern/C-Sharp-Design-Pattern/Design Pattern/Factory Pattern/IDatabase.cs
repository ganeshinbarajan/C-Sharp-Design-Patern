using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace C_Sharp_Design_Pattern.Design_Pattern.Factory_Pattern
{
    public interface IDatabase
    {
        IDbConnection DbConnection { get; }
        IDbCommand DbCommand { get;}
    }
}
