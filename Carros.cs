using System;
using System.Collections.Generic;

class Carros {
  string carro;
  public string getCarro (){
    return carro;
  }

  double consumo;
  public double getConsumo (){
    return consumo;
  }

  public Carros (string carr, double cons) {
    carro = carr;
    consumo = cons;

  }
}