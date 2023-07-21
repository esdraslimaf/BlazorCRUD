using System.ComponentModel.DataAnnotations;

namespace BlazorEmpresasCrud.Models
{
    public class Empresa
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }

        public void NewId()
        {
            Id = Guid.NewGuid();
        }
    }
}
