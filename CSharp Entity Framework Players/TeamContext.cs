using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Entity_Framework_Players {
    public class TeamContext:DbContext {

        public DbSet<Player> Players { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Data Source=localhost;Database=TeamDB;" +
            "Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
