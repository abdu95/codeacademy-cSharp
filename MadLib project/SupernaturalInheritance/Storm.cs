using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupernaturalInheritance
{
    class Storm
    {
        public Storm(string essence, bool isStrong, string caster)
        {
            Essence = essence;
            IsStrong = isStrong;
            Caster = caster;
        }
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

        public string Announce()
        {
            string strength = "";
            if (IsStrong)
                strength = "strong";
            else
                strength = "weak";
            string result = $"{Caster} cast a {strength} {Essence} storm!";
            return result;
        }
    }
}
