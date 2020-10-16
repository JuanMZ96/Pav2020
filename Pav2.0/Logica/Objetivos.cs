using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav2.Logica
{
    class Objetivos
    {
        public static bool GuardarObjetivo(string nombreCorto, string nombreLargo)
        {
            bool guardar = false;
            Objetivo obj1 = new Objetivo();
            

            using (var Contex = new BugTrackerFinalEntities())
            {
                var idem = Contex.Objetivos.Where(x => x.nombre_corto == nombreCorto || x.nombre_largo == nombreLargo).FirstOrDefault();
                if (idem == null)
                {
                    if (!String.IsNullOrWhiteSpace(nombreCorto) && !String.IsNullOrWhiteSpace(nombreLargo))
                    {
                        obj1.nombre_corto = nombreCorto;
                        obj1.nombre_largo = nombreLargo;
                        obj1.borrado = false;

                        var q = Contex.Objetivos.Max(x => (int?)x.id_objetivo);
                        if (q.HasValue)
                        {
                            q += 1;
                        }
                        else
                        {
                            q = 0;
                        }

                        obj1.id_objetivo = q.Value;
                        Contex.Objetivos.Add(obj1);
                        Contex.SaveChanges();
                        guardar = true;
                    }

                }
                                 
                
            }

            return guardar;
        }
        

        public static bool ModificarObjetivo(int id, string nombreCorto, string nombreLargo, bool estado)
        {
            bool modificar = false;

            using (var Contex = new BugTrackerFinalEntities())
            {
                if (!String.IsNullOrWhiteSpace(nombreCorto) && !String.IsNullOrWhiteSpace(nombreLargo))
                {
                    var q = Contex.Objetivos.Where(x => x.id_objetivo == id).FirstOrDefault();

                    if (q.nombre_corto != nombreCorto)
                    {
                        q.nombre_corto = nombreCorto;
                    }
                    if (q.nombre_largo != nombreLargo)
                    {
                        q.nombre_largo = nombreLargo;
                    }
                    if (q.borrado != estado)
                    {
                        q.borrado = estado;
                    }

                    Contex.SaveChanges();
                    modificar = true;
                }
            }

            return modificar;

        }

        public static bool EliminarObjetivo(int id, bool borrado)
        {
            bool eliminar = false;

            using (var Contex = new BugTrackerFinalEntities())
            {
                if (borrado == false)
                {
                    var q = Contex.Objetivos.Where(x => x.id_objetivo == id).FirstOrDefault();
                    if (q != null)
                    {
                        q.borrado = true;
                        Contex.SaveChanges();
                        eliminar = true;
                    }
                }
                else
                {
                    var q = Contex.Objetivos.Where(x => x.id_objetivo == id).FirstOrDefault();

                    Contex.Objetivos.Remove(q);
                    Contex.SaveChanges();
                    eliminar = true;

                }
            }
            return eliminar;
        }

        public static List<Objetivo> MostrarDataObjetivos(bool estado)
        {
            //var Contex = new BugTrackerFinalEntities();
            //var lista = from categorias in Contex.Categorias
            //            where categorias.borrado != true
            //            select categorias;

            //if (!estado)
            //{
            //    lista.Where(x => x.borrado == true).ToList();
            //}

            //return lista.ToList();

            if (estado == false)

            {
                var Contex = new BugTrackerFinalEntities();
                var lista = from objetivos in Contex.Objetivos
                            where objetivos.borrado != true
                            select objetivos;
                return lista.ToList();

            }
            else
            {

                var Contex = new BugTrackerFinalEntities();
                var lista = from objetivos in Contex.Objetivos

                            select objetivos;
                return lista.ToList();

            }



        }

        public static List<Objetivo> MostrarCombo()
        {
            using (var contex = new ClassLibrary1.BugTrackerFinalEntities())
            {
                var q = from s in contex.Objetivos
                        where s.borrado == false
                        select s;
                return q.ToList();
            }
        }

    }
}
