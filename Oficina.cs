using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CarRacing
{
    //Criar a classe Oficina → permite criar veículos
    class Oficina 
    {
        static Random rnd = new Random(); //para usar fora da classe

        //vai criar veículos (fabricar carros), de forma aleatória
        public List<Carro> FabricarCarros(int numCarros)
        {
            List<Carro> carros = new List<Carro>();
            var faker = new Bogus.Faker();

            for (int i = 1; i <= 10; i++)
            {
                var colorNumber = rnd.Next(1, 16);
                carros.Add(new Carro(faker.Vehicle.Model(), (ConsoleColor)colorNumber));
            }
            
            return carros;                  
        }
    }
}


//Instalar a package Bogus disponível em nuget.org
///Utilizando um repositório de bibliotecas (nuget.org) - substitui uma carregamento de dados manual.

//var model = faker.Vehicle.Model();      