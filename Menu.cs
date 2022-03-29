using TreinoFim.Interface;
using TreinoFim.Interface2;
using TreinoFim.Interface3;
using TreinoFim.Models;
using static System.Console;
namespace TreinoFim
{
    public class Menu
    {
        public void MenuPrincipal()
        {
            while(true)
                  {
                  string Mensagem = "====== MENU ======"+
                  "\nBem vindo ao Menu: escolha uma das opções abaixo!"+
                  "\nPressione [1] Para acessar ao app 'Escola'"+
                  "\nPressione [2] Para acessar ao app 'Calculadora'"+
                  "\nPressione [3] Para acessar ao app 'Carteiro Medroso'"+
                  "\nPressione [4] Para acessar ao app 'Douglas Motors'"+                  
                  "\nPressione [X] Sair do app";

                  WriteLine(Mensagem);
                  string Opcao = ReadLine();
                        if (Opcao.Equals("x",StringComparison.InvariantCultureIgnoreCase))
                        {     
                              WriteLine("Obrigado por usar nossos aplicativos. Volte sempre!");
                              break;
                        }
                        switch (Opcao)
                        {
                              case "1":
                              TelaAluno Tela = new TelaAluno();
                              Tela.Tela();
                              break;

                              case "2":
                              TelaCalculadora Tela1 = new TelaCalculadora();
                              Tela1.Tela();
                              break;
                              
                              case "3":
                              TelaMorador tela2 = new TelaMorador();
                              tela2.Tela();
                              break;

                              case "4":
                              TelaConcessionaria Tela3 = new TelaConcessionaria();
                              Tela3.Tela();
                              break;

                              default:
                              WriteLine("Digite uma opção válida, retornando ao 'Menu'");
                              break;
                        }
                  WriteLine("Deseja continuar utilizando ao app? [S]Sim/[N]Nao ");
                  string Saida = ReadLine();
                        if (Saida.Equals("n",StringComparison.InvariantCultureIgnoreCase))
                        {
                              WriteLine("Obrigado por usar nossos aplicativos. Volte sempre!");
                              break;
                        }
                  }
        }
    }
}