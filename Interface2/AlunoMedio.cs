using static System.Console;
namespace TreinoFim.Interface2
{
      public class AlunoMedio : IAluno
      {
            public string Aluno { get ; set; }
            public string Matricula { get; set; }
            public string Escola {get; set; }
            public string Universidade { get ;set; }
            public  void Estudante()
         {
             WriteLine("Digite o nome do Auno: ");
             Aluno = ReadLine();

             WriteLine("Insira o número de matrícula: ");
             Matricula = ReadLine();

             WriteLine("Digite a Escola: ");
             Escola = ReadLine();

            
         }

         public void Mensagem()
         {
             WriteLine("\n\n=== Informação do Aluno === "+$"\nNome: {Aluno}"+$"\nMatricula: {Matricula}"+$"\nEscola: {Escola}");
         }

      }
}