using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Equipamentos_OO
{
	class Servico
	{
		private static int aux_e = 0;
		public static List<String> lista_equipamentos = new List<String>();
		private static List<String> lista_chamados = new List<String>();

		public static void ExcluirChamado()
		{
			Console.Clear();
			VisualizarChamados();
			if (lista_chamados.Count != 0)
			{
				Console.Write("Digite o número do ID que deseja excluir: ");
				int idSelecionado = Convert.ToInt32(Console.ReadLine());
				int cont = 0;
				if (idSelecionado >= 0)
				{
					foreach (var cha_value in lista_chamados)
					{
						if (VerificaId(cha_value, 5, $"Id do Chamado: {idSelecionado}"))
						{
							Console.Clear();
							lista_chamados.RemoveAt(cont);
							Console.ForegroundColor = ConsoleColor.Green;
							Console.WriteLine("\nSUCESSO: Chamado excluido com sucesso!\n");
							Console.ResetColor();
							cont++;
							break;
						}
					}
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("ERRO: O número não existe!");
					Console.ResetColor();
				}
			}
		}

		public static void EditarChamado()
		{
			Console.Clear();

			VisualizarChamados();

			Console.WriteLine();

			Console.Write("Digite o número do chamado que deseja editar: ");
			int idSelecionado = Convert.ToInt32(Console.ReadLine());
			int cont = 0;
			if (idSelecionado >= 0)
			{
				foreach (var cha_value in lista_chamados)
				{
					if (VerificaId(cha_value, 5, $"Id do Chamado: {idSelecionado}"))
					{
						Console.Clear();
						RegistrarChamado(idSelecionado);
						lista_chamados.RemoveAt(cont);
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine("\nSUCESSO: Chamado excluido com sucesso!\n");
						Console.ResetColor();
						cont++;
						break;
					}
				}
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("ERRO: O número não existe!");
				Console.ResetColor();
			}
		}

		public static void VisualizarChamados()
		{
			Console.Clear();
			int x = 0;
			foreach (var item in lista_chamados)
			{
				x++;
				Console.WriteLine(item);
			}

			Console.ReadLine();
		}

		public static void RegistrarChamado(int posicao)
		{
			Console.Clear();

			VisualizarEquipamentos();
			Chamado chamado = new Chamado();

			Console.Write("Digite o titulo do chamado: ");
			chamado.Titulo = Console.ReadLine();

			Console.Write("Digite a descricao do chamado: ");
			chamado.Descricao = Console.ReadLine();
			String nome = null;
			do {
				VisualizarEquipamentos();
				Console.Write("Digite o nome do equipamento: ");
				nome= Console.ReadLine();
				if(!nome.Equals(null))
				{
					foreach (var eq_value in lista_equipamentos)
					{
						if (VerificaId(eq_value, 5, $"Nome do Equipamento: {nome}"))
						{
							Console.ForegroundColor = ConsoleColor.Green;
							Console.WriteLine("\nSUCESSO: Equipamento selecionado com sucesso!\n");
							Console.ResetColor();
							break;
						}
					}
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("ERRO: O número não existe!");
					Console.ResetColor();
				}
			} while (nome.Equals(null));

			bool datainvalida = false;
			do
			{
				try
				{
					Console.Write("Digite a data de abertura do chamado: ");
					chamado.Data_Abertura = Convert.ToDateTime(Console.ReadLine());
					chamado.Dias_Aberto = DateTime.Now - chamado.Data_Abertura;
					break;
				}
				catch
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("ERRO: Data inválida!");
					Console.ResetColor();
					datainvalida = true;
				}
			} while (datainvalida);

			if (posicao == -1)
			{
				chamado.Id = aux_e++;
				lista_chamados.Add(chamado.ToString() + $"Nome do Equipamento: {nome}");
			}
			else
			{
				chamado.Id = posicao;
				lista_chamados.Insert(posicao, chamado.ToString() + $"Nome do Equipamento: {nome}");
			}
			Console.Clear();

		}

		public static void EditarEquipamento()
		{
			Console.Clear();
			VisualizarEquipamentos();
			if (lista_equipamentos.Count != 0)
			{
				Console.Write("Digite o número do ID que deseja editar: ");
				int idSelecionado = Convert.ToInt32(Console.ReadLine());
				int cont = 0;
				if (idSelecionado >= 0)
				{
					foreach(var eq_value in lista_equipamentos){
						if (VerificaId(eq_value, 5, $"Id do Equipamento: {idSelecionado}"))
						{
							Console.Clear();
							RegistrarEquipamento(idSelecionado);
							lista_equipamentos.RemoveAt(cont);
							Console.ForegroundColor = ConsoleColor.Green;
							Console.WriteLine("\nSUCESSO: Equipamento editado com sucesso!\n");
							Console.ResetColor();
							cont++;
							break;
						}
					}
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("ERRO: O número não existe!");
					Console.ResetColor();
				}
			}

		}

		public static void ExcluirEquipamento()
		{
			Console.Clear();
			VisualizarEquipamentos();
			if (lista_equipamentos.Count != 0)
			{
				Console.Write("Digite o número do ID que deseja excluir: ");
				int idSelecionado = Convert.ToInt32(Console.ReadLine());
				int cont = 0;
				if (idSelecionado >= 0)
				{
					foreach (var eq_value in lista_equipamentos)
					{
						if (VerificaId(eq_value, 5, $"Id do Equipamento: {idSelecionado}"))
						{
							Console.Clear();
							lista_equipamentos.RemoveAt(cont);
							Console.ForegroundColor = ConsoleColor.Green;
							Console.WriteLine("\nSUCESSO: Equipamento excluido com sucesso!\n");
							Console.ResetColor();
							cont++;
							break;
						}
					}
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("ERRO: O número não existe!");
					Console.ResetColor();
				}
			}

		}

		public static void VisualizarEquipamentos()
		{
			Console.Clear();
			int x = 0;
			foreach (var item in lista_equipamentos)
			{
				x++;
				Console.WriteLine(item);
			}
		}

		public static void RegistrarEquipamento(int posicao)
		{
			Console.Clear();
			Equipamento equipamento = new Equipamento();
			bool nomeInvalido = false;
			do
			{
				Console.Write("Digite o nome do equipamento: ");
				equipamento.Nome = Console.ReadLine();
				if (equipamento.Nome.Length < 6)
				{
					nomeInvalido = true;
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Nome inválido. No mínimo 6 caracteres");
					Console.ResetColor(); ;
				}
				else
				{
					nomeInvalido = false;
				}

			} while (nomeInvalido);


			Console.Write("Digite o preço do equipamento: ");
			equipamento.Preco = Convert.ToDouble(Console.ReadLine());

			Console.Write("Digite o número do equipamento: ");
			equipamento.Numero_serieo = Console.ReadLine();

			bool datainvalida = false;
			do
			{

				try
				{
					Console.Write("Digite a data de fabricação do equipamento: ");
					equipamento.Data_fabricacao = Convert.ToDateTime(Console.ReadLine());
					break;
				}
				catch
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("ERRO: Data inválida!");
					Console.ResetColor();
					datainvalida = true;
				}
			} while (datainvalida);

			Console.Write("Digite o fabricante do equipamento: ");
			equipamento.Fabricante = Console.ReadLine();

			if (posicao == -1)
			{
				equipamento.Id = aux_e++;
				lista_equipamentos.Add(equipamento.ToString());
			}
			else
			{
				equipamento.Id = posicao;
				lista_equipamentos.Insert(posicao, equipamento.ToString());
			}
			Console.Clear();

		}

		public static bool VerificaId(String item, int tamanho_lista, String str_comparacao)
		{
			StringReader item_lista = new StringReader(item);
			String[] linha_lista  = new string[tamanho_lista];
			for (int i = 0; i < tamanho_lista; i++)
			{
				linha_lista[i] = item_lista.ReadLine();
				Console.WriteLine($"resultado da linha: {linha_lista[i]}");
                if (linha_lista[i].Equals(str_comparacao))
                {
					return true;
                }
			}
			return false;
		}
	}

}