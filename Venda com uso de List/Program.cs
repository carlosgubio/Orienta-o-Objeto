﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Venda_com_uso_de_List
{
    enum TipoCadastro
    {
        CadastrarVendedor,
        CadastrarCliente,
        CadastrarProduto,
        InserirProdutoNoCarrinho,
        CriarUmaVenda,
        LimparCarrinho,
        FinalizarVenda
    }
    class Program
    {
        static List<Produto> CopiarProdutosParaOutraLista(List<Produto> produtos)
        {
            List<Produto> produtosCopia = new List<Produto>();
            foreach (Produto p in produtos)
            {
                produtosCopia.Add(new Produto(p.Codigo, p.DescricaoDoProduto, p.Marca, p.Preco));
            }
            return produtosCopia;
        }
        static Produto EncontrarProduto(List<Produto> produtos, int codigo)
        {
            Produto produto = null;
            for (int i = 0; i < produtos.Count; i++)
            {
                if (produtos[i].Codigo == codigo)
                {
                    produto = produtos[i];
                }
            }
            return produto;
        }
        static Vendedor EncontrarVendedor(List<Vendedor> vendedores, int codigo)
        {
            Vendedor vendedor = null;
            for (int i = 0; i < vendedores.Count; i++)
            {
                if (vendedores[i].Codigo == codigo)
                {
                    vendedor = vendedores[i];
                }
            }
            return vendedor;
        }
        static Cliente EncontrarClientes(List<Cliente> clientes, int codigo)
        {
            Cliente cliente = null;
            for (int i = 0; i < clientes.Count; i++)
            {
                if (clientes[i].Codigo == codigo)
                {
                    cliente = clientes[i];
                }
            }
            return cliente;
        }
        static void Main(string[] args)
        {
            

            List<Vendedor> vendedor = new List<Vendedor>();
            List<Cliente> cliente = new List<Cliente>();
            List<Venda> vendas = new List<Venda>();
            Venda venda;
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            List<Produto> produto = new List<Produto>();
            carrinho.Produtos.Add(new Produto());
            Venda vendaAtual = new Venda();
            Cliente clienteAtual = new Cliente();
            Vendedor vendedorAtual = new Vendedor();



            vendedor.Add(new Vendedor(0,"Mario", 10));
            vendedor.Add(new Vendedor(1,"Jorge", 11));
            cliente.Add(new Cliente(0,"Luana", 8521455811, "Rua H, 123 Itjaí-SC"));
            cliente.Add(new Cliente(1,"Janaina", 4589512255, "Av. W, 45 Itajaí-SC"));
            produto.Add(new Produto(0,"Arroz", "Lagoano", 5.80));
            produto.Add(new Produto(1,"Feijão", "Lagoano", 6.20));
            produto.Add(new Produto(2,"Macarrão", "Lagoano", 3.00));
            produto.Add(new Produto(3,"Óleo", "Lagoano", 4.50));
            produto.Add(new Produto(4,"Leite", "LAgoano", 4.80));
            produto.Add(new Produto(5,"Açúcar", "Lagoano", 5.30));
           

            Console.WriteLine("Informe a opção desejada:\n 0 - Cadastrar um Vendedor \n 1 - Cadastrar um Cliente \n 2 - Cadastrar um Produto \n 3 - Inserir Produtos no Carrinho \n 4 - Criar uma Venda \n 5 - Limpar Carrinho \n 6 - Finalizar Venda");
            TipoCadastro tipoCadastro = (TipoCadastro)Convert.ToInt32(Console.ReadLine());

            if (tipoCadastro == TipoCadastro.CadastrarVendedor)
            {
                Console.WriteLine("Digite o nome do vendedor:");
                string Nome = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Digite o CPF do vendedor:");
                string CPF = Convert.ToString(Console.ReadLine());
            }
            else if (tipoCadastro == TipoCadastro.CadastrarCliente)
            {
                Console.WriteLine("Digite o nome do cliente:");
                string Cliente = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Digite o CPF do cliente:");
                string CPF = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Digite o endereço do cliente:");
                string Endereco = Convert.ToString(Console.ReadLine());
            }
            else if (tipoCadastro == TipoCadastro.CadastrarProduto)
            {
                Console.WriteLine("Digite a descrição do produto:");
                string Descricao = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Digite a marca do produto:");
                string Marca = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Digite o preço do produto:");
                double Preco = Convert.ToDouble(Console.ReadLine());
            }
            else if (tipoCadastro == TipoCadastro.InserirProdutoNoCarrinho)
            {
                int codigo = Convert.ToInt32(Console.ReadLine());
                Produto produtoSelecionado = EncontrarProduto(produto, codigo);
                carrinho.Produtos.Add(produtoSelecionado);
                carrinho.Produtos = produto;
                if(produtoSelecionado != null)
                {
                    carrinho.Produtos.Add(new Produto(produtoSelecionado.Codigo, produtoSelecionado.DescricaoDoProduto, produtoSelecionado.Marca, produtoSelecionado.Preco));
                    Console.WriteLine("Produto adicionado ao carrinho.");
                }
            }
            else if (tipoCadastro == TipoCadastro.CriarUmaVenda)
            {
                //venda = new Venda();
                //venda.ListaDeProdutos = carrinho.Produtos;
                //Console.WriteLine(p.DescricaoDoProduto + " " + p.Marca + " R$ " + p.Preco);
                //Console.WriteLine("Informe o número referente ao produto desejado:\n 0 - Arroz \n 1 - Feijão \n 2 - Macarrão \n 3 - Óleo \n 4 - Leite \n 5 - Açucar \n");
                //Produtos produtos = (Produtos)Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Insira o código do produto:");
                int codigoCliente = Convert.ToInt32(Console.ReadLine());
                int codigoVendedor = Convert.ToInt32(Console.ReadLine());
                Cliente cSelecionado = EncontrarClientes(cliente, codigoCliente);
                Vendedor vSelecionado = EncontrarVendedor(vendedor, codigoVendedor);

               if(cSelecionado != null && vSelecionado != null)
                {
                    vendaAtual.Cliente = cSelecionado;
                    vendaAtual.Vendedor = vSelecionado;
                    if(carrinho.Produtos !=null && carrinho.Produtos.Any())
                    {
                        vendaAtual.ListaDeProdutos = carrinho.Produtos;
                    }
                }
                
                //int codigo = Convert.ToInt32(Console.ReadLine());
                //Produto produtoEncontrado = EncontrarProduto(produto, codigo);
                //carrinho.Produtos.Add(produtoEncontrado);
                //carrinho.Produtos = produto;
            }
            else if (tipoCadastro == TipoCadastro.LimparCarrinho)
            {
                Console.WriteLine("Não há itens no seu Carrinho:");
                string LimparCarrinho = Convert.ToString(Console.ReadLine());
            }
            else if (tipoCadastro == TipoCadastro.FinalizarVenda)
            {
                vendaAtual.ListaDeProdutos = CopiarProdutosParaOutraLista(carrinho.Produtos);
                vendaAtual.Cliente = new Cliente(clienteAtual.Codigo, clienteAtual.Nome, clienteAtual.CPF, clienteAtual.Endereco);
                vendaAtual.Vendedor = new Vendedor(vendedorAtual.Codigo, vendedorAtual.Nome, vendedorAtual.CodigoCracha);
                vendaAtual.Finalizada = true;
                vendas.Add(new Venda());
                Console.WriteLine("Venda finalizada.");
            }
        }
    }
}
