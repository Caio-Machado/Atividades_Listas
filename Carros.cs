using System;
using System.Collections.Generic;

class Carros {
  public List<string> Veiculos = new List<string>();
  public List<double> Consumos = new List<double>();


  public Carros () {
    //Uno
    Veiculos.Add("Uno");
    Consumos.Add(10.4);

    //Corsa
    Veiculos.Add("Corsa");
    Consumos.Add(12.3);

    //Gol
    Veiculos.Add("Gol");
    Consumos.Add(9.8);

    //Lamborghini
    Veiculos.Add("Lamborghini");
    Consumos.Add(6);

  }
}