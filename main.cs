using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Carros Listas = new Carros("primeiro", 0);
    List<Carros> Veiculos = new List<Carros>();
    string respCarro;
    double respConsumo;
    char Sentinela = 'S';


    while (Sentinela == 'S') {
      Console.WriteLine("Nome/Marca do carro >>");
      respCarro = Console.ReadLine();

      Console.WriteLine("Km/l >>");
      respConsumo = double.Parse(Console.ReadLine());

      Listas = new Carros(respCarro, respConsumo);
      Veiculos.Add(Listas);

      Console.WriteLine("Deseja adicionar mais um carro? utilize S/N ");
      Sentinela = char.Parse(Console.ReadLine());

    }

    //Mais econômico
    Carros carroMaisEco = Veiculos[0];


    for (int x=0; x < Veiculos.Count; x++) {
      if (Veiculos[x].getConsumo() > carroMaisEco.getConsumo()) {
        carroMaisEco = Veiculos[x];
      }
    }

    Console.WriteLine("O Carro mais econômico é o {0}.", carroMaisEco.getCarro());

    //Preços
    for (int y=0; y < Veiculos.Count; y++) {
      Console.WriteLine("O Carro {0}, tem um consumo de {1}.", Veiculos[y].getCarro(), Veiculos[y].getConsumo());
      Console.WriteLine("Seu carro consome {0} Litros de gasolina, para percorrer 1000 km.", (1000/Veiculos[y].getConsumo()));
      Console.WriteLine("O custo destes 1000 km é {0}.", (1000/Veiculos[y].getConsumo())*4.89);
    }

  }
}