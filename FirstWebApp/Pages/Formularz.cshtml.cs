using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace FirstWebApp.Pages
{
    public class FormularzModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Pole wymagane")]
        public string Imie { get; set; } = "";

        [BindProperty]
        [Required(ErrorMessage = "Pole wymagane")]
        public string Nazwisko { get; set; } = "";

        [BindProperty]
        [Required(ErrorMessage = "Pole wymagane")]
        public string Email { get; set; } = "";

        [BindProperty]
        [Required(ErrorMessage = "Pole wymagane")]
        public string Telefon { get; set; } = "";

        [BindProperty]
        [Required(ErrorMessage = "Pole wymagane")]
        public string Kurs { get; set; } = "";

        [BindProperty]
        public string? Uwagi { get; set; } = "";

        public string successMessage = "";
        public string errorMessage = "";

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                errorMessage = "Niepoprawne dane";
                return;
            }successMessage = "Zapisano na kurs";

            Imie = "";
            Nazwisko = "";
            Email = "";
            Telefon = "";
            Kurs = "";
            Uwagi = "";

            ModelState.Clear();

        }

    }
}
