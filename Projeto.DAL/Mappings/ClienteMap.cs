using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration; //ORM
using Projeto.Entidades;

namespace Projeto.DAL.Mappings
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            //nome da tabela
            ToTable("Cliente");

            //chave primaria
            HasKey(c => c.IdCliente);

            //demais propriedades
            Property(c => c.IdCliente) //propriedade da classe
                .HasColumnName("IdCliente") //nome do campo na tabela
                .IsRequired(); //not null

            //demais propriedades
            Property(c => c.Nome)
                .HasColumnName("Nome") //nome do campo na tabela
                .HasMaxLength(50) //nvarchar(50)
                .IsRequired(); //not null

            //demias propriedade
            Property(c => c.Email) //propriedade da classe
                .HasColumnName("Email") //nome do campo na tabela
                .HasMaxLength(50) //nvarchar(50)
                .IsRequired(); //not null

            //demias propriedades
            Property(c => c.DataCadastro) //propriedade da classe
                .HasColumnName("DataCadastro") //nome do campo na tabela
                .IsRequired(); //not null            
            
        }
    }
}
