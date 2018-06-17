using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Projeto.DAL.Context;
using Projeto.Entidades;

namespace Projeto.DAL.Generics
{
    public class GenericRepository<T>
        where T : class
    {
        public virtual void Insert(T obj)
        {
            using (DataContext d = new DataContext())
            {
                d.Entry(obj).State = EntityState.Added; //insert
                d.SaveChanges(); //Executando
            }
        }

        public virtual void Update(T obj)
        {
            using (DataContext d = new DataContext())
            {
                d.Entry(obj).State = EntityState.Modified; //Update
                d.SaveChanges(); //executando
            }
        }

        public virtual void Delete(T obj)
        {
            using (DataContext d = new DataContext())
            {
                d.Entry(obj).State = EntityState.Deleted; //Delete
                d.SaveChanges(); //Executando
            }
        }

        public virtual List<T> FindAll()
        {
            using (DataContext d = new DataContext())
            {
                return d.Set<T>().ToList(); //todos os registros..
            }
        }

        public virtual T FindById(int id)
        {
            using (DataContext d = new DataContext())
            {
                return d.Set<T>().Find(id); //buscar por id
            }
        }
    }
}
