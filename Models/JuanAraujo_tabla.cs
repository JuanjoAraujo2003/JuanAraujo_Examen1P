using System.ComponentModel.DataAnnotations;

namespace JuanAraujo_Examen1P.Models
{
    public class JuanAraujo_tabla
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? JaName { get; set; }
        public bool JaTieneCita { get; set; }
        public DateTime? JaFechaCita { get; set; }

        [Range (0.1, 9999.99)]
        public decimal JaValorCita { get; set; }


    }
}
