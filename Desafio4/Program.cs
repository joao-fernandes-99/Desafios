using System;

namespace Desafio4
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int y=0; y<3; y++){
                int n = Int32.Parse(Console.ReadLine());
                if(n >=1 && n<=500){
                    
                    string[] line = Console.ReadLine().Split(" ");
                    if(line.Length == n){
                        int velocidadeMaior = 0;
                        for(int i=0; i < line.Length; i++){
                            
                            int velocidade = Int32.Parse(line[i]);
                            if(velocidade > velocidadeMaior){
                                velocidadeMaior = velocidade;
                            }
                        }

                        if(velocidadeMaior < 10){
                            Console.WriteLine(1.ToString());
                        }else if(velocidadeMaior >= 10 && velocidadeMaior < 20){
                            Console.WriteLine(2.ToString());
                        }else if(velocidadeMaior >=20){
                            Console.WriteLine(3.ToString());
                        }

                    }else{
                        Console.WriteLine("A quantidade de Valores informada não é correspondente a quantidade informada anterioremente");

                    }
                }else{
                    Console.WriteLine("A quantidade de valores deve ser de entre 1 e 500");
                }
            }
        }
    }
}
