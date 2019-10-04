using System;
using System.Globalization;

public class Carro {

  public Cliente dono;
  public string modelo;
  public string placa;
  public string marca;
  public DateTime horaEntrada;
  public DateTime horaSaida;
  public double valorPagar;

  public Carro(Cliente dono, string modelo, string placa, string marca){
    this.dono = dono;
    this.modelo = modelo;
    this.placa = placa;
    this.marca = marca;
    this.valorPagar = 0;
    horaEntrada = registraHora();
  }

  public DateTime registraHoraSaida(){
    horaSaida = registraHora();
    return horaSaida;
  }

  private DateTime registraHora(){
    DateTime horaAtual = DateTime.UtcNow;
    //return horaAtual.ToString(new CultureInfo("pt-BR"));
    return horaAtual;
  }

  private string conveteHora(DateTime hora){
    return hora.ToString(new CultureInfo("pt-BR"));
  }

  public string imprimirCarro()
  {
    return $"{dono.imprimirCliente()} {conveteHora(horaEntrada)} {conveteHora(horaSaida)} {valorPagar}";
  }
}