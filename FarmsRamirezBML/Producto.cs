using Dapper;
using FarmsRamirezDAL;
using System;
using System.Collections.Generic;

namespace FarmsRamirezBML
{
    public class Producto
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public string CodigoBarra { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string UnidadMedida { get; set; }
        public decimal PrecioCompra { get; set; }
        public int MargenGanancia { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int StockMin { get; set; }
        public int StockMax { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Producto()
        {
        }

        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@Codigo", Codigo);
            parametros.Add("@CodigoBarra", CodigoBarra);
            parametros.Add("@Nombre", Nombre);
            parametros.Add("@Descripcion", Descripcion);
            parametros.Add("@Marca", Marca);
            parametros.Add("@UnidadMedida", UnidadMedida);
            parametros.Add("@PrecioCompra", PrecioCompra);
            parametros.Add("@MargenGanancia", MargenGanancia);
            parametros.Add("@PrecioVenta", PrecioVenta);
            parametros.Add("@Stock", Stock);
            parametros.Add("@StockMin", StockMin);
            parametros.Add("@StockMax", StockMax);
            
            return dataAccess.Execute("stp_productos_agregar", parametros);
        }

        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@IdProducto", IdProducto);
            return dataAccess.Execute("stp_producto_delete", parametros);
        }

        public List<Producto> GetAll()
        {
            return dataAccess.Query<Producto>("stp_productos_getall");
        }

        public Producto GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@IdProducto", IdProducto);
            return dataAccess.QuerySingle<Producto>("stp_producto_getbyid", parametros);
        }

        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@IdProducto", IdProducto);
            parametros.Add("@Codigo", Codigo);
            parametros.Add("@CodigoBarra", CodigoBarra);
            parametros.Add("@Nombre", Nombre);
            parametros.Add("@Descripcion", Descripcion);
            parametros.Add("@Marca", Marca);
            parametros.Add("@UnidadMedida", UnidadMedida);
            parametros.Add("@PrecioCompra", PrecioCompra);
            parametros.Add("@MargenGanancia", MargenGanancia);
            parametros.Add("@PrecioVenta", PrecioVenta);
            parametros.Add("@Stock", Stock);
            parametros.Add("@StockMin", StockMin);
            parametros.Add("@StockMax", StockMax);
            return dataAccess.Execute("stp_producto_update", parametros);
        }

    }
}
