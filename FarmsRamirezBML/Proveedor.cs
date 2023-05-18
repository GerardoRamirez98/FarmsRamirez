using Dapper;
using FarmsRamirezDAL;
using System.Collections.Generic;

namespace FarmsRamirezBML
{
    public class Proveedor
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int proveedorID { get; set; }
        public string nombreEmpresa { get; set; }
        public int codigoPostal { get; set; }
        public string estado { get; set; }
        public string ciudad { get; set; }
        public string municipio { get; set; }
        public string colonia { get; set; }
        public string calle { get; set; }
        public int nInterior { get; set; }
        public int nExterior { get; set; }
        public string celular { get; set; }
        public string telFijo { get; set; }
        public string correo { get; set; }
        public string paginaWeb { get; set; }
        public string nombreRepresentante { get; set; }
        public string correoRepresentante { get; set; }
        public string celularRepresentante { get; set; }
        public string telFijoRepresentante { get; set; }

        public Proveedor()
        {
        }

        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@nombreEmpresa", nombreEmpresa);
            parametros.Add("@codigoPostal", codigoPostal);
            parametros.Add("@estado", estado);
            parametros.Add("@ciudad", ciudad);
            parametros.Add("@municipio", municipio);
            parametros.Add("@colonia", colonia);
            parametros.Add("@calle", calle);
            parametros.Add("@nInterior", nInterior);
            parametros.Add("@nExterior", nExterior);
            parametros.Add("@celular", celular);
            parametros.Add("@telFijo", telFijo);
            parametros.Add("@correo", correo);
            parametros.Add("@paginaWeb", paginaWeb);
            parametros.Add("@nombreRepresentante", nombreRepresentante);
            parametros.Add("@correoRepresentante", correoRepresentante);
            parametros.Add("@celularRepresentante", celularRepresentante);
            parametros.Add("@telFijoRepresentante", telFijoRepresentante);
            return dataAccess.Execute("stp_proveedores_add");
        }

        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@proveedorID", proveedorID);
            return dataAccess.Execute("stp_proveedores_delete", parametros);
        }

        public List<Proveedor> GetAll()
        {
            return dataAccess.Query<Proveedor>("stp_proveedores_getall");
        }

        public Proveedor GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@proveedorID", proveedorID);
            return dataAccess.QuerySingle<Proveedor>("stp_proveedores_getbyid", parametros);
        }

        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@nombreEmpresa", nombreEmpresa);
            parametros.Add("@codigoPostal", codigoPostal);
            parametros.Add("@estado", estado);
            parametros.Add("@ciudad", ciudad);
            parametros.Add("@municipio", municipio);
            parametros.Add("@colonia", colonia);
            parametros.Add("@calle", calle);
            parametros.Add("@nInterior", nInterior);
            parametros.Add("@nExterior", nExterior);
            parametros.Add("@celular", celular);
            parametros.Add("@telFijo", telFijo);
            parametros.Add("@correo", correo);
            parametros.Add("@paginaWeb", paginaWeb);
            parametros.Add("@nombreRepresentante", nombreRepresentante);
            parametros.Add("@correoRepresentante", correoRepresentante);
            parametros.Add("@celularRepresentante", celularRepresentante);
            parametros.Add("@telFijoRepresentante", telFijoRepresentante);
            return dataAccess.Execute("stp_proveedores_update");
        }
    }
}
