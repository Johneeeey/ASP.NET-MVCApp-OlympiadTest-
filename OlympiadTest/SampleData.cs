using OlympiadTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympiadTest
{
    public class SampleData
    {
        public static void Initialize(TestContext context)
        {
            if (!context.BankOfQuestion.Any())
            {                
                context.SaveChanges();
            }
        }
    }
}
