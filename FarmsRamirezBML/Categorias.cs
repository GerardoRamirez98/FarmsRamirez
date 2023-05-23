using Dapper;
using FarmsRamirezDAL;
using System;
using System.Collections.Generic;

namespace FarmsRamirezBML
{
    public class Categorias
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int categoriaID { get; set; }
        public string descripcion { get; set; }
        public bool status { get; set; }
        public DateTime fechaRegistro { get; set; }

        public Categorias()
        {
        }

        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@descripcion", descripcion);

            return dataAccess.Execute("stp_categorias_agregar", parametros);
        }

        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@categoriaID", categoriaID);
            return dataAccess.Execute("stp_categorias_delete", parametros);
        }

        public List<Categorias> GetAll()
        {
            return dataAccess.Query<Categorias>("stp_categorias_getall");
        }

        public Categorias GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@descripcion", descripcion);
            return dataAccess.QuerySingle<Categorias>("stp_categorias_getbyid", parametros);
        }

        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@descripcion", descripcion);
            return dataAccess.Execute("stp_categoria_update", parametros);
        }
    }
}
