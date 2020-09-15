using ClassLibrary1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;


namespace Pav2.Logica
{
    public class Usuarios
    {
        public static bool ValidarCredenciales(string nameUsuario, string pwdUsuario)

        {
            bool User = false;

            using (var Contex = new BugTrackerFinalEntities())
            {
                var q = Contex.Usuarios.Where(x => x.usuario1 == nameUsuario).FirstOrDefault();
                if (q != null)
                {
                    User = q.password == pwdUsuario;


                }


            }

            return User;

        }

        public static bool CrearUsuarios(int perfil, string name, string pw, String mail)
        {
            bool user = false;
            Usuario user1 = new Usuario();



            using (var Contex = new BugTrackerFinalEntities())
            {

                
                {

                    if (name != String.Empty && pw != String.Empty && mail != String.Empty)
                    {

                        //int id = Int32.Parse(perfil);
                        user1.usuario1 = name;
                        user1.password = pw;
                        user1.id_perfil = perfil;
                        user1.email = mail;
                        user1.estado = "S";
                        user1.borrado = false;
                        Contex.Usuarios.Add(user1);
                        Contex.SaveChanges();


                        user = true;
                    }
                    
                    
                }
                

            }

            return user;

        }



        public static IList MostrarCombo()
        {

            List<Perfiles> ListPerfil = new List<Perfiles>();

            using ( var Contex = new BugTrackerFinalEntities())
            {
                ListPerfil = (from d in Contex.Perfiles
                              select new Perfiles
                              {
                                  id = d.id_perfil,
                                  nombre = d.nombre
                              }).ToList();


            }

            return ListPerfil;

        }

    }

    
}
