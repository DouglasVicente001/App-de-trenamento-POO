using static System.Console;
namespace TreinoFim.Interface2
{
    public interface IAluno
    {
        public string Aluno { get; set; }
        public string Matricula { get; set; }        
        public string Escola { get; set; }
        public string Universidade { get; set; }
        
         public void Estudante();
         public void Mensagem();
         
    }
}