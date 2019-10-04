using System ;
using System.IO;
using System.Collections.Generic;

class ConexaoDados{

  public static void escreveMovimentacao(Carro carro){

    StreamWriter saida;
    saida = File.AppendText("dados.txt");
    saida.WriteLine(carro.imprimirCarro());
    saida.Close();
  }
}