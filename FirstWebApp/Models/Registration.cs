using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FirstWebApp.Models { 
    public class Registration
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        [DisplayName("Imię")]
        public string Imie { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        [DisplayName("Nazwisko")]
        public string Nazwisko { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        [DisplayName("Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        [DisplayName("Numer telefonu")]
        public string Telefon { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        [DisplayName("Kurs")]
        public string Kurs { get; set; }
    }
}
