using System;
using System.Globalization;
using System.Threading;

class MainClass {
  public static void Main (string[] args) {
    
    Cliente cliente = new Cliente("123456", "Thiago", "29/10/2005");
    Carro carro = new Carro(cliente, "Siena", "123e123", "Fiat");
    Estacionamento est = new Estacionamento(5, 5);

    est.locacaoVaga(carro, 1,1);
    Thread.Sleep(60000);

    est.liberaVaga(1,1);

  }
    
}