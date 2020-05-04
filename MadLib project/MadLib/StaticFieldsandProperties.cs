using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLib
{
    class StaticFieldsandProperties
    {

    }
    /*
     * The definition of what a forest is applies to all Forest objects, 
     * not just one — there should only be one value for the whole class. 
     * This is a good use case for a static field/property.
     * Remember that static means “associated with the class, not an instance”. 
     * Thus any static member is accessed from the class, not an instance:
     * 
     * In the previous exercise we mentioned storing the count of all Forest objects. 
     * We’ll use a static field and property to store that. 
     * Define a private static field named forestsCreated.
     * 
     * Define a public static property named ForestsCreated. 
     * Give it a public getter and private setter.
     * 
     * In the first constructor, increment ForestsCreated. 
     * This will add 1 to the property every time an object is constructed.










     
         */
    class Forest
    {
        // FIELDS

        public int age;
        private string biome;
        private static int forestsCreated;

        // CONSTRUCTORS

        public Forest(string name, string biome)
        {
            this.Name = name;
            this.Biome = biome;
            Age = 0;
            ForestsCreated++;
        }

        public Forest(string name) : this(name, "Unknown")
        { }

        // PROPERTIES

        public string Name
        { get; set; }

        public int Trees
        { get; set; }

        public string Biome
        {
            get { return biome; }
            set
            {
                if (value == "Tropical" ||
                    value == "Temperate" ||
                    value == "Boreal")
                {
                    biome = value;
                }
                else
                {
                    biome = "Unknown";
                }
            }
        }

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        public static int ForestsCreated
        {
            get { return forestsCreated; }
            private set { forestsCreated = value; }
        }

        // METHODS

        public int Grow()
        {
            Trees += 30;
            Age += 1;
            return Trees;
        }

        public int Burn()
        {
            Trees -= 20;
            Age += 1;
            return Trees;
        }

    }
}
