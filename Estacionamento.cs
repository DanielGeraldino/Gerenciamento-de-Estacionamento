
using System;
using System.Globalization;

public class Estacionamento {
  
  public Carro[,] vagas;

  public Estacionamento(int linha , int coluna){
    vagas = new Carro [linha, coluna];
  }
  
  public void locacaoVaga(Carro carro, int linha, int coluna){
    if(vagas[linha, coluna] == null){
      vagas[linha, coluna] = carro;
    }
  }

  public void imprimirCarros(){
    foreach(var carro in vagas){
      if(carro != null){
        Console.WriteLine($"O cliente {carro.dono.nome} tem o carro {carro.marca} com a placa {carro.placa} | entrada: {carro.horaEntrada}");
      }
    }
  }
}