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
        private DataAccess dataAccess = DataAccess.Instance();
        public int permisosID {  get; set; }
        public int Menu { get; set; }
        public int SubMenu { get; set; }
        public bool status { get; set; }

        public Permisos()
        {
        }

        public List<Permisos> GetAll()
        {
            return dataAccess.Query<Permisos>("stp_permisos_getall");
        }
    }
}
