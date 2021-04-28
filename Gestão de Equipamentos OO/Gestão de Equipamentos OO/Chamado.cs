using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Equipamentos_OO
{
    class Chamado
    {
        private int id;
        private string titulo;
        private string descricao;
        private DateTime data_Abertura;
        private TimeSpan dias_Aberto;

        public Chamado()
        {
        }

        public Chamado(int id, string titulo, string descricao, DateTime data_Abertura, TimeSpan dias_Aberto)
        {
            this.id = id;
            this.titulo = titulo;
            this.descricao = descricao;
            this.data_Abertura = data_Abertura;
            this.dias_Aberto = dias_Aberto;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }
        public string Titulo
        {
            get => titulo;
            set => titulo = value;
        }
        public string Descricao
        {
            get => descricao;
            set => descricao = value;
        }
        public DateTime Data_Abertura
        {
            get => data_Abertura;
            set => data_Abertura = value;
        }
        public TimeSpan Dias_Aberto
        {
            get => dias_Aberto;
            set => dias_Aberto = value;
        }

        public override string ToString() => $"Id do Chamado: {Id}\n" +
            $"Título do Chamado: {Titulo}\n" + $"Descrição do Chamado: {Descricao}\n" +
            $"Data de Abertura do Chamado: {Data_Abertura}\n" + $"Dias em Aberto o Chamado: {Dias_Aberto}\n";
    }

}
