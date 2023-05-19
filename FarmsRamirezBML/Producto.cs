using Dapper;
using FarmsRamirezDAL;
using System.Collections.Generic;

namespace FarmsRamirezBML
{
    public class Producto
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int productoID { get; set; }
        public string codigo { get; set; }
        public string codigoBarra { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string marca { get; set; }
        public string unidadMedida { get; set; }
        public decimal precioCompra { get; set; }
        public int margenGanancia { get; set; }
        public decimal precioVenta { get; set; }
        public int stock { get; set; }
        public int stockMin { get; set; }
        public int stockMax { get; set; }        
        public bool status { get; set; }

        public Producto()
        {
        }

        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("codigo", codigo);
            parametros.Add("codigoBarra", codigoBarra);
            parametros.Add("nombre", nombre);
            parametros.Add("@descripcion", descripcion);
            parametros.Add("@marca", marca);
            parametros.Add("@unidadMedida", unidadMedida);
            parametros.Add("@precioCompra", precioCompra);
            parametros.Add("@margenGanancia", margenGanancia);
            parametros.Add("@precioVenta", precioVenta);
            parametros.Add("@stock", stock);
            parametros.Add("@stockMin", stockMin);
            parametros.Add("@stockMax", stockMax);
            
            return dataAccess.Execute("stp_productos_agregar", parametros);
        }

        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@productoID", productoID);
            return dataAccess.Execute("stp_producto_delete", parametros);
        }

        public List<Producto> GetAll()
        {
            return dataAccess.Query<Producto>("stp_productos_getall");
        }

        public Producto GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@productoID", productoID);
            return dataAccess.QuerySingle<Producto>("stp_producto_getbyid", parametros);
        }

        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("productoID", productoID);
            parametros.Add("codigo", codigo);
            parametros.Add("codigoBarra", codigoBarra);
            parametros.Add("nombre", nombre);
            parametros.Add("@descripcion", descripcion);
            parametros.Add("@marca", marca);
            parametros.Add("@unidadMedida", unidadMedida);
            parametros.Add("@precioCompra", precioCompra);
            parametros.Add("@margenGanancia", margenGanancia);
            parametros.Add("@precioVenta", precioVenta);
            parametros.Add("@stock", stock);
            parametros.Add("@stockMin", stockMin);
            parametros.Add("@stockMax", stockMax);
            return dataAccess.Execute("stp_producto_update", parametros);
        }

    }
}
