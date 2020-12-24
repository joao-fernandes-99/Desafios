using System;

namespace Desafio6
{
    class Program
    {
        static void Main(string[] args)
        {
           int r = Int32.Parse(Console.ReadLine());
           int v=0;
           int valido = 0;
           //Leitura
           while(valido == 0){
               v = Int32.Parse(Console.ReadLine());
               if(v > r){
                   valido =1;
               }
           }
           int countVezes = 1;
           for(r<=v;countVezes++;){
               r++;
              
           }
           Console.WriteLine(countVezes);
        }
    }
}
