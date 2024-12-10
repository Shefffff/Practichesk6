using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practichesk5
{
    internal class Pair
    {
        public int first;
        public int second;
        public Pair() 
        {
            first = 0;
            second = 0;
        }   
        public Pair (int a, int b)
        {
            first = a; 
            second = b;
        }
        public void SetParams( int a, int b)
        {
            first = a; 
            second = b; 
        }
        public void SetParams()
        {
            first++;
            second++;   
        }
        public void pairDecrement(int a, int b)
        {
            first = a;
            second = b;
        }
        public void pairDecrement()
        {
            first--;
            second--;
        }
        public int plus()
        {
            return first+second;
        }
        public void plus(Pair pair, out int a, out int b )//обработчик суммы полей двух пар
        
            {
                a = first+pair.first;
                b = second+pair.second;
            }
        public void plus(Pair pair1,Pair pair2, out int a, out int b)// обработчик суммы трех пар

        {
            a = first + pair1.first + pair2.first;
            b = second + pair1.second + pair2.second;
        }
    } 
}
