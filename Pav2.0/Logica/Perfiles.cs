﻿using ClassLibrary1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;
using System.Data.Entity;


namespace Pav2.Logica
{
    public class Perfiles
    {
        public static List<Perfile> MostrarCombo(){

           using(var contex = new ClassLibrary1.BugTrackerFinalEntities()){
                var q = from s in contex.Perfiles
                    select s;
                return q.ToList();
           }

       } 
        
    }


}
