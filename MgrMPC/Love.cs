using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgrMPC
{
    class Love
    {
        bool s0, s1;
        bool b;
        string imie;
        public Love(bool s1, bool b, string imie)
        {
            this.s0 = false;
            this.s1 = s1;
            this.b = b;
            this.imie = imie;
        }
        public string getimie()
        {
            return this.imie;
        }
        public bool gets0()
        {
            return this.s0;
        }
        public bool gets1()
        {
            return this.s1;
        }
        public bool getb()
        {
            return this.b;
        }
    }
}
