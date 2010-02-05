using System.Data.Linq;
using System.Linq;
using Inventarios.Core;

namespace Inventarios.ApplicationServices.Impl
{
    public class ProductoService : IProductoService
    {
        readonly AlmacenORMDataContext almacenOrmDataContext;

        public ProductoService(AlmacenORMDataContext almacenOrmDataContext)
        {
            this.almacenOrmDataContext = almacenOrmDataContext;
        }

        public Producto GetProductoById(int id)
        {
            return (almacenOrmDataContext.Productos.Single(x => x.Id == id));
        }

        public Producto[] GetAllProductos()
        {
            return (from c in almacenOrmDataContext.Productos select c).ToArray();
        }

        public Producto[] GetProductosByName(string name)
        {
            return (from c in almacenOrmDataContext.Productos
                    where c.Nombre.Contains(name)
                    orderby c.Nombre
                    select c).ToArray();
        }

        public void Save(Producto producto, bool isUpdate)
        {
            Producto oldProducto;

            if (isUpdate)
            {
                oldProducto = (almacenOrmDataContext.Productos.First(x => x.Codigo == producto.Codigo));
                
                oldProducto.Nombre = producto.Nombre;
                
            }

            else
                almacenOrmDataContext.Productos.InsertOnSubmit(producto);


            almacenOrmDataContext.SubmitChanges(ConflictMode.FailOnFirstConflict);
        }
    }
}