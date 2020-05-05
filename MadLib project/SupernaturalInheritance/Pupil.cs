using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupernaturalInheritance
{
    class Pupil
    {
        public Pupil(string title)
        {
            Title = title;
        }

        public Pupil(string Title, string origin)
        {

        }

        public string Title
        {
            get;
            private set;
        }
        public string Origin
        {
            get;
            private set;
        }

        public virtual Storm CastWindStorm()
        {
            Storm s = new Storm("wind", false, Title);
            return s;
        }
    }
}
