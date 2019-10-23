using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 12, -34, 40, 6, -10, 56, 12, -1, -15, 10, 4 };
            sekuencaevazhduar(11, A);
            Console.ReadLine();
        }
        static void sekuencaevazhduar(int n , int [] t)
        {
            int fillim = 0, fund = n - 1, smax = 0, f1 = fillim, f2 = fund, s2;
            for(int i = fillim;i<=fund;i++)
            {
                smax += t[i];
            }
            s2 = smax;
            while(f1!=f2)
            {
                if(t[f1 + 1] < t[f2 - 1])
                {
                    s2 -= t[f1];
                    f1++;
                }
                else
                {
                    s2 -= t[f2];
                    f2--;
                }
                if(s2>smax)
                {
                    fillim = f1;
                    fund = f2;
                    smax = s2;
                }
            }
            Console.WriteLine("Shuma max eshte : {0}", smax);
            Console.WriteLine("Index fillimi eshte : {0}", fillim);
            Console.WriteLine("Index fundi eshte : {0}", fund);
            return;

        }
    }
}
