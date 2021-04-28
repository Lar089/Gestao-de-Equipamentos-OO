using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Equipamentos_OO
{
	class Equipamento
	{
		private int id;
		private string nome;
		private double preco;
		private string numero_serieo;
		private DateTime data_fabricacao;
		private string fabricante;

		public Equipamento()
		{
		}

		public Equipamento(int id, string nome, double preco, string numero_serieo, DateTime data_fabricacao, string fabricante)
		{
			this.Id = id;
			this.Nome = nome;
			this.Preco = preco;
			this.Numero_serieo = numero_serieo;
			this.Data_fabricacao = data_fabricacao;
			this.Fabricante = fabricante;
		}

		public int Id
		{
			get => id;
			set => id = value;
		}
		public string Nome
		{
			get => nome;
			set => nome = value;
		}
		public double Preco
		{
			get => preco;
			set => preco = value;
		}
		public string Numero_serieo
		{
			get => numero_serieo;
			set => numero_serieo = value;
		}
		public DateTime Data_fabricacao
		{
			get => data_fabricacao;
			set => data_fabricacao = value;
		}
		public string Fabricante
		{
			get => fabricante;
			set => fabricante = value;
		}

		public override string ToString() => $"Id do Equipamento: {Id}\n" + 
			$"Nome do Equipamento: {Nome}\n" + $"Preço do Equipamento: {Preco}\n" + 
			$"Número de Série do Equipamento: {Numero_serieo}\n" + 
			$"Data do Fabricante do Equipamento: {Data_fabricacao}\n" + 
			$"Fabricante Equipamento: {Fabricante}\n";

	}
}
