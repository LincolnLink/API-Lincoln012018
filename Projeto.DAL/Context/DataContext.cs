using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Projeto.DAL.Mappings;
using Projeto.Entidades;
using System.Configuration;

namespace Projeto.DAL.Context
{
    //Regra 1) Herdar DbContext
    public class DataContext : DbContext
    {

        //Regra 2) Declarar um construtor que irá enviar para construtor
        //da superclasse (DbContext) a connectionstring
        public DataContext() 
            : base(ConfigurationManager.ConnectionStrings["projeto"].ConnectionString) 
        {

        }
        //Regra 3) Sobrescrever o método OnModelCreating..
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //definir cada classe de mapeamento..
            modelBuilder.Configurations.Add(new ClienteMap());
        }

        //Regra 4) Declarar uma propriedade (set/get) DbSet para cada entidade
        //Este DbSet te permite realizar operações LAMBDA com cada entidade
        public DbSet<Cliente> Cliente { get; set; }
    }
}
