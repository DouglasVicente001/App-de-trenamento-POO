using static System.Console;
namespace TreinoFim.Interface
{
    public class TelaCalculadora
    {
        public void Tela()
        {   
            while(true)
            {
            string Mensagem = "====== Calculadora ======"+
            "\n[1] Soma"+
            "\n[2] Subtração"+
            "\n[3] Multiplicação"+
            "\n[4] Divisao"+
            "\n[5] Sair do app 'Calculadora'";
            WriteLine(Mensagem);
            string Opcao = ReadLine();
            if (Opcao == "5")
            {
                WriteLine("Obrigado por utilizar nossos serviços");
                break;
            }


            Calculadora Calculo = new Calculadora();
            switch(Opcao)
            {
            case "1":
            Calculo.Soma();
            break;

            case "2":
            Calculo.Subtracao();
            break;

            case "3":
            Calculo.Multiplicacao();
            break;

            case "4":
            Calculo.Divisao();
            break;

            default:
            WriteLine("Digite um número válido, retornando para menu 'Calculadora'");
            break;
            }


            WriteLine("Deseja continuar  na aplicação 'Calculadora'?  [S]Sim/[N]Nao ");
            string Saida = ReadLine ();
                if (Saida.Equals("n",StringComparison.InvariantCultureIgnoreCase))
                {
                    WriteLine("Obrigado, espero que tenha gostado do app 'Calculadora' :)");
                    break;
                }
            }
        }
    }
}