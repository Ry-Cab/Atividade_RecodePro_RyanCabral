using System;
using Trip_Show_AgenciaDeViagens.Models;
using Microsoft.EntityFrameworkCore;

namespace Trip_Show_AgenciaDeViagens.Data
{
    public class PassagemContext : DbContext
    {
        public PassagemContext(DbContextOptions<PassagemContext> opt) : base(opt){

        }
        public DbSet<Passagem> Passagens{get; set;}
        
        public DbSet<Cliente> Clientes {get;set;}

        public DbSet<Destino> Destinos { get;set;}
    }
}