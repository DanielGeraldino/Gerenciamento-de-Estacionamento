using System;
using System.Globalization;

public class Carro {

  public Cliente dono;
  public string modelo;
  public string placa;
  public string marca;
  public string horaEntrada;
  public string horaSaida;

  public Carro(Cliente dono, string modelo, string placa, string marca){
    this.dono = dono;
    this.modelo = modelo;
    this.placa = placa;
    this.marca = marca;
    horaEntrada = registraHora();
  }

  public void registraHoraSaida(){
    horaSaida = registraHora();
  }

  private string registraHora(){
    DateTime horaAtual = DateTime.UtcNow;
    return horaAtual.ToString(new CultureInfo("pt-BR"));
    //  "dd/MM/yy H:mm:ss";
  }

}