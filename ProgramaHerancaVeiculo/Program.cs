using System;

namespace ProgramaHerancaVeiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipo de Veículo:");
            string Veiculo = Console.ReadLine();
            Console.WriteLine(); Console.WriteLine("Chassi:");
            string Chassi = Console.ReadLine();
            Console.WriteLine(); Console.WriteLine("Ano:");
            string Ano = Console.ReadLine();
            Console.WriteLine(); Console.WriteLine("Modelo:");
            string Modelo = Console.ReadLine();
            Console.WriteLine(); Console.WriteLine("Marca:");
            string Marca = Console.ReadLine();
            Console.WriteLine(); Console.WriteLine("Preço:");
            string Preco = Console.ReadLine();
            Console.WriteLine(); Console.WriteLine("Motor:");
            string Motor = Console.ReadLine();
            Console.WriteLine(); Console.WriteLine("Tipo de Tração:");
            string TipoDeTracao = Console.ReadLine();
            Console.WriteLine(); Console.WriteLine("Tipo de Uso:");
            string TipoDeUso = Console.ReadLine();
            Console.WriteLine(); Console.WriteLine("Tipo de Caçamba:");
            String TipoDeCacamba = Console.ReadLine();
            Console.WriteLine(); Console.WriteLine("Quantidade de Eixos:");
            string Eixos = Console.ReadLine();
            Console.WriteLine(); Console.WriteLine("Peso Bruto:");
            string PesoBruto = Console.ReadLine();
            Console.WriteLine(); Console.WriteLine("Modulo de Carga:");
            string ModuloDeCarga = Console.ReadLine();
            Console.WriteLine(); Console.WriteLine("Relação:");
            string Relacao = Console.ReadLine();
            Console.WriteLine(); Console.WriteLine("Manetes:");
            string Manetes = Console.ReadLine();
            Console.WriteLine(); Console.WriteLine("Tipo de Parida:");
            string TipoDePartida = Console.ReadLine();


            Trator veiculo = new Trator(TipoDeTracao, TipoDeUso, TipoDeCacamba);

            Console.WriteLine("Nome:" + Veiculo);
            Console.WriteLine("Chassi:" + Chassi);
            Console.WriteLine("Ano:" + Ano);
            Console.WriteLine("Modelo:" + Modelo);
            Console.WriteLine("Marca:" + Marca);
            Console.WriteLine("Preco:" + Preco);
            Console.WriteLine("Motor:" + Motor);
            Console.WriteLine("Tipo de tração:" + TipoDeTracao);
            Console.WriteLine("Tipo de Uso:" + TipoDeUso);
            Console.WriteLine("Tipo de Caçamba:" + TipoDeCacamba);
            //Console.WriteLine("Eixos:" + Eixos);
            //Console.WriteLine("Peso Bruto:" + PesoBruto);
            //Console.WriteLine("Modulo de Carga:" + ModuloDeCarga);
            //Console.WriteLine("Relacao:" + Relacao);
            //Console.WriteLine("Manetes:" + Manetes);
            //Console.WriteLine("Tipo de Partida:" + TipoDePartida);
















        }
    }
}
