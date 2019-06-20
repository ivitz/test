using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace ConsoleApp1
{
    class Person : IPersonRepository
    {
        private readonly ISpeakerRepository _speaker;
        public Person(ISpeakerRepository speaker)
        {
            _speaker = speaker;
        }
        public void Talk(string s)
        {
            _speaker.Speak(s);
        }
    }
}
