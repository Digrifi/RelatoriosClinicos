using Microsoft.EntityFrameworkCore;
using SistemaClinicaRelatorio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClinicaRelatorio.Infra.Data.Context
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext(DbContextOptions<SQLServerContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        #region DbSets<Tables>
        public DbSet<Address> Address { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<Specialty> Specialty { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<User> User { get; set; }
        #endregion

    }
}
