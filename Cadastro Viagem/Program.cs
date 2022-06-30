using System;
using System.Collections.Generic;
using System.Linq;

namespace Cadastro_Viagem
{
    enum Cadastro
    {
        Caminhao,
        Motorista,
        Viagem,
        sair
    }
    enum OpcoesCadastrais
    {
        CadastrarMotorista,
        AtualizarMotorista,
        RemoverMotorista,
        CadastrarCaminhao,
        AtualizarCaminhao,
        RemoverCaminhao,
        CadastrarViagem,
        AtualizarViagem,
        RemoverViagem,
        Sair
    }

    public class Program
    {
        List<Caminhao> caminhoes = new List<Caminhao>();
        static List<Motorista> motoristas = new List<Motorista>();
        List<Viagem> viagens = new List<Viagem>();


        static void Main(string[] args)
        {

            OpcoesCadastrais opcaoCadastral;
            Console.WriteLine("Insira o tipo cadastro desejado: \n 0 - CadastrarMotorista \n 1 - AtualizarMotorista \n 2 - RemoverMotorista \n 3 - CadastrarCaminhao \n 4 - AtualizarCaminhao \n 5 - Remover Caminhão \n 6 - CadastrarViagem \n 7 - AtualizarViagem \n 8 - RemoverViagem \n 9 - Sair");
            opcaoCadastral = (OpcoesCadastrais)Convert.ToInt32(Console.ReadLine());

            while (opcaoCadastral != OpcoesCadastrais.Sair)
            {

                switch (opcaoCadastral)
                {
                    case OpcoesCadastrais.CadastrarMotorista:
                        Motorista motorista = new Motorista();
                        Console.WriteLine("Informe o nome do motorista");
                        motorista.Nome = Console.ReadLine();
                        Console.WriteLine("Informe o Endereço do motorista");
                        motorista.End = Console.ReadLine();
                        motoristas.Add(motorista);
                        break;
                         case OpcoesCadastrais.AtualizarMotorista:
                        Console.WriteLine("Informe o Id do motorista");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Motorista mot
                    
                                               
                        break;
                }


                //if (opcaoCadastral == OpcoesCadastrais.Caminhao)
                //{

                //    Console.WriteLine("Insira a opção desejada: \n 0 - Cadastrar \n 1 - Atualizar \n 2 - Remover \n 3 - Menu Cadastro");
                //    OpcoesCadastrais opcoesCadastrais = (OpcoesCadastrais)Convert.ToInt32(Console.ReadLine());

                //    Console.WriteLine("Modelo do Caminhão:");
                //    string Modelo = Console.ReadLine();
                //    Console.WriteLine("Placa do Caminhão:");
                //    string Placa = Console.ReadLine();
                //    Console.WriteLine("Id do Caminhão:");
                //    int IdCaminhao = Convert.ToInt32(Console.ReadLine());
                //    Caminhao caminhao = new Caminhao(Modelo, Placa, IdCaminhao);
                //    caminhoes.Add(caminhao);

                //}
                //else if (cadastro == Cadastro.Motorista)
                //{
                //    Console.WriteLine("Nome do Motorista:");
                //    string Nome = Console.ReadLine();
                //    Console.WriteLine("Endereço do Motorista:");
                //    string End = Console.ReadLine();
                //    Console.WriteLine("Id do Motorista:");
                //    int IdMotorista = Convert.ToInt32(Console.ReadLine());
                //    Motorista motorista = new Motorista(Nome, End, IdMotorista);
                //    motoristas.Add(motorista);
                //}
                //else if (cadastro == Cadastro.Viagem)
                //{
                //    Console.WriteLine("Qual o Caminhão:");
                //    string Caminhao = Console.ReadLine();
                //    Console.WriteLine("Nome do Motorista:");
                //    string Motorista = Console.ReadLine();
                //    Console.WriteLine("Id da Viagem:");
                //    int IdViagem = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
