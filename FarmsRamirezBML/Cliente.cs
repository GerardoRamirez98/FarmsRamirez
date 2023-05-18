using Dapper;
using FarmsRamirezDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmsRamirezBML
{
    public class Cliente
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int clienteID { get; set; }
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

        public Cliente()
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
            parametros.Add("@municipio", municipio);
            parametros.Add("@colonia", colonia);
            parametros.Add("@calle", calle);
            parametros.Add("@nInterior", nInterior);
            parametros.Add("@nExterior", nExterior);
            return dataAccess.Execute("stp_clientes_add", parametros);
        }

        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@clienteID", clienteID);
            return dataAccess.Execute("stp_clientes_delete", parametros);
        }

        public List<Cliente> GetAll()
        {
            return dataAccess.Query<Cliente>("stp_clientes_getall");
        }
        public Cliente GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@clienteID", clienteID);
            return dataAccess.QuerySingle<Cliente>("stp_clientes_getbyid", parametros);
        }

        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@clienteID", clienteID);
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
            return dataAccess.Execute("stp_clientes_update", parametros);
        }
    }
}
