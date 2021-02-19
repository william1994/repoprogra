using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using William01.DAO;
using William01.DOMINIO;

namespace William01.NEGOCIO
{
    class ClsLogin
    {

        ClsListaUsuario cls = new ClsListaUsuario();

        
        public int acceso(Login log)
        {
            int estado = 0;
            for (int i=0;i< cls.user.Length;i++) { 
            if (log.Usuario.Equals(cls.user[i]) && log.Password.Equals(cls.pass[i])) {
                estado = 1;
            }
            }
            return estado;
        }
        
    }
}
