using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgrMPC
{
    class Millioner
    {
        public int n, e, p, q, on;
        public double d;

        public Millioner()
        {
            Random r = new Random();
            bool pierwsza = false;
            while(!pierwsza)
            {
                //p = r.Next(2, 20);
                p = 3;
                pierwsza = liczba_pierwsza(p);
            }
            pierwsza = false;
            while(!pierwsza)
            {
                //q = r.Next(2, 20);
                q = 17;
                pierwsza = liczba_pierwsza(q);
            }
            on = (p - 1) * (q - 1);
            e = eukl(p, q, 10);
            while(e>on)
            {
                e = eukl(p, q, r.Next(2,10));
            }
            n = p * q;
            //Console.WriteLine("p,q,e,on " + p + " " + q + " " + e + " " + on);
            d = compute_d(e, on);
            //Console.WriteLine(d);
            //long c = (long)Math.Pow(7, e) % n;//4-8
            //Console.WriteLine(c);
            //long m = (long)Math.Pow(c, d) % n;
            //Console.WriteLine(m);
            
        }
        private bool liczba_pierwsza(int liczba)
        {
            for(int i=2;i<(int)Math.Round((double)liczba/2);i++)
            {
                if (liczba % i == 0)
                    return false;
            }
            return true;
        }
        private int eukl(int p, int q, int przedzial)
        {
            int wyn = 3;
            int on = (p - 1) * (q - 1);
            int ax = 0;
            int bx = 0;
            for(int i=(int)Math.Round((double)przedzial/2);i< przedzial;i++)
            {
                ax = i;
                bx = on;
                while(bx!=0)
                {
                    wyn = bx;
                    bx = ax % bx;
                    ax = wyn;
                    //Console.WriteLine("ax=" + ax);
                }
                if (ax == 1)
                    return i;
            }
            return wyn;
        }
        private int compute_d(int e, int on)
        {
            int d = 0;
            for(int i=1;i< on;i++)
            {
                d = i;
                if ((d * e) % on == 1)
                    return d;
            }
            return d;
        }
    }
}
