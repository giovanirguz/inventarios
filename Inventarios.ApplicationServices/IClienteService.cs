using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventarios.Core;

namespace Inventarios.ApplicationServices
{
    public interface IClienteService
    {
        Cliente GetClienteById(int id);
        Cliente[] GetAllClientes();
        Cliente[] GetClientesByName(string name);
        void Save(Cliente cliente, bool isUpdate);
    }
}
