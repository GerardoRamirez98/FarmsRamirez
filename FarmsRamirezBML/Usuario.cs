using Dapper;
using FarmsRamirezDAL;
using System.Collections.Generic;

namespace FarmsRamirezBML
{
    public class Usuario
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idUsuario { get; set; }
        public string Nombre { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int idTipoUsuario { get; set; }
        public bool Activo { get; set; }

        public Usuario()
        {
        }

        public Usuario Login()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@Username", Username);
            parametros.Add("@Password", Password);
            return dataAccess.QuerySingleOrDefault<Usuario>("stp_usuarios_login", parametros);
        }

        public List<Usuario> GetAll()
        {
            return dataAccess.Query<Usuario>("stp_usuario_getall");
        }

        public Usuario GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@IdUsuario", idUsuario);
            return dataAccess.QuerySingle<Usuario>("stp_usuario_getbyid", parametros);
        }

        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@IdUsuario", idUsuario);
            return dataAccess.Execute("stp_usuario_delete", parametros);
        }

        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@Nombre", Nombre);
            parametros.Add("@Username", Username);
            parametros.Add("@Password", Password);

            return dataAccess.Execute("stp_usuario_update");
        }

        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@Nombre", Nombre);
            parametros.Add("@Username", Username);
            parametros.Add("@Password", Password);

            return dataAccess.Execute("stp_usuario_update");
        }
    }
}
