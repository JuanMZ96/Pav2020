using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav2.Logica
{
    public class CustomClass
    {
        public class UsuarioCustom
        {
            public int id_perfil { get; set; }
            public int id_usuario { get; set; }
            public string perfil { get; set; }
            public string usuario { get; set; }
            public string passw { get; set; }
            public string mail { get; set; }
            public bool borrado { get; set; }
        }

        public class ObjetivoxCursoCustom
        {
            public int id_objetivo { get; set; }
            public int id_curso { get; set; }
            public string objetivo_corto{ get; set; }
            public string objetivo_largo { get; set; }
            public int puntos { get; set; }
            public bool borrado { get; set; }
        }
        public class PerfilCustom
        {
            public int id { get; set; }
            public string nombre { get; set; }

        }

        public class CursosCustom
        {
           public int id { get; set; }
           public string name { get; set; }

        }
    }
    public class ReturnValue<T>
    {
        public bool isSuccess { get; set; }
        public T Data { get; set; }
        public string ErrorMessage { set; get; }
    }

    public class ReturnValue
    {
        public bool isSuccess { get; set; }
       
        public string ErrorMessage { set; get; }
    }

}
