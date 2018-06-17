using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Projeto.Entidades;
using Projeto.DAL.Context;
using Projeto.DAL.Generics;

namespace Projeto.DAL.Repositories
{
    public class ClienteRepository : GenericRepository<Cliente>
    {
    }
}
