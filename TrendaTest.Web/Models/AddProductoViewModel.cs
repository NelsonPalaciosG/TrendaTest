using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrendaTest.Web.Models
{
    public class AddProductoViewModel
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Nombre { get; set; }

        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Descripcion { get; set; }

        [DisplayFormat(DataFormatString = "{0:C0}",
        ApplyFormatInEditMode = false)]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        public int Valor { get; set; }

        [Display(Name = "Imagen")]
        public string PicturePath { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Tienda { get; set; }
    }
}
