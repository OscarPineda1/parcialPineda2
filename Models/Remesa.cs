using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Parcial.Models
{
    [Table("t_remesas")]
    public class Remesa
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Remitente { get; set; }
        public string? Destinatario { get; set; }
        public string? PaisOrigen { get; set; }
        public string? PaisDestino { get; set; }
        public decimal? MontoEnviado { get; set; }
        public string? TipoMoneda { get; set; }
        public decimal? TasaCambio { get; set; }
        public decimal? MontoFinal { get; set; }
        public string? Status { get; set; } = "PENDIENTE";

        public void CalcularMonto()
        {
            MontoFinal = TasaCambio * MontoEnviado;
        }
    }
}
