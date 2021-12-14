using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Trip_Show_AgenciaDeViagens.Models
{
    public class Passagem
    {
        [Key]
        [Required]
        public int ID_PASSAGEM { get; set; }

        [StringLength(15)]
        [Required(ErrorMessage = "Digite a data da compra do desitno")]
        public string DATA_COMPRA{ get; set; }

        [Required]
        public int ClienteID_CLIENTE{get;set;}
        public Cliente Cliente {get; set;}

        [Required]
        public int DestinoID_DESTINO{get; set;}
        public Destino Destino {get; set;}
        
    }
}