using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupernaturalInheritance
{
    abstract class Spell
    {
        //type of storm
        public string Essence
        {
            get;
            private set;
        }
        //true if the storm is strong
        public bool IsStrong
        {
            get;
            private set;
        }
        //the title of the magician casting the storm
        public string Caster
        {
            get;
            private set;
        }

        // abstract string Announce();
    }
}
