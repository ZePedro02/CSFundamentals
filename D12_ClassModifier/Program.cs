using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;
namespace D12_ClassModifier
{
    class Program
    {
        static void Main(string[] args)
        {
             User user01 = new User();
            user01.createUser();
            user01.ListarUser();
            Utility.terminateConsole();
    }
    }
}
