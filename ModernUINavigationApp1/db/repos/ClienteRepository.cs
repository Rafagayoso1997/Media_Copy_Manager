using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCP.db.repos
{
    public class ClientesRepository : IRepository<cliente>
    {

        public ClientesRepository()
        {

        }

        public List<cliente> List
        {
            get
            {
                return DBManager.Context.clientes.OrderBy(c => c.id_cliente).ToList();
            }
        }

        public cliente Add(cliente entity)
        {
            cliente cliente = DBManager.Context.clientes.Add(entity);
            DBManager.Context.SaveChanges();

            return cliente;
        }

        public void Delete(int Id)
        {
            DBManager.Context.clientes.Remove(FindById(Id));
            DBManager.Context.SaveChanges();
        }

        public cliente FindById(int Id)
        {
            cliente cliente = (from c in DBManager.Context.clientes
                               where c.id_cliente == Id
                               select c).FirstOrDefault();
            return cliente;

        }

        public void Update(cliente entity)
        {
            DBManager.Context.Entry(entity).State = EntityState.Modified;
            DBManager.Context.SaveChanges();
        }

        public cliente FindByName(string completeName)
        {
            string[] splitName = completeName.Split(' ');
            string nombre = splitName[0];
            string apellido = splitName[1];
            cliente cliente = (from c in DBManager.Context.clientes
                               where c.nombre_cliente == nombre && c.apellidos_cliente == apellido 
                               select c).FirstOrDefault();
            return cliente;

        }

        public List<string> ListDistinctCategValues()
        {
            return (from r in DBManager.Context.clientes
                    select r.nombre_cliente).Distinct().ToList();
        }

    }
}
