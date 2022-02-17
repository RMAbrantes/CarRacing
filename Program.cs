using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CarRacing
{
    class Program
    {
        static void Main(string[] args)
        {           
            while (true)
            {
                //pode ser assim:
                var carros = new Oficina().FabricarCarros(10);
                var pista = new Pista(100, carros);
                //ou assim:
                //var o = new Oficina();
                //var carros = o.FabricarCarros(10);  

                while (!pista.HaVencedor())
                {                    
                    pista.MaisUmaVolta();
                    pista.Print();

                    Thread.Sleep(500);
                }
                
                foreach (var vencedor in pista.GetVencedores())
                {
                    WriteLine($"O vencedor é {vencedor.Marca}, {vencedor.Kms}");
                }

                
                //ou:
                //WriteLine($"O vencedor é {pista.GetVencedor().Marca}");

                WriteLine("Prima qualquer tecla para outra corrida.");
                Read();
            }

            WriteLine("Prima qualquer tecla para terminar.");
            Read();
        }
    }
}

/*//Podemos criar quantos carros quisermos (neste caso são 2)
                Carro c1 = new Carro("BMW", ConsoleColor.Blue);
                Carro c2 = new Carro("Seat", ConsoleColor.DarkRed);
                //A cor pode mudar, tanto se for vencedor, como no objeto carro
                //winner.cor = ConsoleColor.Black;
                //enquanto nenhum carro chegou ao fim da pista*/

/*//Mover os carros
carro.Move();
carro.Print();*/


//Apresentá-los na pista
/*c1.Print();
c2.Print();*/
//ver se algum carro venceu, i.e., se tem mais kms
/*if (c1.Kms >= tamPista)
    winner = c1;
else if (c2.Kms >= tamPista)
    winner = c2;*/