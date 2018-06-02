using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgrMPC
{
    public class Party_SPDZ
    {
        public int index;
        public int x;
        public int y;
        public int randomvalue_x;
        public int randomvalue_y;
        public int received_rx;
        public int received_ry;
        public int liczba_udzialow;
        public int[] udzialx;
        public int[] udzialy;
        public int z;
        public int a, b, c;
        public Party_SPDZ(int x, int y, int liczba_udzialow, int i, int rx, int ry, int a, int b)
        {
            this.x = x;
            this.y = y;
            this.liczba_udzialow = liczba_udzialow;
            this.index = i;
            udzialx = new int[liczba_udzialow];
            udzialy = new int[liczba_udzialow];
            this.randomvalue_x = rx;
            this.randomvalue_y = ry;
            received_rx = 0;
            received_ry = 0;
            z = 0;
            this.a = a;
            this.b = b;
            c = a * b;

        }
        public int send_rx()
        {
            return randomvalue_x;
        }
        public int send_ry()
        {
            return randomvalue_y;
        }

        public int send_x_minus_rx()
        {
            return x - received_rx;
        }
        public int send_y_minus_ry()
        {
            return y - received_ry;
        }

        /*public int udzial_z(int x_min_a, int y_min_b)
        {
            z = c + (x_min_a * b) + (y_min_b * a);
            return z;
        }*/

    }
}
