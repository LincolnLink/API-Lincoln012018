using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entidades
{
    public class Cliente
    {
        //Propriedades
        //[prop] + 2x[tab]
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }

        //Metodo Construtor 
        public Cliente()
        {

        }

        //Sobrecarga do metodo construtor
        public Cliente(string nome, string email, DateTime dataCadastro)
        {
            Nome = nome;
            Email = email;
            DataCadastro = dataCadastro;
        }

        //Sobreescrita do metodo ToString()
        public override string ToString()
        {
            return $"ID: { IdCliente }, Nome: { Nome }," +
                $" Email: { Email }, Data: { DataCadastro }";
        }

    }
}
