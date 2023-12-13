using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testSQl.Model;

namespace testSQl.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            object value = optionsBuilder.UseSqlServer("Server=DESKTOP-V2648S0;Database=TestDataBase;Trusted_Connection=True;TrustServerCertificate= True;");
        }
        public  DbSet<DoubleGlazedWindows> DoubleGlazedWindows { get; set; }
    }
}
