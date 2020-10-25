using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav2.Logica
{
    class UsuariosxCurso
    {
        public static ReturnValue GuardarUsuariosxCurso(int id_curso, int id_usuario, int puntuacion, string observaciones, DateTime fecha_inicio, DateTime fecha_fin)
        {

            ReturnValue validador = new ReturnValue() { isSuccess = false };
            UsuariosCurso usuariocurso = new UsuariosCurso();
            using (var Contex = new BugTrackerFinalEntities())
            {
                try
                {
                    var cursos = Contex.Cursos.Where(x => x.id_curso == id_curso && x.borrado == false).FirstOrDefault();
                    var usuarios = Contex.Usuarios.Where(x => x.id_usuario == id_usuario && x.borrado == false).FirstOrDefault();
                    if (cursos != null && usuarios != null)
                    {
                        var cursos1 = Contex.UsuariosCursoes.Where(x => x.id_curso == id_curso
                                                                   && x.id_usuario == id_usuario).FirstOrDefault();
                        if (cursos1 == null)
                        {
                            //seteo USUARIOCURSO que es la entidad con los get y set
                            usuariocurso.id_curso = id_curso;
                            usuariocurso.id_usuario = id_usuario;
                            usuariocurso.puntuacion = puntuacion;
                            usuariocurso.observaciones = observaciones;
                            usuariocurso.fecha_inicio = fecha_inicio;
                            usuariocurso.fecha_fin = fecha_fin;
                            Contex.UsuariosCursoes.Add(usuariocurso);
                            Contex.SaveChanges();
                            validador.isSuccess = true;
                        }
                        else { validador.ErrorMessage = "Ya existe el usuario para ese curso"; }
                    }
                    else { validador.ErrorMessage = "Ya existen esos datos"; }
                }
                catch (Exception ex)
                {
                    validador.ErrorMessage = ex.Message;
                }
            }
            return validador;
        }
    
    }
}
