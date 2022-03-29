using static System.Console;
namespace TreinoFim.Interface2
{
    public class TelaAluno
    {
        public void Tela()
        {
            while(true)
            {

            string Mensagem = "====== ESCOLA ======" + "\nDigite a escolaridade do aluno:"+
            "\n[1] Aluno Fundamental"+
            "\n[2] Aluno Medio"+
            "\n[3] Aluno Superior"+
            "\n[4] Sair do app 'ESCOLA'";

            WriteLine(Mensagem);
            

            string Opcao = ReadLine();
            if (Opcao == "4")
            {
                WriteLine("Obrigado por utilizar nossos serviços. :)");
                break;
            }
            switch(Opcao)
            {
                case "1" : 
                AlunoFundamental Aluno1 = new AlunoFundamental();
                Aluno1.Estudante();
                Aluno1.Mensagem();
                break;

                case "2" : 
                AlunoMedio Aluno2 = new AlunoMedio();
                Aluno2.Estudante();
                Aluno2.Mensagem();
                break;

                case "3" : 
                AlunoSuperior Aluno3 = new AlunoSuperior();
                Aluno3.Estudante();
                Aluno3.Mensagem();
                break;

                default:
                WriteLine ("Informe uma oção válida [1]/[2]/[3]. Retornando você ao Menu.");
                break;
            }

                WriteLine("Deseja Continuar inserindo Alunos? [S]Sim/ [N]Nao ");
                string Saida = ReadLine();
                if (Saida.Equals("n",StringComparison.InvariantCultureIgnoreCase))
                {
                    WriteLine("Obrigado, espero que tenha gostado do app 'Escola' :)");
                    break;
                }

            }
        }
    }
}