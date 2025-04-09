using System.ComponentModel.DataAnnotations;

namespace Examen_2Parcial.Components.Data
{
    public class Productos
    {
        [Range(1, int.MaxValue, ErrorMessage = "El número de inventario debe ser un número positivo mayor a 0.")]
        public int Inventario { get; set; }
        [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
        [MaxLength(200, ErrorMessage = "El nombre no puede exceder los 200 caracteres.")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "Debe seleccionar el departamento")]
        [RegularExpression("^(Frutas|Verduras|Lácteos)$", ErrorMessage = "El departamento debe ser Frutas, Verduras o Lácteos.")]
        public string? Departamento { get; set; }
    }
}
