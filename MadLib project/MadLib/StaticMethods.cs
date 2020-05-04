﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLib
{
    class StaticMethods
    {
    }
    
    //  You already know how to create an instance method, like:
    class Forests
    {
      private string definition;
      public void Define()    
      {
        Console.WriteLine(definition);
      }
    }
    /*
     * This behavior (printing a general definition) isn’t specific to any one instance — it applies to the class itself, so it should be made static.

To make a static method, just add static after the access modifier (public or private).
     */
    class Fores
    {
        private static string definition;
        public static void Define()
        {
            Console.WriteLine(definition);
        }
    }

    /*Notice that we made added static to both the field definition and method Define()
     * This is because a static method can only access other static members. It cannot access instance members:
     */
    class Forestss
    {
        private string definition;
        public static void Define()
        { 
        // Throws error because definition is not static
        //Console.WriteLine(definition); 
        }
    }
    //Otherwise, static methods work like any other method.

}
