﻿using System.ComponentModel.DataAnnotations;

namespace Shooping.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name = "País")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }

        // Relación: Un país tiene muchos estados.
        public ICollection<State> States {  get; set; }

        // Propiedad Lectura:
        [Display(Name = "Departamento/Estados")]
        public int StatesNumber => States == null ? 0 : States.Count;

    }
}
