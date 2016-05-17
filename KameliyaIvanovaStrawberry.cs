using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class Strawberry
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            for (int i = 0; i < size/2; i++)
            {
                Console.WriteLine("{0}\\{1}|{1}/{0}", new string('-',2*i),new string('-',size-2*i));
            }
            for (int i = 0; i < (size+1)/2; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('-',size-2*i),new string('.',1+4*i) );
            }
            for (int i = 0; i <= size; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('-',i),new string('.',(2*size+1)-2*i));
            }

        }
    }

