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

    for (int y=0; y < Listas.Veiculos.Count; y++) 

  }
}