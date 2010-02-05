using Inventarios.Core;

namespace Inventarios.ApplicationServices
{
    public interface IProductoService
    {
        Producto GetProductoById(int id);
        Producto[] GetAllProductos();
        Producto[] GetProductosByName(string name);
        void Save(Producto producto, bool isUpdate);
    }
}