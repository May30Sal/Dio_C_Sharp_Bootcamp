using System;
using DesafioProjeto2;
using DesafioProjeto2.classes;

namespace DesafioProjeto2
{
	class Program
	{
		static SerieRepositorio repositorio = new SerieRepositorio();
		static void Main(string[] args)
        {
			Console.WriteLine(@$"
-------------------------------------
|      Bem vindo ao sistema de      |
|       cadastro de Séries          |
-------------------------------------
");
			Console.Write("Carregando ");
			Console.BackgroundColor = ConsoleColor.White;

			for (var i = 0; i < 10; i++)
			{
				Console.Write(". ");
				Thread.Sleep(500);
			}

			Console.ResetColor();

			string? opcaoUsuario;
			do 
			{
				Console.Clear();
				Console.WriteLine(@$"
---------------------------------------------
|       Escolha uma das opções abaixo:      |
|-------------------------------------------|
|       1 - Inserir Série                   |
|       2 - Listar Série                    |
|       3 - Atualizar Série                 |
|       4 - Excluir Série                   |
|       5 - Visualizar Série                |
|                                           |
|       0 - Sair do Sistema                 |
---------------------------------------------
");

				opcaoUsuario = Console.ReadLine();
				switch (opcaoUsuario)
				{
					case "1":
						Console.Clear();
						Console.WriteLine("Inserir nova série");
						foreach (int i in Enum.GetValues(typeof(Genero)))
						{
							Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
						}
						Console.Write("Digite o gênero entre as opções acima: ");
						int entradaGenero = Convert.ToInt32(Console.ReadLine());

						Console.Write("Digite o Título da Série: ");
						string? entradaTitulo = Console.ReadLine();

						Console.Write("Digite a Descrição da Série: ");
						string? entradaDescricao = Console.ReadLine();

						Series novaSerie = new Series(
													Id: repositorio.ProximoId(),
													Genero: (Genero)entradaGenero,
													Titulo: entradaTitulo,
													Descricao: entradaDescricao);
						repositorio.Insere(novaSerie);
						break;
					case "2":
						Console.WriteLine("Listar séries");

						var lista = repositorio.Lista();

						if (lista.Count == 0)
						{
							Console.WriteLine("Nenhuma série cadastrada.");
							return;
						}
						foreach (var series in lista)
						{
							var excluido = series.retornaExcluido();
							if (!excluido)
							{
								Console.WriteLine("#ID {0}: - {1}", series.retornaId(), series.retornaTitulo());
							}
						}
						Thread.Sleep(3000);
						break;
					case "3":
						atualizaSerie();
						break;
					case "4":
						Console.Write("Digite o id da série: ");
						int IndiceSerie = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine($"Tem certeza que deseja excluir?");
						Console.ReadLine();
						repositorio.Exclui(IndiceSerie);
						Console.WriteLine("Série Excluída com sucesso!");
						break;
					case "5":
						
						Console.Write("Digite o id da série: ");
						int indiceDaSerie = Convert.ToInt32(Console.ReadLine());

						var serie = repositorio.RetornaPorId(indiceDaSerie);

						Console.WriteLine(serie);
						Thread.Sleep(3000);
						break;
					case "0":
							Console.Clear();
							Console.WriteLine("Obrigada por utilizar nosso sistema!");
							Thread.Sleep(2000);
							break;
					default:
							Console.Clear();
							Console.WriteLine($"Opção Inválida. Digite outra opção");
							Thread.Sleep(2000);
							break;
				} 
			} while (opcaoUsuario != "0");
		}

		private static void atualizaSerie()
		{
			Console.Write("Digite o id da série: ");
			int indiceSerie = Convert.ToInt32(Console.ReadLine());

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}

			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = Convert.ToInt32(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string? entradaTitulo = Console.ReadLine();

			Console.Write("Digite a Descrição da Série: ");
			string? entradaDescricao = Console.ReadLine();

			Series atualizaSerie = new Series(
				Id: repositorio.ProximoId(),
				Genero: (Genero)entradaGenero,
				Titulo: entradaTitulo,
				Descricao: entradaDescricao);
			repositorio.Atualiza(indiceSerie, atualizaSerie);
		}
	}
}




	





					

				