using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person2 : IPersonRepository
    {
        public void Talk(string s)
        {
            Console.WriteLine("hihih");
        }
    }
}
