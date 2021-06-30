using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SegundoParcialAp2_20180240.Models
{
    public class CobrosDetalle
    {
        [Key]
        public int Id { get; set; }

        public int CobroId { get; set; }
        public Cobros Cobro { get; set; }

        public int VentaId { get; set; }
        public Ventas Venta { get; set; }

        public double Cobrado { get; set; }
    }
}
