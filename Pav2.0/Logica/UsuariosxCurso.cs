using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Pav2.Logica.CustomClass;

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
                            usuariocurso.borrado = false;
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
        //Veer
        public static List<UsuarioxCursoCustom> MostrarGrilla(bool borrado, int usuario)
        {
            using (var Contex = new BugTrackerFinalEntities())
            {
                var lista = from Usuario in Contex.UsuariosCursoes
                            where Usuario.id_usuario == usuario
                            select Usuario;
                if (!borrado)
                {
                    lista = lista.Where(x => (bool)x.borrado == false);
                }
                var temp = lista.Join(Contex.Cursos,
                    UsuariosCurso => UsuariosCurso.id_curso,
                    Curso => Curso.id_curso,
                    (UsuariosCurso, Curso) => new UsuarioxCursoCustom()
                    {
                        id_usuario = UsuariosCurso.id_usuario,
                        id_curso = UsuariosCurso.id_curso,
                        nombre = Curso.nombre,
                        puntuacion = (int)UsuariosCurso.puntuacion,
                        observaciones = UsuariosCurso.observaciones,
                        fecha_inicio = (DateTime)UsuariosCurso.fecha_inicio,
                        fecha_fin = (DateTime)UsuariosCurso.fecha_fin,
                        borrado = (bool)UsuariosCurso.borrado


                    });
                return temp.ToList();
            }

        }
        public static ReturnValue EliminarUsuariosxCurso(int idcurso, int idusuario, bool borrado)
        {
            ReturnValue var1 = new ReturnValue() { isSuccess = false };
            using (var Contex = new BugTrackerFinalEntities())
            {
                try
                {
                    if (borrado == false)
                    {
                        var UsuarioCurso = Contex.UsuariosCursoes.Where(x => x.id_curso == idcurso
                                                                   && x.id_usuario == idusuario).FirstOrDefault();
                        if (UsuarioCurso != null)
                        {
                            UsuarioCurso.borrado = true;
                            Contex.SaveChanges();
                            var1.isSuccess = true;

                        }
                    }
                    else
                    {
                        var UsuarioCurso = Contex.UsuariosCursoes.Where(x => x.id_curso == idcurso
                                                                   && x.id_usuario == idusuario).FirstOrDefault();

                        Contex.UsuariosCursoes.Remove(UsuarioCurso);
                        Contex.SaveChanges();
                        var1.isSuccess = true;

                    }
                }
                catch (Exception ex) { var1.ErrorMessage = ex.Message; }

            }
            return var1;

        }

        public static ReturnValue ModificarUsuariosxCurso(int idcurso, int idusuario, int puntuacion, string observaciones, DateTime fechaInicio, DateTime fechaFin)
        {
            ReturnValue validador = new ReturnValue() { isSuccess = false };
            using (var Contex = new BugTrackerFinalEntities())
            {
                try
                {
                    var curso = Contex.Cursos.Where(x => x.id_curso == idcurso && x.borrado == false).FirstOrDefault();
                    var usuario = Contex.Usuarios.Where(x => x.id_usuario == idusuario && x.borrado == false).FirstOrDefault();
                    if (curso != null && usuario != null)
                    {
                        var cursos1 = Contex.UsuariosCursoes.Where(x => x.id_usuario == idusuario && x.id_curso == idcurso).FirstOrDefault();

                        if (cursos1 != null)
                        {
                            //seteo cursos1 que es la entidad con los get y set
                            if (cursos1.puntuacion != puntuacion) cursos1.puntuacion = puntuacion;
                            if (cursos1.observaciones != observaciones) cursos1.observaciones = observaciones;
                            if (cursos1.fecha_inicio != fechaInicio) cursos1.fecha_inicio = fechaInicio;
                            if (cursos1.fecha_fin != fechaFin) cursos1.fecha_fin = fechaFin;
                            Contex.SaveChanges();
                            validador.isSuccess = true;
                        }
                        else { validador.ErrorMessage = "El usuario no existe en el curso."; }
                    }
                    else { validador.ErrorMessage = "El usuario o curso seleccionado no exsite."; }
                }
                catch (Exception ex)
                {
                    validador.ErrorMessage = ex.Message;
                }
            }
            return validador;
        }
        public static ReturnValue HabilitarUsuarioCurso(int idcurso, int idusuario,bool borrado)
        {
            ReturnValue validador = new ReturnValue() { isSuccess = false };
            using (var Contex = new BugTrackerFinalEntities())
            {
                try
                {
                    var curso = Contex.Cursos.Where(x => x.id_curso == idcurso && x.borrado == false).FirstOrDefault();
                    var usuario = Contex.Usuarios.Where(x => x.id_usuario == idusuario && x.borrado == false).FirstOrDefault();
                    if (curso != null && usuario != null)
                    {
                        var cursos1 = Contex.UsuariosCursoes.Where(x => x.id_usuario == idusuario && x.id_curso == idcurso).FirstOrDefault();

                        if (cursos1 != null)
                        {
                            if (cursos1.borrado != borrado) cursos1.borrado = borrado;
                            Contex.SaveChanges();
                            validador.isSuccess = true;
                        }
                        else { validador.ErrorMessage = "El curso que quiere habilitar no existe."; }
                    }
                    else { validador.ErrorMessage = "Seleccionar el curso correcto."; }
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
