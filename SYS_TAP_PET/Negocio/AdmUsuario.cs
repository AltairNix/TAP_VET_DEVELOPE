using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Entidad;

namespace Negocio
{
    public class AdmUsuario
    {
        private DaoUsuario objUsuario;

        public AdmUsuario()
        {
            objUsuario = new DaoUsuario();
        }

        public void create(Usuario objUsuario)
        {
            //validar id_Usuario


            //validar nombre usuario


            //
        }
    }
}
