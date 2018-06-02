using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgrMPC
{
    class Party_GMW87
    {
        public int nr;
        public int x;
        public BitArray bity_x;
        public int liczba_udzialow;
        public int[,] bity_udzialy;
        void generuj_x(int x)
        {
            this.x = x;
            bity_x = new BitArray(new[] { this.x });
        }
        public Party_GMW87(int x, int liczba_udzialow, int nr)
        {
            this.nr = nr;
            generuj_x(x);
            this.liczba_udzialow = liczba_udzialow;
            bity_udzialy = new int[liczba_udzialow, bity_x.Length];//nr udzialu,nr bit udzialu
            for (int i = 0; i < liczba_udzialow; i++)
                for (int j = 0; j < bity_x.Length; j++)
                    bity_udzialy[i, j] = 0;
        }
        public int[] podziel_bit(int index, int rand)
        {
            int[] bits = new int[liczba_udzialow];
            int sum = 0;
            int x1 = bity_x[index] ? 1 : 0;
            for(int i=0;i<liczba_udzialow-1;i++)
            {
                bits[i] = rand%2;
                sum += bits[i];
            }
            sum = sum % 2;
            if (sum != x1)
                bits[liczba_udzialow - 1] = 1;
            return bits;
        }
        public int[] notinitialize(int index)
        {
            int[] bits = new int[bity_x.Length];
            for(int i=0;i<bits.Length; i++)
            {
                bits[i] = (bity_udzialy[index, i]+1)%2;
            }
            return bits;
        }
    }
}
