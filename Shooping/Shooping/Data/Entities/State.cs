using System.ComponentModel.DataAnnotations;

namespace Shooping.Data.Entities
{
    public class State
    {
        public int Id { get; set; }

        [Display(Name = "Departamento/Estado")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }

        // Relación: Un estado pertenece a un país.
        public Country Country { get; set; }

        // Relación: Un estado tiene muchas Ciudades.
        public ICollection<City> Cities { get; set; }

        // Propiedad Lectura:
        [Display(Name = "Ciudades")]
        public int CitiesNumber => Cities == null ? 0 : Cities.Count;
    }
}
