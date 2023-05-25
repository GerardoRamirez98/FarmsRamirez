using Dapper;
using FarmsRamirezDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmsRamirezBML
{
    public class Permisos
    {
        private static DataAccess dataAccess = DataAccess.Instance();
        public int rolID {  get; set; }
        public int permisosID {  get; set; }
        public string Menu { get; set; }
        public string SubMenu { get; set; }
        public bool status { get; set; }

        public Permisos()
        {
        }

        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@Menu", Menu);
            parametros.Add("@SubMenu", SubMenu);

            return dataAccess.Execute("stp_permisos_agregar", parametros);
        }

        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@permisosID", permisosID);
            return dataAccess.Execute("stp_permisos_delete", parametros);
        }
        public static List<Permisos> GetAll(int rolID)
        //public List<Permisos> GetAll(int rolID)
        {
            var parametros = new DynamicParameters();
            parametros.Add("@rolID", rolID);
            return dataAccess.Query<Permisos>("stp_permisos_getall");
        }

        public Permisos GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@permisosID", permisosID);
            return dataAccess.QuerySingle<Permisos>("stp_permisos_getbyid", parametros);
        }

        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@Menu", Menu);
            parametros.Add("@SubMenu",SubMenu);
            return dataAccess.Execute("stp_permisos_update");
        }
    }
}
