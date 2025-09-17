using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstacionamentoClasses.Common.Models
{
    public class MenuEstacionamento
    {
        public void CadastroDeCarro(List<Carro> estacionamento)
        {
            Console.WriteLine("Preencha as informações do veicúlo.");

            Console.Write("Modelo do carro: ");
            string modelo = Console.ReadLine();

            Console.Write("Placa do carro: ");
            string placa = Console.ReadLine();
           
            Carro newCarro = new Carro(modelo,placa);

            estacionamento.Add(newCarro);
        }

        public void ListaDeCarro(List<Carro> estacionamento)
        {

            Console.WriteLine($"Os carros no estacionamento são:");
            foreach (Carro car in estacionamento)
            {
                car.Apresentar();
            }

        }
    }
}           