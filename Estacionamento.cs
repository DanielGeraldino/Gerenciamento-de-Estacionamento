using System;
using System.Globalization;

public class Estacionamento {
  
  public Carro[,] vagas;
  public int linha;
  public int coluna;
  private double valorPorMinuto;

  public Estacionamento(int linha , int coluna){

    this.valorPorMinuto = 2;
    this.linha = linha;
    this.coluna = coluna;
    vagas = new Carro [linha, coluna];
  }
  
  public void locacaoVaga(Carro carro, int linha, int coluna){
    if(vagas[linha, coluna] == null){
      vagas[linha, coluna] = carro;
    }
  }

  public void liberaVaga(int linha, int coluna){
    if(vagas[linha, coluna] != null){
      vagas[linha, coluna].registraHoraSaida();
      vagas[linha, coluna].valorPagar = calculaValor(vagas[linha, coluna]);
      ConexaoDados.escreveMovimentacao(vagas[linha, coluna]);
      vagas[linha, coluna] = null;
    }
  }

  private double calculaValor(Carro carro){
    TimeSpan tempoLocacao = carro.horaSaida - carro.horaEntrada;
    return tempoLocacao.Minutes * valorPorMinuto;
  }

  public void imprimirCarros(){
    for(int i = 0; i < linha; i++){
      for(int j = 0; j < coluna; j++){
        if(vagas[i, j] != null){
          Console.WriteLine($"O cliente {vagas[i, j].dono.imprimirCliente()} tem o carro {vagas[i, j].marca} com a placa {vagas[i, j].placa} | entrada: {vagas[i, j].horaEntrada} | local da vaga: ({i+1},{j+1})");
        }
      }
    }
  }


}