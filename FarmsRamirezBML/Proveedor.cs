using Dapper;
using FarmsRamirezDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmsRamirezBML
{
    public class Proveedor
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int proveedorID { get; set; }
        public string nombres { get; set; }
        public string apellidoP { get; set; }
        public string apellidoM { get; set; }
        public string celular { get; set; }
        public string telFijo { get; set; }
        public string correo { get; set; }
        public string codigoPostal { get; set; }
        public string estado { get; set; }
        public string ciudad { get; set; }
        public string municipio { get; set; }
        public string colonia { get; set; }
        public string calle { get; set; }
        public string nInterior { get; set; }
        public string nExterior { get; set; }
        public bool status { get; set; }

        public Proveedor()
        { 
        }

        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@nombre", nombres);
            parametros.Add("@apellidoP", apellidoP);
            parametros.Add("@apellidoM", apellidoM);
            parametros.Add("@celular", celular);
            parametros.Add("@telFijo", telFijo);
            parametros.Add("@correo", correo);
            parametros.Add("@codigoPostal", codigoPostal);
            parametros.Add("@estado", estado);
            parametros.Add("@ciudad", ciudad);
            parametros.Add("@municipio",municipio);
            parametros.Add("@colonia",colonia);
            parametros.Add("@calle",calle);
            parametros.Add("@nInterior",nInterior);
            parametros.Add("@nExterior",nExterior);
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
            parametros.Add("@proveedorID", proveedorID);
            parametros.Add("@nombre", nombres);
            parametros.Add("@apellidoP", apellidoP);
            parametros.Add("@apellidoM", apellidoM);
            parametros.Add("@celular", celular);
            parametros.Add("@telFijo", telFijo);
            parametros.Add("@correo", correo);
            parametros.Add("@codigoPostal", codigoPostal);
            parametros.Add("@estado", estado);
            parametros.Add("@ciudad", ciudad);
            parametros.Add("@municipio", municipio);
            parametros.Add("@colonia", colonia);
            parametros.Add("@calle", calle);
            parametros.Add("@nInterior", nInterior);
            parametros.Add("@nExterior", nExterior);
            return dataAccess.Execute("stp_proveedores_update");
        }
    }
}
