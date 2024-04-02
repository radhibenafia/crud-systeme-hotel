using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models.HotellerieModel
{
    public class Hotel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "champ obligatoire")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "longueur entre 3 et 20")]
        public string Nom { get; set; } = null!;

        [Range(1, 5, ErrorMessage = "valeur comprise entre 1 et 5")]
        public int Etoiles { get; set; }

        [Required(ErrorMessage = "champ obligatoire")]
        public string Ville { get; set; } = null!;

        [Required, Url(ErrorMessage = "URL non valide"), Display(Name = "Site Web")]
        public string SiteWeb { get; set; } = null!;

        public int Tel { get; set; }
        public virtual ICollection<Appreciation> Appreciations { get; set; }
    }
}
