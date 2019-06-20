using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IProgrammer
    {
        string Language { get; set; }
        int ExperienceInYears { get; set; }
        float Salary { get; set; }
    }
}
