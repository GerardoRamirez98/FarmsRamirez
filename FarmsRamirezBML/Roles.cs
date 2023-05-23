using Dapper;
using FarmsRamirezDAL;
using System;
using System.Collections.Generic;

namespace FarmsRamirezBML
{
    public class Roles
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int rolID { get; set; }
        public string descripcion { get; set; }
        public bool status { get; set; }
        public DateTime fechaRegistro { get; set; }

        public Roles()
        {
        }

        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@descripcion", descripcion);

            return dataAccess.Execute("stp_rol_agregar, parametros");
        }

        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@rolID", rolID);
            return dataAccess.Execute("stp_rol_delete", parametros);
        }

        public List<Roles> GetAll()
        {
            return dataAccess.Query<Roles>("stp_rol_getall");
        }

        public Roles GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@rolID", rolID);
            return dataAccess.QuerySingle<Roles>("stp_rol_getbyid", parametros);
        }

        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@descripcion", descripcion);
            return dataAccess.Execute("stp_rol_update");
        }
    }
}
