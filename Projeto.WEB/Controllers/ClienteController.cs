using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Projeto.WEB.Models;
using Projeto.Entidades;
using Projeto.BLL;


namespace Projeto.WEB.Controllers
{
    [RoutePrefix("api/cliente")] //endereço
    public class ClienteController : ApiController
    {
        ///HttpResponseMessage
        ///Tipo utilizado em WebApi para criar métodos que irão funcionar
        ///como serviços para acesso de outras aplicações.
        [HttpGet] //executado por URL
        [Route("helloworld")] //URL: /api/cliente/helloworld?nome={0}
        public HttpResponseMessage HelloWorld(string nome)
        {
            string mensagem = $"Ola { nome }, eu sou um microserviço! ";

            //retornando um status de sucesso, dizendo para o cliente
            //que a requisição ao serviço funcionou!!
            return Request.CreateResponse(HttpStatusCode.OK, mensagem);
        }


        //serviço para cadastrar cliente!
        [HttpPost] //requisição do tipo POST
        [Route("cadastrar")] //URL: /api/cliente/cadastrar
        public HttpResponseMessage Post(ClienteModelCadastro model)
        {
            try
            {
                Cliente c = new Cliente();
                c.Nome = model.Nome;
                c.Email = model.Email;
                c.DataCadastro = DateTime.Now;

                ClienteBusiness business = new ClienteBusiness();
                business.Cadastrar(c);

                return Request.CreateResponse(HttpStatusCode.OK, 
                    $" Cliente {c.Nome}, cadastrado com sucesso");
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, 
                    "Erro: " + e.Message);
            }
        }

        //serviço para atualizar
        [HttpPut]
        [Route("atualizar")] //URL: /api/cliente/atualizar
        public HttpResponseMessage Put(ClienteModelEdicao model)
        {
            try
            {
                //buscar o cliente pelo id
                ClienteBusiness business = new ClienteBusiness();

                Cliente c = business.ObterPorId(model.IdCliente);

                //alterando os dados!
                c.Nome = model.Nome;
                c.Email = model.Email;

                business.Atualizar(c); //alterando

                return Request.CreateResponse(HttpStatusCode.OK, $"Cliente {c.Nome}, " +
                    $" atualizado com sucesso.");
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, 
                    "Erro: " + e.Message);
            }            
        }

        //serviço para excluir
        [HttpDelete]
        [Route("excluir")] //URL: /api/cliente/excluir?id={0}
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                ClienteBusiness business = new ClienteBusiness();
                Cliente c = business.ObterPorId(id);

                //excluindo
                business.Excluir(c);

                return Request.CreateResponse(HttpStatusCode.OK, $"Cliente {c.Nome}, " +
                    $" excluido com sucesso!");
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, " " +
                    "Erro: " + e.Message);
            }
        }

        //serviço para consultar
        [HttpGet]
        [Route("consultar")] //URL: /api/cliente/consultar
        public HttpResponseMessage GetAll()
        {
            try
            {
                //lista da classe de modelo
                List<ClienteModelConsulta> lista = new List<ClienteModelConsulta>();
                ClienteBusiness business = new ClienteBusiness();

                foreach (Cliente c in business.Consultar())
                {
                    ClienteModelConsulta model = new ClienteModelConsulta();
                    model.IdCliente = c.IdCliente;
                    model.Nome = c.Nome;
                    model.Email = c.Email;
                    model.DataCadastro = c.DataCadastro;

                    lista.Add(model); //adicionar na lista
                }

                return Request.CreateResponse(HttpStatusCode.OK, lista);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, " " +
                    "Error: " + e.Message); ;
            }
        }

        [HttpGet]
        [Route("obter")] //URL: /api/cliente/obter?id={0}
        public HttpResponseMessage Get(int id)
        {
            try
            {
                ClienteBusiness business = new ClienteBusiness();
                ClienteModelConsulta model = new ClienteModelConsulta();
                Cliente c = business.ObterPorId(id);

                model.IdCliente = c.IdCliente;
                model.Nome = c.Nome;
                model.Email = c.Email;
                model.DataCadastro = c.DataCadastro;

                return Request.CreateResponse(HttpStatusCode.OK, model);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "" +
                    "Erro: " + e.Message);
            }
        }




    }
}
