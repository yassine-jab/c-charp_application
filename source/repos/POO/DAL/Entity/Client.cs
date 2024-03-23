using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entity
{
    [Table("T_Caroussel")]
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        public string Nom { get; set; } = string.Empty;
        [MaxLength(500)]
        public string Prenom { get; set; } = string.Empty;
        [MaxLength(60)]
        public string Password { get; set; } = string.Empty;


    }

}
