using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pav2.Logica
{
    class UsuarioxCursoAvance
    {
        public static ReturnValue GuardarUsuarioxCursoAvance(int idusuario, int idcurso, DateTime fechainicio, DateTime fechafin, int porcentaje) {
            ReturnValue validador = new ReturnValue() { isSuccess = false };
            
            using (var context = new BugTrackerFinalEntities())
            {
                try {
                    var usuario = context.Usuarios.Where(x => x.id_usuario == idusuario && x.borrado == false).FirstOrDefault();
                    var curso = context.Cursos.Where(x => x.id_curso == idcurso && x.borrado == false).FirstOrDefault();
                    if(usuario !=null && curso != null)
                    {
                        var AvanceNuevo = context.UsuariosCursoAvances.Where(x => x.id_usuario == idusuario &&
                                                                                     x.id_curso == idcurso).FirstOrDefault();
                        if(AvanceNuevo == null)
                        {
                            AvanceNuevo.id_usuario = idusuario;
                            AvanceNuevo.id_curso = idcurso;
                            AvanceNuevo.inicio = fechainicio;
                            AvanceNuevo.fin = fechafin;
                            AvanceNuevo.porc_avance = porcentaje;
                            context.UsuariosCursoAvances.Add(AvanceNuevo);
                            context.SaveChanges();
                            validador.isSuccess = true;
                        }
                        else { validador.ErrorMessage = "Erro 1"; }
                    }
                    else { validador.ErrorMessage = "No existen esos cursos y usuario"; }
                }
                catch (Exception ex) { validador.ErrorMessage = ex.Message; }
            }
            return validador;
        }
        public static ReturnValue ModificiarUsuarioxCursoAvance(int idusuario, int idcurso, DateTime fechainicio, DateTime fechafin, int porcentaje) {
            ReturnValue validador = new ReturnValue() { isSuccess = false };
            using (var context = new BugTrackerFinalEntities())
            {
                try
                {
                    var usuario = context.Usuarios.Where(x => x.id_usuario == idusuario && x.borrado == false).FirstOrDefault();
                    var curso = context.Cursos.Where(x => x.id_curso == idcurso && x.borrado == false).FirstOrDefault();
                    if (usuario != null && curso != null)
                    {
                        var AvanceModificar = context.UsuariosCursoAvances.Where(x => x.id_usuario == idusuario &&
                                                                                     x.id_curso == idcurso &&
                                                                                     x.inicio == fechainicio).FirstOrDefault();
                        if (AvanceModificar == null)
                        {
                            if (AvanceModificar.porc_avance != porcentaje) AvanceModificar.porc_avance = porcentaje;
                            context.SaveChanges();
                            validador.isSuccess = true;
                        }
                        else { validador.ErrorMessage = "Erro 1"; }
                    }
                    else { validador.ErrorMessage = "No existen esos cursos y usuario"; }
                }
                catch (Exception ex) { validador.ErrorMessage = ex.Message; }
            }
            return validador;
        }
        public static ReturnValue EliminarUsuarioxCursoAvance(int idusuario, int idcurso, DateTime fechainicio, DateTime fechafin, bool borrado)
        {
            ReturnValue validador = new ReturnValue() { isSuccess = false };
            using (var Contex = new BugTrackerFinalEntities())
            {
                try
                {
                    var Avanceeliminar = Contex.UsuariosCursoAvances.Where(x => x.id_usuario == idusuario &&
                                                                                    x.id_curso == idcurso &&
                                                                                    x.inicio == fechainicio).FirstOrDefault();
                    if (borrado == false){
                        if (Avanceeliminar != null){
                            Avanceeliminar.borrado = true;
                            Contex.SaveChanges();
                            validador.isSuccess = true;
                        }
                    }
                    else{
                        Contex.UsuariosCursoAvances.Remove(Avanceeliminar);
                        Contex.SaveChanges();
                        validador.isSuccess = true;
                    }
                }
                catch (Exception ex) { validador.ErrorMessage = ex.Message; }
            }
            return validador;
        }

    }
}
