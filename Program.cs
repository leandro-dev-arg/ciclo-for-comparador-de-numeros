using System;

namespace U5_programa_2
{
    class Program
    {
        static void Main(string[] args)
        { int a,nuevonumero;
            a=0;
            for (int x = 0; x < 10; x++)
            {
             Console.WriteLine("Ingresa un numero por favor");
             nuevonumero=int.Parse(Console.ReadLine());
                if(nuevonumero>a){
                    a=nuevonumero;
                }
            }
            Console.WriteLine("el numero mas alto es "+a);
        
        }
    }
}
