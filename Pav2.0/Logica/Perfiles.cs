using ClassLibrary1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;
using System.Data.Entity;
using static Pav2.Logica.CustomClass;

namespace Pav2.Logica
{
    public class Perfiles
    {
        public static List<Perfile> MostrarCombo()
        {

            using (var contex = new BugTrackerFinalEntities())
            {
                var q = from s in contex.Perfiles
                        select s;
                return q.ToList();
            }

        }

        public static IList MostrarCombo2()
        {
            List<PerfilCustom> ListPerfil = new List<PerfilCustom>();

            using (var Contex = new BugTrackerFinalEntities())
            {
                ListPerfil = (from d in Contex.Perfiles
                              select new PerfilCustom
                              {
                                  id = d.id_perfil,
                                  nombre = d.nombre
                              }).ToList();
            }
            return ListPerfil;
        }
    }


}
