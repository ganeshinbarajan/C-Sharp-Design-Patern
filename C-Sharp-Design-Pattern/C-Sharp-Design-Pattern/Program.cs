using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Sharp_Design_Pattern.Design_Pattern.Factory_Pattern;
namespace C_Sharp_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = DatabaseFactory.CreateDatabase("SqlServer");
        }
    }
}
