using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using siteMVC.Models;


namespace siteMVC.Data
{
    public class BancoContext : DbContext
    {
        //configuração PADRÃO
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }
        public DbSet<ContatoModel> Contatos {get; set;} // entre <> vem a classe que representa o banco de dados; Contatos é o nome da tabela
    }
   
}
