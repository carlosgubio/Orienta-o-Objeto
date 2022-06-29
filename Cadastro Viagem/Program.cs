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
        Cadastrar,
        Atualizar,
        Remover,
        MenuCadastro
    }
    class Program
    {
        static List<Caminhao> ListaCaminhao(List<Caminhao> caminhao)
        {
            List<Caminhao> copiaCaminhao = new List<Caminhao>();
            foreach (Caminhao p in caminhao)
            {
                copiaCaminhao.Add(new Caminhao(p.Modelo, p.Placa, p.IdCaminhao));
            }
            return copiaCaminhao;
        }

        static List<Motorista> ListaMotorista(List<Motorista> motorista)
        {
            List<Motorista> copiaMotorista = new List<Motorista>();
            foreach (Motorista p in motorista)
            {
                copiaMotorista.Add(new Motorista(p.Nome, p.End, p.IdMotorista));
            }
            return copiaMotorista;
        }
        static List<Viagem> ListaViagem(List<Viagem> viagem)
        {
            List<Viagem> copiaviagem = new List<Viagem>();
            foreach (Viagem p in viagem)
            {
                copiaviagem.Add(new Viagem(p.IdViagem));
            }
            return copiaviagem;
        }


        static void Main(string[] args)
        {
            List<Caminhao> vendedor = new List<Caminhao>();
            List<Motorista> cliente = new List<Motorista>();
            List<Viagem> vendas = new List<Viagem>();

            Console.WriteLine("Insira o tipo cadastro desejado: \n 0 - Caminhão \n 1 - Motorista \n 2 - Viagem \n 3 - Sair");
            Cadastro cadastro = (Cadastro)Convert.ToInt32(Console.ReadLine());

            while (cadastro != Cadastro.sair)
            {
                if (cadastro == Cadastro.Caminhao)
                {

                    Console.WriteLine("Insira a opção desejada: \n 0 - Cadastrar \n 1 - Atualizar \n 2 - Remover \n 3 - Menu Cadastro");
                    OpcoesCadastrais opcoesCadastrais = (OpcoesCadastrais)Convert.ToInt32(Console.ReadLine());

                    //if (opcoesCadastrais == OpcoesCadastrais.MenuCadastro)
                    //{
                    //    enum.Cadastro;
                    //}
                    Console.WriteLine("Modelo do Caminhão:");
                    string Modelo = Console.ReadLine();
                    Console.WriteLine("Placa do Caminhão:");
                    string Placa = Console.ReadLine();
                    Console.WriteLine("Id do Caminhão:");
                    int IdCaminhao = Convert.ToInt32(Console.ReadLine());
                }
                else if (cadastro == Cadastro.Motorista)
                {
                    Console.WriteLine("Nome do Motorista:");
                    string Nome = Console.ReadLine();
                    Console.WriteLine("Endereço do Motorista:");
                    string End = Console.ReadLine();
                    Console.WriteLine("Id do Motorista:");
                    int IdMotorista = Convert.ToInt32(Console.ReadLine());
                }
                else if (cadastro == Cadastro.Viagem)
                {
                    Console.WriteLine("Qual o Caminhão:");
                    string Caminhao = Console.ReadLine();
                    Console.WriteLine("Nome do Motorista:");
                    string Motorista = Console.ReadLine();
                    Console.WriteLine("Id da Viagem:");
                    int IdViagem = Convert.ToInt32(Console.ReadLine());
                }

                
            }
        }
    }
}
