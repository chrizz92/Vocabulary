using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Round> Rounds { get; set; }
        public DbSet<RoundWord> RoundWords { get; set; }
        public DbSet<Word> Words { get; set; }
        public DbSet<Trial> Trials { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Environment.CurrentDirectory)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            var configuration = builder.Build();
            Debug.Write(configuration.ToString());
            string connectionString = configuration["ConnectionStrings:DefaultConnection"];
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
