using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClientsServicesAPI.Models
{
    public class Service
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "varchar(255)")]
        [StringLength(255, ErrorMessage = "El nombre debe tener menos de 256 caracteres.")]
        public required string Name { get; set; }

        [Column(TypeName = "varchar(255)")]
        [StringLength(255, ErrorMessage = "La descripción debe tener menos de 256 caracteres.")]
        public required string Description { get; set; }
    }
}
