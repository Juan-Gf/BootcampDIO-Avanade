using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace EstacionamentoClasses.Common.Models
{
    public class Carro
    {

        public Carro(string modelo, string placa)
        {
            modeloCarro = modelo;
            placaCarro = placa;
        }


        public string modeloCarro { get; set; }
        public string placaCarro { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Modelo: {modeloCarro} \nPlaca: {placaCarro}");    
        }

    }
}