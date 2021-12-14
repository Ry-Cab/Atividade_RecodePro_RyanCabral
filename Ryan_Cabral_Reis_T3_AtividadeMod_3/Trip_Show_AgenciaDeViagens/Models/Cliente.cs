using System;
using  System.ComponentModel.DataAnnotations;

namespace Trip_Show_AgenciaDeViagens.Models
{
    public class Cliente
    {
        [Key]
        [Required]
        public int ID_CLIENTE { get; set; }

        
        [StringLength(60)]
        [Required(ErrorMessage = "Digite o nome do cliente")]
        public string NOME_CLIENTE{ get; set; }

        [StringLength(60)]
        [Required(ErrorMessage = "Digite o E-mail do cliente")]
        public string EMAIL_CLIENTE{ get; set; }

        [StringLength(60)]
        [Required(ErrorMessage = "Digite a cidade de origem do cliente")]
        public string CIDADE_CLIENTE{ get; set; }

        [StringLength(60)]
        [Required(ErrorMessage = "Digite o estado de origem do cliente")]
        public string ESTADO_CLIENTE{ get; set; }

        [StringLength(15)]
        [Required(ErrorMessage = "Digite a data de ida do cliente")]
        public string DATA_IDA { get; set; }

        [StringLength(15)]
        [Required(ErrorMessage = "Digite a data de volta do cliente")]
        public string DATA_VOLTA { get; set; }

        [StringLength(15)]
        [Required(ErrorMessage = "Digite a data de nascimento do cliente")]
        public string DATA_NASC { get; set; }


    }
}