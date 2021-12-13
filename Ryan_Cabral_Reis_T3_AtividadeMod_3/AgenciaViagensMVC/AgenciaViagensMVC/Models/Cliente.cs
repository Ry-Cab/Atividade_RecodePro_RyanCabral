using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgenciaViagensMVC.Models
{
    public class Cliente
    {
        [Key]
        public int IdPessoa { get; set; }

        [Required(ErrorMessage = "Digite o nome do cliente")]
        [StringLength(50)]
        public string nome_cliente { get; set; }

        [Required(ErrorMessage = "Digite o email do cliente")]
        [StringLength(50)]
        public string email { get; set; }

        [Required(ErrorMessage = "Digite o estado de origem do cliente")]
        [StringLength(60)]
        public string EstadoOrigem { get; set; }

        [Required(ErrorMessage = "Digite a cidade de origem do cliente")]
        [StringLength(60)]
        public string CidadeOrigem { get; set; }

        [Required(ErrorMessage = "Digite a data de nascimento do cliente")]
        [StringLength(15)]
        public string DataNasc { get; set; }

        [Required(ErrorMessage = "Digite a data de ida do cliente")]
        [StringLength(15)]
        public string DataIda { get; set; }

        [Required(ErrorMessage = "Digite a data de volta do cliente")]
        [StringLength(15)]
        public string Datavolta { get; set; }
    }
}
