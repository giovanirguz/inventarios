using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using Inventarios.Core;

namespace Inventarios.ApplicationServices.Impl
{
    public class ClienteService : IClienteService
    {
        readonly AlmacenORMDataContext almacenOrmDataContext;

        public ClienteService(AlmacenORMDataContext almacenOrmDataContext)
        {
            this.almacenOrmDataContext = almacenOrmDataContext;
        }

        public Cliente GetClienteById(int id)
        {
            return (almacenOrmDataContext.Clientes.Single(x=>x.Id == id));
        }

        public Cliente[] GetAllClientes()
        {
            return (from c in almacenOrmDataContext.Clientes select c).ToArray();
        }

        public Cliente[] GetClientesByName(string name)
        {
            return (from c in almacenOrmDataContext.Clientes
                    where c.Nombre.Contains(name)
                    orderby c.Nombre
                    select c).ToArray();
        }

        public void Save(Cliente cliente, bool isUpdate)
        {
            Cliente oldCliente;

            if (isUpdate)
            {
                oldCliente = (almacenOrmDataContext.Clientes.First(x => x.NoControl == cliente.NoControl));

                oldCliente.Nombre = cliente.Nombre;
                oldCliente.RFC = cliente.RFC;
                oldCliente.Direccion = cliente.Direccion;
                oldCliente.Telefono = cliente.Telefono;
            }
            else
                almacenOrmDataContext.Clientes.InsertOnSubmit(cliente);


            almacenOrmDataContext.SubmitChanges(ConflictMode.FailOnFirstConflict);
        }
    }
}