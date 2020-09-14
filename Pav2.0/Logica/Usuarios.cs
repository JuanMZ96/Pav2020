using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pav2.Logica
{
    public class Usuarios
    {
        public static bool ValidarCredenciales(string namneUsuario, string pwdUsuario)

        {
            bool User = false;

            using (var Contex = new BugTrackerFinalEntities())
            {
                var q = Contex.Usuarios.Where(x => x.usuario1 == namneUsuario).FirstOrDefault();
                if (q != null)
                {
                    User = q.password == pwdUsuario;


                }


            }

            return User;

        }

        public static bool CrearUsuarios(string name, string pw)
        {
            bool user = false;

            using (var Contex = new BugTrackerFinalEntities())
            {




            }

            return user;

        }


    }

    
}
