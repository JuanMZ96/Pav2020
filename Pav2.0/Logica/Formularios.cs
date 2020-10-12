using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav2.Logica
{
    public class Formularios
    {
        public static List<ClassLibrary1.Formulario> MostrarCombo()
        {
            using (var contex = new ClassLibrary1.BugTrackerFinalEntities())
            {
                var q = from s in contex.Formularios
                        select s;
                return q.ToList();
            }
        }
        public static List<Formulario> CargarGrilla(bool estado)
        {
            if (estado == false)
            {
                var Contex = new BugTrackerFinalEntities();
                var lista = from Formularios in Contex.Formularios
                            where Formularios.borrado != true
                            select Formularios;
                return lista.ToList();

            }
            else
            {
                var Contex = new BugTrackerFinalEntities();
                var lista = from Formularios in Contex.Formularios

                            select Formularios;
                return lista.ToList();
            }
        }
    }

}
