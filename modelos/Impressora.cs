using System;
namespace Modelos{
  
class Impressora {

  public static void print (Pessoa pessoa) {
    Console.WriteLine(
    "------------------------------ \n" +   
      "Nome:" + pessoa.Nome  + "\n" +
      "CPF:" +pessoa.Cpf + "\n"  + 
    "------------------------------"
    );
  }

  public static void print (Professor professor) {
    Console.WriteLine(
    "------------------------------ \n" +   
      "Nome:" + professor.Nome  + "\n" +
      "CPF:" +professor.Cpf + "\n"  +
      "Codigo:" +professor.Codigo + "\n"  +
    "------------------------------"
    );
  }
  
  public static void print (Aluno aluno) {
    Console.WriteLine(
    "------------------------------ \n" +   
      "Matricula:" + aluno.Matricula + "\n"+
      "Nome:" + aluno.Nome  + "\n" +
      "CPF:" +aluno.Cpf + "\n"  +
      "Periodo:" +aluno.Periodo + "\n"  +
    "------------------------------"
    );
  }


  
}  
}  