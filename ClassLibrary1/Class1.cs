using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public List<Usuario> Test()
        {
            using (var context = new BugTrackerFinalEntities())
            {
                var query = context.Usuarios.ToList();
                return query;
            }
        }
            
    }
}
