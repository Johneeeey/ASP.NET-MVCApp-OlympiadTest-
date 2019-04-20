using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympiadTest.Models
{
    public class TestContext : DbContext
    {
        public DbSet<Result> Result { get; set; }
        public DbSet<Test> Test { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<BankOfQuestion> BankOfQuestion { get; set; }
        public TestContext(DbContextOptions<TestContext> options) : base(options)
        {

        }
    }
}
