using Microsoft.EntityFrameworkCore;

namespace RelatorioPacientes.Models
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto>options):base(options)
        { 

        }   
        public DbSet<Paciente> Paciente { get; set; }    
         
    }
}
