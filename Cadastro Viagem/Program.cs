using System;
using System.Collections.Generic;
using System.Linq;

namespace Cadastro_Viagem
{
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
        static List<Caminhao> caminhoes = new List<Caminhao>();
        static List<Motorista> motoristas = new List<Motorista>();
        static List<Viagem> viagens = new List<Viagem>();

        static Motorista EncontrarMotorista(List<Motorista> motoristas, int id)
        {
            return motoristas.SingleOrDefault(x => x.IdMotorista == id);
        }
        static Caminhao EncontrarCaminhao(List<Caminhao> caminhoes, int id)
        {
            return caminhoes.SingleOrDefault(x => x.IdCaminhao == id);
        }
        static Viagem EncontrarViagem(List<Viagem> viagens, int id)
        {
            return viagens.SingleOrDefault(x => x.IdViagem == id);
        }


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
                        int idMotoristaAtualizar = Convert.ToInt32(Console.ReadLine());
                        Motorista MotoristaAtualizar = EncontrarMotorista(motoristas, idMotoristaAtualizar);
                        if (MotoristaAtualizar != null)
                        {
                            Console.WriteLine("Informe o nome do motorista");
                            MotoristaAtualizar.Nome = Console.ReadLine();
                            Console.WriteLine("Informe o endereço do motorista");
                            MotoristaAtualizar.End = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Motorista não encontrado.");
                        }
                        break;
                    case OpcoesCadastrais.RemoverMotorista:
                        Console.WriteLine("informe o Id do motorista");
                        int idMotoristaRemover = Convert.ToInt32(Console.ReadLine());
                        Motorista motoristaRemover = EncontrarMotorista(motoristas, idMotoristaRemover);
                        if(motoristaRemover != null)
                        {
                            motoristas.Remove(motoristaRemover);
                        }
                        else
                        {
                            Console.WriteLine("Motorista removido.");
                        }
                        break;

                    case OpcoesCadastrais.CadastrarCaminhao:
                        Caminhao caminhao = new Caminhao();
                        Console.WriteLine("Informe a marca do caminhão");
                        caminhao.Modelo = Console.ReadLine();
                        Console.WriteLine("Informe a placa do caminhão");
                        caminhao.Placa = Console.ReadLine();
                        caminhoes.Add(caminhao);
                        break;
                    case OpcoesCadastrais.AtualizarCaminhao:
                        Console.WriteLine("Informe o Id do caminhão");
                        int idCaminhaoAtualizar = Convert.ToInt32(Console.ReadLine());
                        Caminhao caminhaoatualizar = EncontrarCaminhao(caminhoes, idCaminhaoAtualizar);
                        if (caminhaoatualizar != null)
                        {
                            Console.WriteLine("Informe o modelo do caminhão");
                            caminhaoatualizar.Modelo = Console.ReadLine();
                            Console.WriteLine("Informe a placa do caminhão");
                            caminhaoatualizar.Placa = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Caminhão não encontrado.");
                        }
                        break;
                    case OpcoesCadastrais.RemoverCaminhao:
                        Console.WriteLine("informe o Id do motorista");
                        int idCaminhaoRemover = Convert.ToInt32(Console.ReadLine());
                        Caminhao caminhaoRemover = EncontrarCaminhao(caminhoes, idCaminhaoRemover);
                        if (caminhaoRemover != null)
                        {
                            caminhoes.Remove(caminhaoRemover);
                        }
                        else
                        {
                            Console.WriteLine("Caminhão removido.");
                        }
                        break;

                    case OpcoesCadastrais.CadastrarViagem:
                        Viagem viagem = new Viagem();
                        Console.WriteLine("Informe o Id do motorista");
                        int idMotoristaViagem = Convert.ToInt32(Console.ReadLine());
                        Motorista motoristaViagem = EncontrarMotorista(motoristas, idMotoristaViagem);
                        if (motoristaViagem != null)
                        {
                            Console.WriteLine("Motorista não encontrado.");
                            break;
                        }
                        
                        Console.WriteLine("informe o Id do caminhão");
                        int idCaminhaoViagem = Convert.ToInt32(Console.ReadLine());
                        Caminhao caminhaoViagem = EncontrarCaminhao(caminhoes, idCaminhaoViagem);
                        if (caminhaoViagem != null)
                        {
                            Console.WriteLine("Caminhão não encontrado.");
                            break;
                        }
                        
                        viagem.Caminhao = caminhaoViagem;
                        viagem.Motorista = motoristaViagem;
                        viagens.Add(viagem);
                        break;

                    case OpcoesCadastrais.AtualizarViagem:
                        Console.WriteLine("Informe o Id da viagem.");
                        int idViagemAtualizar = Convert.ToInt32(Console.ReadLine());
                        Viagem viagemAtualizar = EncontrarViagem(viagens, idViagemAtualizar);
                        if (viagemAtualizar != null)
                        {
                            Console.WriteLine("Informe o Id do novo motorista");
                            int idMotoristaNovoViagem = Convert.ToInt32(Console.ReadLine());
                            Motorista motoristaNovoViagem = EncontrarMotorista(motoristas, idMotoristaNovoViagem);
                            if (motoristaNovoViagem != null)
                            {
                                Console.WriteLine("Motorista não encontrado.");
                                break;
                            }
                            Console.WriteLine("informe o Id do caminhão.");
                            int idCaminhaoNovoViagem = Convert.ToInt32(Console.ReadLine());
                            Caminhao caminhaoNovoViagem = EncontrarCaminhao(caminhoes, idCaminhaoNovoViagem);
                            if (caminhaoNovoViagem != null)
                            {
                                Console.WriteLine("Caminhão não encontrado.");
                                break;
                            }
                            viagemAtualizar.Caminhao = caminhaoNovoViagem;
                            viagemAtualizar.Motorista = motoristaNovoViagem;
                        }
                        else
                        {
                            Console.WriteLine("Viagem não encontrada.");
                        }
                        break;
                    case OpcoesCadastrais.RemoverViagem:
                        break;
                }
                Console.WriteLine("Insira o tipo cadastro desejado: \n 0 - CadastrarMotorista \n 1 - AtualizarMotorista \n 2 - RemoverMotorista \n 3 - CadastrarCaminhao \n 4 - AtualizarCaminhao \n 5 - Remover Caminhão \n 6 - CadastrarViagem \n 7 - AtualizarViagem \n 8 - RemoverViagem \n 9 - Sair");
                opcaoCadastral = (OpcoesCadastrais)Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
