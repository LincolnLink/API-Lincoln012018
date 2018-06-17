using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades;
using Projeto.DAL.Repositories;

namespace Projeto.BLL
{
    public class ClienteBusiness
    {
        public void Cadastrar(Cliente c)
        {
            ClienteRepository rep = new ClienteRepository();
            rep.Insert(c); //gravando
        }

        public void Atualizar(Cliente c)
        {
            ClienteRepository rep = new ClienteRepository();
            rep.Update(c); //atualizando
        }

        public void Excluir(Cliente c)
        {
            ClienteRepository rep = new ClienteRepository();
            rep.Delete(c);
        }

        public List<Cliente> Consultar()
        {
            ClienteRepository rep = new ClienteRepository();
            return rep.FindAll();
        }

        public Cliente ObterPorId(int idCliente)
        {
            ClienteRepository rep = new ClienteRepository();
            return rep.FindById(idCliente);
        }

    }
}
