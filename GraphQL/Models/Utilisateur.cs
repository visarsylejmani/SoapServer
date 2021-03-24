using System.ComponentModel.DataAnnotations;

namespace GraphQL.Models
{
    public class Utilisateur
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string MotDePasse { get; set; }

    }
}
