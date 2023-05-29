using Dapper;
using FarmsRamirezDAL;
using System;
using System.Collections.Generic;

namespace FarmsRamirezBML
{
    public class Roles
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int IdTipoUsuario { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Roles()
        {
        }

        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@Descripcion", Descripcion);

            return dataAccess.Execute("stp_roles_agregar, parametros");
        }

        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@IdTipoUsuario", IdTipoUsuario);
            return dataAccess.Execute("stp_roles_delete", parametros);
        }

        public List<Roles> GetAll()
        {
            return dataAccess.Query<Roles>("stp_roles_getall");
        }

        public Roles GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@IdTipoUsuario", IdTipoUsuario);
            return dataAccess.QuerySingle<Roles>("stp_roles_getbyid", parametros);
        }

        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@descripcion", Descripcion);
            return dataAccess.Execute("stp_roles_update");
        }
    }
}
