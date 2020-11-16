using ClassLibrary1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Pav2.Logica.CustomClass;


namespace Pav2.Logica
{
    class ObjetivosxCurso
    {
        public static ReturnValue GuardarObjetivosxCurso(int idcurso, int idobjetivo, int puntaje)
        {

            ReturnValue  validador = new ReturnValue() {isSuccess=false};
            ObjetivosCurso objetivosCurso = new ObjetivosCurso();
            using (var Contex = new BugTrackerFinalEntities())
            {
                try {
                    var cursos = Contex.Cursos.Where(x => x.id_curso == idcurso && x.borrado == false).FirstOrDefault();
                    var objetivos = Contex.Objetivos.Where(x => x.id_objetivo == idobjetivo && x.borrado == false).FirstOrDefault();
                    if (cursos != null && objetivos != null)
                    {
                        var objcurso = Contex.ObjetivosCursos.Where(x => x.id_curso == idcurso
                                                                   && x.id_objetivo == idobjetivo).FirstOrDefault();
                        if(objcurso == null) {
                            //seteo OBJCURSO que es la entidad con los get y set
                            objetivosCurso.id_curso = idcurso;
                            objetivosCurso.id_objetivo = idobjetivo;
                            objetivosCurso.puntos = puntaje;
                            objetivosCurso.borrado = false;
                            Contex.ObjetivosCursos.Add(objetivosCurso);
                            Contex.SaveChanges();
                            validador.isSuccess = true;
                        }
                        else { validador.ErrorMessage = "Ya existe ese objetivo para ese curso"; }
                    }
                    else { validador.ErrorMessage = "Ya existen esos datos";}
                }
                catch (Exception ex)
                {
                    validador.ErrorMessage = ex.Message;
                }
            }
            return validador;
        }
        public static List<ObjetivoxCursoCustom> MostrarGrilla(bool borrado, int curso)
        {
            using (var Contex = new BugTrackerFinalEntities())
            {
                var lista = from Cursos in Contex.ObjetivosCursos
                            where Cursos.id_curso == curso
                            select Cursos;
                if (!borrado)
                {
                    lista = lista.Where(x => (bool)x.borrado == false);
                }
                var temp = lista.Join(Contex.Objetivos,
                    ObjetivosCurso => ObjetivosCurso.id_objetivo,
                    Objetivo => Objetivo.id_objetivo,
                    (ObjetivosCurso, Objetivo) => new ObjetivoxCursoCustom()
                    {
                        id_objetivo = Objetivo.id_objetivo,
                        id_curso = ObjetivosCurso.id_curso,
                        objetivo_corto = Objetivo.nombre_corto,
                        objetivo_largo = Objetivo.nombre_largo,
                        puntos = (int)ObjetivosCurso.puntos,
                        borrado = (bool)ObjetivosCurso.borrado
                    });
                return temp.ToList();
            }

        }

        public static ReturnValue ModificarObjetivosxCurso(int idcurso, int idobjetivo, int puntaje)
        {
            ReturnValue validador = new ReturnValue() { isSuccess = false };
            using (var Contex = new BugTrackerFinalEntities())
            {
                try
                {
                    var cursos = Contex.Cursos.Where(x => x.id_curso == idcurso && x.borrado == false).FirstOrDefault();
                    var objetivos = Contex.Objetivos.Where(x => x.id_objetivo == idobjetivo && x.borrado == false).FirstOrDefault();
                    if (cursos != null && objetivos != null)
                    {
                        var cursos1 = Contex.ObjetivosCursos.Where(x => x.id_curso == idcurso &&
                                                                    x.id_objetivo == idobjetivo).FirstOrDefault();

                        if (cursos1 != null)
                        {
                            //seteo OBJCURSO que es la entidad con los get y set
                            if (cursos1.puntos != puntaje) cursos1.puntos = puntaje;
                            //if (cursos1.borrado != estado) cursos1.borrado = estado;
                            Contex.SaveChanges();
                            validador.isSuccess = true;
                        }
                        else { validador.ErrorMessage = "Erro1"; }
                    }
                    else { validador.ErrorMessage = "Erro2"; }
                }
                catch (Exception ex)
                {
                    validador.ErrorMessage = ex.Message;
                }
            }
            return validador;




        }

        public static ReturnValue EliminarObjetivosxCurso(int idcurso,int idobjetivo, bool borrado)
        {
            ReturnValue var1 = new ReturnValue() { isSuccess = false };
            using (var Contex = new BugTrackerFinalEntities())
            {
                try {
                    if (borrado == false){
                        var cursos1 = Contex.ObjetivosCursos.Where(x => x.id_curso == idcurso
                                                                   && x.id_objetivo == idobjetivo).FirstOrDefault();
                        if (cursos1 != null){
                            cursos1.borrado = true;
                            Contex.SaveChanges();
                            var1.isSuccess = true;
                        }
                    }
                    else{
                        var cursos1 = Contex.ObjetivosCursos.Where(x => x.id_curso == idcurso
                                                                   && x.id_objetivo == idobjetivo).FirstOrDefault();
                        Contex.ObjetivosCursos.Remove(cursos1);
                        Contex.SaveChanges();
                        var1.isSuccess = true;
                    }
                }
                catch (Exception ex) { var1.ErrorMessage = ex.Message; }

            }
            return var1;
        }
        public static ReturnValue HabilitarObjetivoxCurso(int idobjetivo, int idcurso, bool borrado)
        {
            ReturnValue validador = new ReturnValue() { isSuccess = false };
            using (var Contex = new BugTrackerFinalEntities())
            {
                try
                {
                    var curso = Contex.Cursos.Where(x => x.id_curso == idcurso && x.borrado == false).FirstOrDefault();
                    var objetivo = Contex.Objetivos.Where(x => x.id_objetivo == idobjetivo && x.borrado == false).FirstOrDefault();
                    if (curso != null && objetivo != null)
                    {
                        var cursos1 = Contex.ObjetivosCursos.Where(x => x.id_objetivo == idobjetivo && x.id_curso == idcurso).FirstOrDefault();

                        if (cursos1 != null)
                        {
                            if (cursos1.borrado != borrado) cursos1.borrado = borrado;
                            Contex.SaveChanges();
                            validador.isSuccess = true;
                        }
                        else { validador.ErrorMessage = "El Objetivo que quiere habilitar no existe."; }
                    }
                    else { validador.ErrorMessage = "Seleccionar el objetivo correcto."; }
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
