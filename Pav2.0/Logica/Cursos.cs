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
using static Pav2.Logica.CustomClass;

namespace Pav2.Logica
{
    class Cursos
    {
        public static ReturnValue GuardarCursos(string name, string descripcion, int categoria, DateTime fecha)
        {
            ReturnValue var1 = new ReturnValue() { isSuccess = false };
            Curso cur1 = new Curso();
            using (var Contex = new BugTrackerFinalEntities())
            {
                try
                {
                    if (name != String.Empty && descripcion != String.Empty)
                    {
                        cur1.nombre = name;
                        cur1.descripcion = descripcion;
                        cur1.borrado = false;
                        cur1.id_categoria = categoria;
                        cur1.fecha_vigencia = fecha;

                        var q = Contex.Cursos.Max(x => x.id_curso) + 1;
                        cur1.id_curso = q;
                        Contex.Cursos.Add(cur1);
                        Contex.SaveChanges();
                        var1.isSuccess = true;

                    }
                    else { var1.ErrorMessage = "Campos vacios"; }

                }
                catch (Exception ex) { var1.ErrorMessage = ex.Message; }

            }
            return var1;
        }


        public static ReturnValue ModificarCursos(int id, string name, string descripcion, int categoria, DateTime fecha)
        {

            ReturnValue var1 = new ReturnValue() { isSuccess = false };
            using (var Contex = new BugTrackerFinalEntities())
            {
                try
                {
                    var q = Contex.Cursos.Where(x => x.id_curso == id).FirstOrDefault();
                    if (q != null)
                    {
                        if (q.nombre != name) q.nombre = name;
                        if (q.descripcion != descripcion) q.descripcion = descripcion;
                        //if (q.borrado != estado) q.borrado = estado;
                        if (q.id_categoria != categoria) q.id_categoria = categoria;
                        if (q.fecha_vigencia != fecha) q.fecha_vigencia = fecha;
                        Contex.SaveChanges();
                        var1.isSuccess = true;
                    }
                    else { var1.ErrorMessage = "Curso no encontrado"; }
                }
                catch (Exception ex) { var1.ErrorMessage = ex.Message; }
            }
            return var1;

        }

        public static ReturnValue EliminarCursos(int id, bool borrado)
        {

            ReturnValue var1 = new ReturnValue() { isSuccess = false };
            using (var Contex = new BugTrackerFinalEntities())
            {
                try
                {
                    if (borrado == false)
                    {
                        var q = Contex.Cursos.Where(x => x.id_curso == id).FirstOrDefault();
                        if (q != null)
                        {
                            q.borrado = true;
                            Contex.SaveChanges();
                            var1.isSuccess = true;

                        }
                    }
                    else
                    {
                        var q = Contex.Cursos.Where(x => x.id_curso == id).FirstOrDefault();

                        Contex.Cursos.Remove(q);
                        Contex.SaveChanges();
                        var1.isSuccess = true;

                    }
                }
                catch (Exception ex) { var1.ErrorMessage = ex.Message; }

            }
            return var1;
        }

        public static List<CursosCustomdgv> CargarGrillaCustom(bool borrado)
        {

            using (var contex = new BugTrackerFinalEntities())
            {
                var lista = from Curso in contex.Cursos
                            select Curso;
                if (!borrado)
                {
                    lista = lista.Where(x => (bool)x.borrado == false);
                }
                var temp = lista.Join(contex.Categorias,
                    Curso => Curso.id_categoria,
                    Categoria => Categoria.id_categoria,
                    (Curso, Categoria) => new CursosCustomdgv()
                    {
                        id_curso = Curso.id_curso,
                        id_categoria = (int)Curso.id_categoria,
                        nombre = Curso.nombre,
                        descripcion = Curso.descripcion,
                        name_categoria = Categoria.nombre,
                        fecha = (DateTime)Curso.fecha_vigencia,
                        borrado = (bool)Curso.borrado

                    });
                return temp.ToList();
            }
        }

        public static List<CustomClass.CursosCustom> MostrarCombo()
        {
            using (var contex = new BugTrackerFinalEntities())
            {
                var q = (from s in contex.Cursos
                         where s.borrado == false
                         select new CustomClass.CursosCustom
                         {
                             id = s.id_curso,
                             name = s.nombre
                         }).ToList();
                return q;
            }
        }

        public static List<Curso> FiltrarDataCurso(string filtro)
        {
            var Contex = new BugTrackerFinalEntities();
            var lista = from Curso in Contex.Cursos
                        where Curso.borrado != true
                        && Curso.nombre.IndexOf(filtro) >= 0
                        select Curso;
            return lista.ToList();
        }

        public static List<Curso> MostrarDataCurso(bool estado)
        {

            if (estado == false)
            {
                var Contex = new BugTrackerFinalEntities();
                var lista = from Curso in Contex.Cursos
                            where Curso.borrado != true
                            select Curso;
                return lista.ToList();

            }
            else
            {
                var Contex = new BugTrackerFinalEntities();
                var lista = from Curso in Contex.Cursos

                            select Curso;
                return lista.ToList();
            }
        }
    }
   
}
        public static ReturnValue HabilitarCursos(int id, bool borrado)
        {
            ReturnValue validador = new ReturnValue() { isSuccess = false };
            using (var Contex = new BugTrackerFinalEntities())
            {
                try
                {
                    var curso = Contex.Cursos.Where(x => x.id_curso == id && x.borrado == true).FirstOrDefault();

                    if (curso != null)
                    {
                        if (curso.borrado != borrado) curso.borrado = borrado;
                        Contex.SaveChanges();
                        validador.isSuccess = true;
                    }
                    else { validador.ErrorMessage = "Seleccionar el curso correcta."; }
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






    
