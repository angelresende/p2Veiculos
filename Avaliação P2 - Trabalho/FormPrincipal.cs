using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliação_P2___Trabalho
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private int gerarChassi() // gerar numero de chassi automaticamente
        {
            Random o_Rand = new Random();
            int vlrRand;
            vlrRand = o_Rand.Next(1000, 9999);
            return vlrRand;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CaminhaoUsado o_CaminhaoUsado = new CaminhaoUsado();
            float depreciacao;

            o_CaminhaoUsado.Modelo = "Volvo FH 540";
            o_CaminhaoUsado.AnoFab = 2011;
            o_CaminhaoUsado.Valor = 36.785f;
            o_CaminhaoUsado.Capacidade = 5000;
            o_CaminhaoUsado.NnroEixos = 2;
            depreciacao = o_CaminhaoUsado.calcularDepreciacao();

            o_CaminhaoUsado.ImprimirDados();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Veiculo o_Veiculo = new Veiculo();

            /*int menu = 0;
            int menu_carro;
            VeiculoUsado automovel = new VeiculoUsado();

            Console.WriteLine("Informe a Marca do Veicúlo: ");
            automovel.Marca = Console.ReadLine();
            Console.WriteLine("Informe o modelo do Veicúlo: ");
            automovel.Modelo = Console.ReadLine();
            Console.WriteLine("Informe a Cor do Veicúlo: ");
            automovel.Cor = Console.ReadLine();

            automovel.Chassi = gerarChassi();

            Console.WriteLine("Informe o Nome do proprietário do Veicúlo: ");
            automovel.Proprietario = Console.ReadLine();
            Console.WriteLine("Informe o numero de portas do Veicúlo: ");
            automovel.NumPortas = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Informe a Velocidade Máxima  do Veicúlo: ");
            automovel.VelocidadeMaxima = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Informe o numero de marchas do Veicúlo: ");
            automovel.NumMarchas = Int32.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("---Escolha uma ação---" +
                                  "\n 1-Acelerar" +
                                  "\n 2-Freiar" +
                                  "\n 3-Alterar Marcha" +
                                  "\n 4-Mostrar Dados");
                menu_carro = Int32.Parse(Console.ReadLine());

                if (menu_carro == 1)
                {
                    automovel.Acelerar(10);
                }
                if (menu_carro == 2)
                {
                    automovel.Frear();
                }
                if (menu_carro == 3)
                {
                    Console.WriteLine("Digite a Marcha que Deseja engatar:");
                    automovel.AlterarMarcha(Int32.Parse(Console.ReadLine()));
                }
                if (menu_carro == 4)
                {
                    automovel.Imprimir();

                }

                Console.WriteLine("Deseja fazer alguma outra alteração ?" +
                                  "\n 1-Sim" +
                                  "\n 2-Não");
                menu_carro = Int32.Parse(Console.ReadLine());

            } while (menu == 1);


            Console.WriteLine("Imprimindo Dados...");

            automovel.Imprimir();
            Console.ReadLine();*/

            o_Veiculo.Marca = "Volkswagen";
            o_Veiculo.Modelo = "Gol 1.6";
            o_Veiculo.Ano = 2010;
            o_Veiculo.Cor = "Prata";
            o_Veiculo.NumPortas = 5;
            o_Veiculo.Chassi = gerarChassi();
            o_Veiculo.VelocidadeMaxima = 220;
            o_Veiculo.NumMarchas = 6;
            o_Veiculo.Proprietario = "Maria";

            o_Veiculo.Imprimir();
            o_Veiculo.AlterarMarcha(1);
            o_Veiculo.Acelerar(30);
            o_Veiculo.AlterarMarcha(2);
            o_Veiculo.Imprimir();
            o_Veiculo.AlterarMarcha(0);
            o_Veiculo.Imprimir();
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            Console.WriteLine("\nAlunos: " + 
                              "\nAngélica Resende Araújo" + 
                              "\nDaniel Souza Monteiro de Carvalho"+                                      
                              "\n------------------------------------------------------\n");
        }
    }
}
