using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Speaker : ISpeakerRepository
    {
        public void Speak(string s)
        {
            Console.WriteLine(s);
        }
    }
}
