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
    class Categorias
    {
        public static bool GuardarCategoria(string name, string descripcion)
        {
            bool guardar = false;
            Categoria cat1 = new Categoria();
            

            using (var Contex = new BugTrackerFinalEntities())
            {
                if (name != String.Empty && descripcion != String.Empty) 
                {
                    cat1.nombre = name;
                    cat1.descripcion = descripcion;
                    cat1.borrado = false;

                    var q = Contex.Categorias.Max(x => x.id_categoria) + 1;
                    cat1.id_categoria = q;
                    Contex.Categorias.Add(cat1);
                    Contex.SaveChanges();
                    guardar = true;
                }
            }
            return guardar;
        }


        public static bool ModificarCategoria(int id, string name, string descripcion, bool estado)
        {
            bool modificar = false;

            using (var Contex = new BugTrackerFinalEntities())
            {
                var q = Contex.Categorias.Where(x => x.id_categoria == id).FirstOrDefault();

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

        public static bool EliminarCategoria(int id, bool borrado)
        {
            bool eliminar = false;

            using (var Contex = new BugTrackerFinalEntities())
            {
                if (borrado == false)
                {
                    var q = Contex.Categorias.Where(x => x.id_categoria == id).FirstOrDefault();
                    if (q != null)
                    {
                        q.borrado = true;
                        Contex.SaveChanges();
                        eliminar = true;
                    }
                }
                else
                {
                    var q = Contex.Categorias.Where(x => x.id_categoria == id).FirstOrDefault();

                    Contex.Categorias.Remove(q);
                    Contex.SaveChanges();
                    eliminar = true;

                }
            }
           return eliminar;
        }

        public static List<Categoria> MostrarDataCategorias(bool estado)
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
                var lista = from categorias in Contex.Categorias
                            where categorias.borrado != true
                            select categorias;
                return lista.ToList();

            }
            else
            {
                var Contex = new BugTrackerFinalEntities();
                var lista = from categorias in Contex.Categorias

                            select categorias;
                return lista.ToList();
            }

        }

    }
}
