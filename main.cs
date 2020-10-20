using System;

class MainClass {
  public static void Main (string[] args) {
    Carros Listas = new Carros();

    double contadorEco = Listas.Consumos[0];
    string carroMaisEco = "";


    for (int x=0; x < Listas.Veiculos.Count; x++) {
      if (Listas.Consumos[x] > contadorEco) {
        contadorEco = Listas.Consumos[x];
        carroMaisEco = Listas.Veiculos[x];
      }
    }

    Console.WriteLine("O Carro mais econômico é o {0}, com {1} km/l", carroMaisEco, contadorEco);

    for (int y=0; y < Listas.Veiculos.Count; y++) {
      Console.WriteLine("O Carro {0}, tem um consumo de {1}.", Listas.Veiculos[y], Listas.Consumos[y]);
      Console.WriteLine("Seu carro consome {0} Litros de gasolina, para percorrer 1000 km.", (1000/Listas.Consumos[y]));
      Console.WriteLine("O custo destes 1000 km é {0}.", (1000/Listas.Consumos[y])*4.89);
    }

  }
}