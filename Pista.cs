using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CarRacing
{
    class Pista
    {
        public int Comprimento { get; private set; }

        public List<Carro> Carros { get; private set; }

        //int tamPista = 20;
        public Pista(int comprimento, List<Carro> carros)
        {
            Comprimento = comprimento;
            Carros = carros;
        }
        public int NumeroCarros 
        {
            get
            {
                return Carros.Count;
            }
        }

        public void Print(bool clear = true)
        {
            if (clear)
                Clear();
            
            var contorno = "".PadRight(Comprimento, '═');  //vai desenhar aquele símbolo as vezes do comprimento
            WriteLine(contorno);

            foreach (var carro in Carros)
            {
                carro.Print();
            }
            
            WriteLine(contorno);
        }

        public void MaisUmaVolta()
        {
            foreach (var carro in Carros)
                carro.Move();
        }

        public bool HaVencedor()
        {
            foreach (var carro in Carros)
            {
                if (carro.Kms >= Comprimento)
                    return true;
            }

            return false;
        }

        public Carro GetVencedor()
        {
            foreach (Carro carro in Carros)
            {
                if (carro.Kms >= Comprimento)
                    return carro;
            }

            return null;
        }

        public List<Carro> GetVencedores()
        {
            var vencedores = new List<Carro>();

            foreach (var carro in Carros)
            {
                if (carro.Kms >= Comprimento)
                    vencedores.Add(carro);
            }
            return vencedores;
        }
    }
}

//Quantos carros estão na pista?
//vai receber carros?
//tamanho
//print()
//has winner ()?
//
/*
 * ════════════ (alt + 205)
 * .....Seat (4km)
 * ..........
 * .......
 * ═════════════
 */