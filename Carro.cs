using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CarRacing
{    
    class Carro
    {
        public ConsoleColor Cor { get; set; }

        public string Marca { get; set; }

        public int Kms { get; set; }

        private static int NumCarros = 0;

        Random rnd = new Random();

        public Carro(string marca, ConsoleColor cor) // Construtor criado com  parametros de entrada.
        {
            this.Cor = cor;
            this.Marca = marca;
        }

        public static int GetNumCarros()
        {
            return NumCarros;
        }

        public void Move()
        {
            // Fazer o carro andar um determinado número de kms aleatoriamente.

            var kmsPercorridos = rnd.Next(1, 10);
            Kms += kmsPercorridos;
        }

        public void Print()
        {
            // Imprimir neste template: ...Seat (3 kms)

            ForegroundColor = Cor;

            for (int i = 0; i < Kms; i++)
                Write(".");

            WriteLine($"{Marca} ({Kms} kms)");
            ResetColor();
        }
    }
}

/*//public static passou a ser uma variável da classe
    //public static int NumCarros = 0; 
    //se for private deixamos de ter acesso às refª que faz

    //e temos de mudar tb as refª em Program e criar mais um public static com GetNumCarros

    //ATENÇÃO:
    //É má prática ter atributos públicos: isto:
    //o cliente (que vai usar o nosso código) não necessita de ter acesso a estas info:*/