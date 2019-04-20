using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympiadTest.Models
{
    public class Result
    {
        int ID_Rezultat { get; set; }
        int ID_User { get; set; }
        int ID_Test { get; set; }
        decimal Marks { get; set; }
        DateTime TimeRez { get; set; }
        DateTime DateRez { get; set; }
    }
}
