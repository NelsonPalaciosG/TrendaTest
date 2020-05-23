using System.ComponentModel.DataAnnotations;

namespace TrendaTest.Web.Data.Entities
{
    public class Producto
    {

        [Key]
        [Display(Name = "SKU")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int Sku { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El {0} campo no puede tener mas de {1} caracteres.")]
        public string Nombre { get; set; }

        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El {0} campo no puede tener mas de {1} caracteres.")]
        public string Descripcion { get; set; }

        [DisplayFormat(DataFormatString = "{0:C0}",
        ApplyFormatInEditMode = false)]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [MaxLength(15, ErrorMessage = "El {0} campo no puede tener mas de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int Valor { get; set; }

        [Display(Name = "Imagen")]
        public string PicturePath { get; set; }

        public Tienda Tienda { get; set; }
    }
}
