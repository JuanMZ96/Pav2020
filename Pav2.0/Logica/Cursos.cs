using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using Microsoft.SqlServer.Server;

namespace Pav2.Logica
{
    class Cursos
    {
        



        public static bool GuardarCursos(string name, string descripcion,int categoria)
        {
            bool guardar = false;
            Curso cur1 = new Curso();

            using (var Contex = new BugTrackerFinalEntities())
            {
                if (name != String.Empty && descripcion != String.Empty) {

                    cur1.nombre = name;
                    cur1.descripcion = descripcion;
                    cur1.borrado = false;
                    cur1.id_categoria = categoria;

                    var q = Contex.Cursos.Max(x => x.id_curso) + 1;
                    cur1.id_curso = q;
                    Contex.Cursos.Add(cur1);
                    Contex.SaveChanges();
                    guardar = true;
                }
            }


            return guardar;
        }


        public static bool ModificarCursos(int id, string name, string descripcion, bool estado)
        {
            bool modificar = false;

            using (var Contex = new BugTrackerFinalEntities())
            {
                var q = Contex.Cursos.Where(x => x.id_curso == id).FirstOrDefault();

                if (q.nombre != name)
                {
                    q.nombre = name;
                }
                if (q.descripcion != descripcion)
                {
                    q.descripcion = descripcion;
                }
                if(q.borrado != estado)
                {
                    q.borrado = estado;
                }

                Contex.SaveChanges();
                modificar = true;
            }

            return modificar;

        }

        public static bool EliminarCursos(int id, bool borrado)
        {
            bool eliminar = false;

            using (var Contex = new BugTrackerFinalEntities())
            {
                if (borrado == false)
                {
                    var q = Contex.Cursos.Where(x => x.id_curso == id).FirstOrDefault();
                    if (q != null)
                    {
                        q.borrado = true;
                        Contex.SaveChanges();
                        eliminar = true;
                    }
                }
                else
                {
                    var q = Contex.Cursos.Where(x => x.id_curso == id).FirstOrDefault();

                    Contex.Cursos.Remove(q);
                    Contex.SaveChanges();
                    eliminar = true;

                }
            }
           return eliminar;
        }

            public static List<Curso> MostrarDataCursos(bool estado)
        {
            //var Contex = new BugTrackerFinalEntities();
            //var lista = from cursos in Contex.Cursos
            //            where cursos.borrado != true
            //            select cursos;

            //if (!estado)
            //{
            //    lista.Where(x => x.borrado == true).ToList();
            //}

            //return lista.ToList();

            if (estado == false)

            {
                var Contex = new BugTrackerFinalEntities();
                var lista = from cursos in Contex.Cursos
                            where cursos.borrado != true
                            select cursos;
                return lista.ToList();

            }
            else
            {

                var Contex = new BugTrackerFinalEntities();
                var lista = from cursos in Contex.Cursos

                            select cursos;
                return lista.ToList();

            }




        }


    }
}
