using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Equipamentos_OO
{
    class Program
    {
        static void Main(string[] args)
        {
            String op;
            String op_equipamentos;
            String op_chamados;
            Console.WriteLine("Gerenciamento 2.0");
            do
            {
                op = Menu();
                Console.Clear();
                switch (op)
                {
                    case "1":
                        do
                        {
                            op_equipamentos = MenuEquipamentos();
                            switch (op_equipamentos)
                            {
                                case "1":
                                    Servico.RegistrarEquipamento(-1);
                                    break;
                                case "2":
                                    Servico.VisualizarEquipamentos();
                                    break;
                                case "3":
                                    Servico.EditarEquipamento();
                                    break;
                                case "4":
                                    Servico.ExcluirEquipamento();
                                    break;
                                default:
                                    if (op_equipamentos != "S")
                                    {
                                        Console.WriteLine("\n ERRO: Digite um valor valido! \n");
                                    }
                                    Console.Clear();
                                    break;
                            }
                        } while (!op_equipamentos.Equals("S"));
                        break;
                    case "2":
                        if (Servico.lista_equipamentos.Count > 0)
                        {
                            do
                            {
                                op_chamados = MenuChamados();
                                switch (op_chamados)
                                {
                                    case "1":
                                        Servico.RegistrarChamado(-1);
                                        break;
                                    case "2":
                                        Servico.VisualizarChamados();
                                        break;
                                    case "3":
                                        Servico.EditarChamado();
                                        break;
                                    case "4":
                                        Servico.ExcluirChamado();
                                        break;
                                    default:
                                        if (op_chamados != "S")
                                        {
                                            Console.WriteLine("\n ERRO: Digite um valor valido! \n");
                                        }
                                        Console.Clear();
                                        break;
                                }
                            } while (!op_chamados.Equals("S"));
                        }

                        break;
                    default:
                        if (op != "S")
                        {
                            Console.WriteLine("\n ERRO: Digite um valor valido! \n");
                        }
                        break;
                }

            } while (!op.Equals("S"));


        }

        public static String Menu()
        {
            Console.WriteLine("\nInventário Disponível");
            Console.WriteLine("1 - Controle de Equipamentos");
            Console.WriteLine("2 - Controle de Chamados");
            Console.WriteLine("S - Sair");
            String str = Console.ReadLine().ToUpper();
            return str;
        }

        public static String MenuEquipamentos()
        {
            Console.WriteLine("Controle de Equipamentos");
            Console.WriteLine("1 - Registrar Equipamento");
            Console.WriteLine("2 - Visualizar Equipamentos");
            Console.WriteLine("3 - Editar um Equipamento");
            Console.WriteLine("4 - Excluir um Equipamento");
            Console.WriteLine("S - Sair");
            String str = Console.ReadLine().ToUpper();
            return str;
        }

        public static String MenuChamados()
        {
            Console.WriteLine("Controle de Chamados");
            Console.WriteLine("1 - Registrar um Chamados");
            Console.WriteLine("2 - Visualizar Chamados");
            Console.WriteLine("3 - Editar um Chamado");
            Console.WriteLine("4 - Excluir um Chamado");
            Console.WriteLine("S - Sair");
            String str = Console.ReadLine().ToUpper();
            return str;
        }

    }
}
