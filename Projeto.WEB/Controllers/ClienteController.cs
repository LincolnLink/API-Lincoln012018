using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

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
    }
}
