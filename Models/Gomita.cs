using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RazorPagesMovie.Models
{
    public class Gomita
    {
        public int ID { get; set; }
        public string Tipo { get; set; } = string.Empty;
        [Display(Name = "Fecha de Ingreso")]
        [DataType(DataType.DateTime)]
        public DateTime FechadeEntrega { get; set; }
        public string presentacion { get; set; } = string.Empty;
        public decimal Precio { get; set; }
    }
}