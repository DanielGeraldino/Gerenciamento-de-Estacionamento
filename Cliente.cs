using System;

public class Cliente {
  
  public string cpf { get; private set; }
  public string nome { get; private set; }
  public string nascimento { get; private set; }

  public Cliente(string cpf, string nome, string nascimento){
    this.cpf = cpf;
    this.nome = nome;
    this.nascimento = nascimento;
  }
  
}