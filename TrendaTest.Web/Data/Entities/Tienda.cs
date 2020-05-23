using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TrendaTest.Web.Data.Entities
{
    public class Tienda
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El {0} campo no puede tener mas de {1} caracteres.")]
        public string Nombre { get; set; }


        [Display(Name = "Fecha de apertura")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DataType(DataType.DateTime)]//modificar como se recibe la fecha a dd-mm-YYYY
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime FechaApertura { get; set; }

        public ICollection<Producto> Productos { get; set; }

    }
}
