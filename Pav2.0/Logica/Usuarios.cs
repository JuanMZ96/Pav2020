using ClassLibrary1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;
using System.Data.Entity;
using System.Windows.Forms;
using static Pav2.Logica.CustomClass;

namespace Pav2.Logica
{
    public class Usuarios
    {
        public static ReturnValue<CustomClass.UsuarioCustom> ValidarCredenciales(string nameUsuario, string pwdUsuario)
        {
            ReturnValue<CustomClass.UsuarioCustom> var1 = new ReturnValue<CustomClass.UsuarioCustom>() {isSuccess=false};
            using (var Contex = new BugTrackerFinalEntities())
            {
                try {
                    var user = Contex.Usuarios.Where(x => x.usuario1 == nameUsuario);
                    var temp = user.Join(Contex.Perfiles,
                                        usuario => usuario.id_perfil,
                                        perfil => perfil.id_perfil,
                                        (usuario, perfil) => new UsuarioCustom()
                                        {
                                            id_perfil = perfil.id_perfil,
                                            id_usuario = usuario.id_usuario,
                                            perfil = perfil.nombre,
                                            usuario = usuario.usuario1,
                                            passw = usuario.password,
                                            mail = usuario.email,
                                            borrado = (bool)usuario.borrado
                                        }).FirstOrDefault();
                    if (user != null)
                    {
                        if (!(bool)temp.borrado)
                        {
                            if (temp.passw== pwdUsuario)
                            {
                                var1.isSuccess = true;
                                var1.Data = temp;
                            }
                            else { var1.ErrorMessage = "Contraseña Incorrecta"; }
                        }
                        else
                        { var1.ErrorMessage = "Usuario no habilitado";}
                    }
                    else { var1.ErrorMessage = "Usuario no encontrado";}
                }
                catch(Exception ex) {
                    var1.ErrorMessage = ex.Message;
                }
            }
            return var1;
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

        public static List<Usuario> MostrarDataUsuarios(bool estado)
        {
            if (estado == false)
            {
                var Contex = new BugTrackerFinalEntities();
                var lista = from Usuarios in Contex.Usuarios
                            where Usuarios.borrado != true
                            select Usuarios;
                return lista.ToList();

            }
            else
            {
                var Contex = new BugTrackerFinalEntities();
                var lista = from Usuarios in Contex.Usuarios

                            select Usuarios;
                return lista.ToList();
            }
        }
        ///
        public static List<UsuarioCustom> MostarDatosUsuarioCustom(bool borrado)
        {
            using (var contex = new BugTrackerFinalEntities())
            {
                var lista = from Usuarios in contex.Usuarios
                            select Usuarios;
                if (!borrado)
                {
                    lista = lista.Where(x => (bool)x.borrado == false);
                }
                var temp = lista.Join(contex.Perfiles,
                    usuario => usuario.id_perfil,
                    perfil => perfil.id_perfil,
                    (usuario,perfil) => new UsuarioCustom() {
                        id_perfil = perfil.id_perfil, 
                        id_usuario = usuario.id_usuario,
                        perfil = perfil.nombre,
                        usuario= usuario.usuario1, 
                        passw = usuario.password, 
                        mail = usuario.email, 
                        borrado = (bool)usuario.borrado 
                    });
                return temp.ToList();
            }
        }
        public static bool EliminarUsuario(int id, bool borrado)
        {
            bool eliminar = false;

            using (var Contex = new BugTrackerFinalEntities())
            {
                if (borrado == false)
                {
                    var q = Contex.Usuarios.Where(x => x.id_usuario == id).FirstOrDefault();
                    if (q != null)
                    {
                        q.borrado = true;
                        Contex.SaveChanges();
                        eliminar = true;
                    }
                }
                else
                {
                    var q = Contex.Usuarios.Where(x => x.id_usuario == id).FirstOrDefault();
                    Contex.Usuarios.Remove(q);
                    Contex.SaveChanges();
                    eliminar = true;
                }
            }
            return eliminar;
        }
        public static bool ModificarUsuario(int idperfil, int id, bool estado, string name, string password, string mail)
        {
            bool modificar = false;

            using (var Contex = new BugTrackerFinalEntities())
            {
                var q = Contex.Usuarios.Where(x => x.id_usuario == id).FirstOrDefault();

                if (q.id_perfil != idperfil)
                    q.id_perfil = idperfil;

                if (q.usuario1 != name)
                    q.usuario1 = name;
               
                if (q.password != password)
                    q.password = password;

                if (q.borrado != estado)
                    q.borrado = estado;

                Contex.SaveChanges();
                modificar = true;
            }

            return modificar;

        }

    }
}
