using static System.Console;
namespace TreinoFim.Interface3
{   
      public class ModeloCarro : ICarros
      {
            public string Carro { get;set;}
            public string Cor { get;set;}
            public string Ano { get;set;}
            public string Estado { get;set;}
            public int Valor { get; set; }
            public string TipoVeiculo { get; set; }

             public void TipoCarro()
            {
                WriteLine("Informe o tipo do veículo 'nome do veículo'");
                Carro = ReadLine();
            }
            public void Cores()
            {
                WriteLine("Informe a cor do veículo");
                Cor = ReadLine();
            }
            public void AnoCarro()
            {
                WriteLine("Informe o modelo do veículo Ret/Sedan");
                Ano = ReadLine();
            }
            public void EstadoCarro()
            {
                WriteLine("Informe o estado  do veículo 'usado,seminovo,novo'");
                Estado = ReadLine();
            }
            
            public void ValorCarro()
            {
                WriteLine("Insira o valor de tabela do veículo: ");
                Valor = int.Parse(ReadLine());
            }
            public void Tipo()
            {
                if(Valor < 30000)
                {
                TipoVeiculo = "O carro é de classe 'Popular'";
                    }
                    else if (Valor >= 30000 && Valor <70000)
                    {
                        TipoVeiculo = "O carro é de classe 'Media'";
                    }   
                        else if (Valor >= 70000 && Valor <150000)
                        {
                        TipoVeiculo = "O carro é de classe 'Alta'";
                        }
                            else
                            {
                            TipoVeiculo = "O carro é de classe 'Luxo'!!! Sim se Deus quiser um dia eu tambem vou ter ^^";
                            }

                }
            public void InfoTotal()
            {
                WriteLine($"Carro: {Carro}"+
                $"\nCor: {Cor}"+
                $"\nAno do Veículo: {Ano}"+
                $"\nEstado Do Veículo: {Estado}"+
                $"\nValor de Tabela do Veículo: {Valor}"+
                $"\nTipo do veículo: {TipoVeiculo}");
            }
            
      }
}