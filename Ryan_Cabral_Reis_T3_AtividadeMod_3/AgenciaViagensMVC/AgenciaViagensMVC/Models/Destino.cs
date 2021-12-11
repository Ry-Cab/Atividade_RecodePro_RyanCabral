using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgenciaViagensMVC.Models
{
    public class Destino
    {
        [Key]
        public int IdDestino { get; set; }

        [Required(ErrorMessage ="Digite uma cidade")]
        [StringLength(50)]
        public string CidadeDestino { get; set; }

        [Required(ErrorMessage = "Digite um estado")]
        [StringLength(50)]
        public string EstadoDestino { get; set; }

        [Required(ErrorMessage = "Digite um país")]
        [StringLength(50)]
        public string PaisDestino { get; set; }
    }
}
