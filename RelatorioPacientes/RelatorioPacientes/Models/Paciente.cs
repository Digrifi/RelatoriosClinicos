using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RelatorioPacientes.Models
{
    [Table("Paciente")]
    public class Paciente
    {
        [Key]
        [Column("MRN")]
        [Display(Name="MRN")]
        public int MRN { get; set; }

        [Column("Name")]
        [Display(Name ="Name")]
        public string Name { get; set; }

        [Column("Gender")]
        [Display(Name="Gender")]  
        public string Gender { get; set; }

        [Column("DateOfBirth")]
        [Display(Name = "Date Of Birth")]
        public int DateOfBirth { get; set; }

        [Column("PhoneNumber")]
        [Display(Name = "Phone Number")]
        public int PhoneNumber { get; set; }

        [Column("CPF")]
        [Display(Name ="CPF")]
        public int CPF { get; set; }



    }
}
