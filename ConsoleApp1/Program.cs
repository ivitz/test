using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        

        private static void Main(string[] args)
        {


            ISpeakerRepository speaker = new Speaker();
            IPersonRepository person = new Person(speaker);

            person.Talk("zdarova");

            //говно какое то


        }

        
    }
}
