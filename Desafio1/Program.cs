using System;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = Int32.Parse(Console.ReadLine());
            for (int i=0; i< limit; i++){
                string[] line = Console.ReadLine().Split(" ");
                double X = double.Parse(line[0].Replace('.',','));
                double Y = double.Parse(line[1].Replace('.',','));
                if( Y == 0){
                    Console.WriteLine("didivsão impossivel");

                }else{
                    double divisao = X / Y;
                    if(divisao < 0 && (divisao.ToString("N1") == "0.0")) 
                        {
                            Console.WriteLine("-0.0");
                        }
                    else {Console.WriteLine(divisao.ToString("N1"));}
                }
            } 
        }
    }
}
