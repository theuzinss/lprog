namespace Modelos {
  
   class Aluno : Pessoa {
     private int periodo;

     public int Periodo{
       get => this.periodo;
       set {
         if (value > 0){
        this.periodo = value;
      } else {
        this.periodo = 1;
         
       }
     }
   }
     
     public string Matricula{
       get; set;
     }
     
    public Aluno() : this(0) {
    
    }
     
    public Aluno(int periodo){
        this.Periodo = periodo;
    }

     public Aluno(string matricula, string Nome)
          : this() {
      this.Matricula = matricula; 
      this.Nome = Nome;  
            
    }
    public Aluno(string Matricula, string Nome, int periodo) {
      this.Matricula = Matricula; 
      this.Nome = Nome;  
    }      
  

     
    public bool Matricular(Disciplina disciplina) {
      return this.periodo == disciplina.semestre;
    }
  }
}
