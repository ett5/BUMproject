using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Core.BUM.Entitis;


namespace Data.BUM
{
    public class DataContexst:DbContext
    {
        public DbSet <Messages> MessagesList { get; set; }
    public DbSet<Neighbors> NeighborsList { get; set; }
 public DbSet<Payments> PaymentsList { get; set; }
public DbSet<Professionals> ProfessionalsList{ get; set; }
public DbSet<Revenues> RevenuesList{ get; set; }
public DbSet<Tasks> TaskList{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=BUM");
        }

    }
}
