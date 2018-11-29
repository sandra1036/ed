using System;

namespace CVector
{
    class Vector
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Array.ForEach(new int[] { 12, 15, 19, 32, 37 }, item => Console.WriteLine("item " + item));
        }

        public static int BinarySearch(int[] v, int x){
            int count = v.Length;
            if (count == 0)
                return -1;
            int primero = 0;
            int ultimo = count - 1;
            int medio = ( primero + ultimo ) / 2;
            while ( primero < ultimo && v[medio] != x ){

                if ( primero < x )

                    primero = medio + 1;

                else
                    ultimo = medio - 1;

                    medio = (primero + ultimo) / 2;
            }
            if (primero > ultimo)
                return -1;

            if (v[medio] == x)
                return medio;
                return -1;
        }
    
    }
}