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
        public int idCliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string razonSocial { get; set; }
        public string telefono { get; set; }
        public decimal descuento { get; set; }
        public bool activo { get; set; }

        public Cliente()
        {
        }

        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@nombre", nombre);
            parametros.Add("@apellido", apellido);
            parametros.Add("@razonSocial", razonSocial);
            parametros.Add("@telefono", telefono);
            parametros.Add("@descuento", descuento);
            return dataAccess.Execute("stp_clientes_add", parametros);
        }

        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idCliente", idCliente);
            return dataAccess.Execute("stp_clientes_delete", parametros);
        }

        public List<Cliente> GetAll()
        {
            return dataAccess.Query<Cliente>("stp_clientes_getall");
        }
        public Cliente GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idCliente", idCliente);
            return dataAccess.QuerySingle<Cliente>("stp_clientes_getbyid", parametros);
        }

        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idCliente", idCliente);
            parametros.Add("@nombre", nombre);
            parametros.Add("@apellido", apellido);
            parametros.Add("@razonSocial", razonSocial);
            parametros.Add("@telefono", telefono);
            parametros.Add("@descuento", descuento);
            return dataAccess.Execute("stp_clientes_update", parametros);
        }
    }
}
