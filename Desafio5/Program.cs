using System;

namespace Desafio5
{
    class Program
    {
        static void Main(string[] args)
        {
           double somaNota = 0; 
           int countNotaValida = 0;
           while(countNotaValida < 2){
                double nota = double.Parse(Console.ReadLine());
                if(nota >=0 && nota <= 10){
                    somaNota = somaNota + nota;
                    countNotaValida ++;
                }else{

                    Console.WriteLine("nota invalida");
                }
            }
            double divisao = somaNota /2 ;
            Console.WriteLine("media = " + divisao.ToString("N2"));
        }
    }
}
