using System;
using Modelos;

class Aula3 {
 
  public static void Main (string[] args) {
    Aluno aluno1 = new Aluno {
      Matricula = "20212ENEL0225",
      Nome = "Matheus",
      Periodo = 0
    };
    Impressora.print(aluno1);
    Aluno aluno2 = new Aluno();
    Impressora.print(aluno2);
    Aluno aluno3 = new Aluno(2);
    Impressora.print(aluno3);
    Aluno aluno4 = new Aluno("20212enel0225", "Matheus");
    Impressora.print(aluno4);
    Aluno aluno5 = new Aluno("2022enel0380", "Nicole", 1);
    Impressora.print(aluno5);
    }  
}  