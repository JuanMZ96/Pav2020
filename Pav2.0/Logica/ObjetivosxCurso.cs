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
        public static ReturnValue GuardarObjetivosxCurso(int idcurso, int idObjetivo, int puntaje)
        {

            ReturnValue  validador = new ReturnValue() {isSuccess=false};
            ObjetivosCurso objcurso =  new ObjetivosCurso();
            using (var Contex = new BugTrackerFinalEntities())
            {
                try {
                    var cursos = Contex.Cursos.Where(x => x.id_curso == idcurso && x.borrado == false).FirstOrDefault();
                    var objetivos = Contex.Objetivos.Where(x => x.id_objetivo == idObjetivo && x.borrado == false).FirstOrDefault();
                    if (cursos != null && objetivos != null)
                    {
                        var cursos1 = Contex.ObjetivosCursos.Where(x => x.id_curso == idcurso
                                                                   && x.id_objetivo == idObjetivo).FirstOrDefault();
                        if(cursos1 == null) { 
                            //seteo OBJCURSO que es la entidad con los get y set
                            objcurso.id_curso = idcurso;
                            objcurso.id_objetivo = idObjetivo;
                            objcurso.puntos = puntaje;
                            objcurso.borrado = false;
                            Contex.ObjetivosCursos.Add(objcurso);
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

        public static ReturnValue ModificarObjetivosxCurso(int idcurso, int idObjetivo, int puntaje, bool estado)
        {
            ReturnValue validador = new ReturnValue() { isSuccess = false };
            ObjetivosCurso objcurso = new ObjetivosCurso();
            using (var Contex = new BugTrackerFinalEntities())
            {
                try
                {
                    var cursos = Contex.Cursos.Where(x => x.id_curso == idcurso && x.borrado == false).FirstOrDefault();
                    var objetivos = Contex.Objetivos.Where(x => x.id_objetivo == idObjetivo && x.borrado == false).FirstOrDefault();
                    if (cursos != null && objetivos != null)
                    {
                        var cursos1 = Contex.ObjetivosCursos.Where(x => x.id_curso == idcurso
                                                                   && x.id_objetivo == idObjetivo).FirstOrDefault();
                        if (cursos1 == null)
                        {
                            //seteo OBJCURSO que es la entidad con los get y set
                            if (objcurso.id_objetivo != idObjetivo) objcurso.id_objetivo = idObjetivo;
                            if (objcurso.puntos != puntaje) objcurso.puntos = puntaje;
                            if (objcurso.borrado != estado) objcurso.borrado = estado;
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

    }

    
}
