using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Trip_Show_AgenciaDeViagens.Models
{
    public class Destino
    {
        [Key]
        [Required]
        public int ID_DESTINO { get; set; }

        [StringLength(60)]
        [Required(ErrorMessage = "Digite a cidade de destino")]
        public string CIDADE_DESTINO{ get; set; }

        [StringLength(60)]
        [Required(ErrorMessage = "Digite o estado de destino")]
        public string ESTADO_DESTINO{ get; set; }

        [StringLength(60)]
        [Required(ErrorMessage = "Digite o país de destino")]
        public string PAIS_DESTINO{ get; set; }

    
        [Required(ErrorMessage = "Digite o preço do destino")]
        public decimal PRECO_DESTINO{ get; set; }

        


    }
}