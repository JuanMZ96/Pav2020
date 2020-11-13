using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using static Pav2.Logica.CustomClass;

namespace Pav2.Logica
{
    class UsuarioxCursoAvance
    {
        public static ReturnValue GuardarUsuarioxCursoAvance(int idusuario, int idcurso, DateTime FechaAhora, DateTime fechafin, int porcentaje) {
            ReturnValue validador = new ReturnValue() { isSuccess = false };
            UsuariosCursoAvance AvanceNuevo = new UsuariosCursoAvance();
            using (var context = new BugTrackerFinalEntities())
            {
                try {
                    var usuarioCurso = context.UsuariosCursos.Where(x => x.id_usuario == idusuario &&
                                                                         x.id_curso == idcurso && 
                                                                         x.borrado == false).FirstOrDefault();
                    if(usuarioCurso != null)
                    {
                        var check = context.UsuariosCursoAvances.Where(x => x.id_usuario == idusuario &&
                                                                                     x.id_curso == idcurso).ToList();
                        ReturnValue check2 = validarPorcentaje(check, porcentaje);
                        ReturnValue check3 = validarFechas(usuarioCurso, FechaAhora);
                        if (check3.isSuccess)
                        {
                            if (check2.isSuccess)
                            {
                                AvanceNuevo.id_usuario = idusuario;
                                AvanceNuevo.id_curso = idcurso;
                                AvanceNuevo.inicio = FechaAhora;
                                AvanceNuevo.fin = fechafin;
                                AvanceNuevo.porc_avance = porcentaje;
                                AvanceNuevo.borrado = false;
                                context.UsuariosCursoAvances.Add(AvanceNuevo);
                                context.SaveChanges();
                                validador.isSuccess = true;
                            }
                            else { validador.ErrorMessage = check2.ErrorMessage; }
                        }
                        else { validador.ErrorMessage = check3.ErrorMessage; }
                    }
                    else { validador.ErrorMessage = "No existe ese usuario para ese curso"; }
                }
                catch (Exception ex) { validador.ErrorMessage = ex.Message; }
            }
            return validador;
        }
        public static ReturnValue validarPorcentaje( List<UsuariosCursoAvance> clase, int porcentaje)
        {
            
            ReturnValue validador = new ReturnValue() { isSuccess = true };
            if (porcentaje > 100) 
            { validador.isSuccess = false; validador.ErrorMessage = "El porcentaje cargado es mayor a 100";
                return validador;
            }
            foreach (var item in clase)
            {
                if(item.porc_avance == porcentaje) { validador.isSuccess = false; validador.ErrorMessage = "Ese porcentaje ya esta cargado"; break; }
                if(item.porc_avance > porcentaje) 
                {
                    validador.isSuccess = false; validador.ErrorMessage = "El porcentaje cargado es menor a los que hay"; break;
                }
            }
            return validador;

        }

        public static ReturnValue validarFechas(dynamic clase, DateTime fechaAhora) {
            ReturnValue validador = new ReturnValue { isSuccess = true };
            int resultado = DateTime.Compare(fechaAhora, (DateTime)clase.fecha_fin);
            if(resultado >= 0)
            {
                validador.isSuccess = false;
                validador.ErrorMessage = "El curso ya termino";
            }
            return validador;
        }
        public static List<UsuarioxCursoAvanceCustom> MostrarGrilla(int idUsuario, int idCurso) 
        {
            using (var Contex = new BugTrackerFinalEntities()){
                var lista = from avance in Contex.UsuariosCursoAvances
                            join usuarios in Contex.Usuarios
                            on avance.id_usuario equals usuarios.id_usuario
                            join cursos in Contex.Cursos
                            on avance.id_curso equals cursos.id_curso
                            where avance.id_usuario == idUsuario &&
                                  avance.id_curso == idCurso
                            select new UsuarioxCursoAvanceCustom()
                            {
                                id_usuario = avance.id_usuario,
                                id_curso = avance.id_curso,
                                Usuario = usuarios.usuario1,
                                Curso = cursos.nombre,
                                porcentaje = (int)avance.porc_avance,
                                fecha_inicio = (DateTime)avance.inicio,
                                fecha_fin = (DateTime)avance.fin,
                                borrado = (bool)avance.borrado,
                               
                            };

                return lista.ToList();
            }
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
                        var check = context.UsuariosCursoAvances.Where(x => x.id_usuario == idusuario &&
                                                                                      x.id_curso == idcurso).ToList();
                        ReturnValue check2 = validarPorcentaje(check, porcentaje);
                        if (check2.isSuccess)
                        {
                            if (AvanceModificar != null)
                            {
                                if (AvanceModificar.porc_avance != porcentaje) AvanceModificar.porc_avance = porcentaje;
                                context.SaveChanges();
                                validador.isSuccess = true;
                            }
                            else { validador.ErrorMessage = "No existe ese Avance"; }
                        }
                        else validador.ErrorMessage = check2.ErrorMessage;
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
