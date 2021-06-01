using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliação_P2___Trabalho
{
    class Veiculo
    {
        
        protected string marca;
        protected string modelo;
        protected string cor;
        protected int ano;
        protected int numPortas;
        protected int chassi;
        protected string proprietario;
        protected int velocidadeMaxima;
        protected int velocidadeAtual;
        protected int numMarchas;
        protected int marchaAtual;

        
        public string Marca { get { return marca; } set { marca = value; } }
        public string Modelo { get { return modelo; } set { modelo = value; } }

        public string Cor { get { return cor; } set { cor = value; } }
        public int Ano { get { return ano; } set { ano = value; } }
        public int NumPortas { get { return numPortas; } set { numPortas = value; } }
        public int Chassi { get { return chassi; } set { chassi = value; } }
        public string Proprietario { get { return proprietario; } set { proprietario = value; } }
        public int VelocidadeMaxima { get { return velocidadeMaxima; } set { velocidadeMaxima = value; } }
        public int VelocidadeAtual { get { return velocidadeAtual; } set { velocidadeAtual = value; } }
        public int NumMarchas { get { return numMarchas; } set { numMarchas = value; } }
        public int MarchaAtual { get { return marchaAtual; } set { marchaAtual = value; } }


        public void Acelerar(int add)
        {
            if (this.marchaAtual == 0)
            {
                Console.WriteLine("Engate a primeira antes de Acelerar!!");
            }
            else
            {
                this.velocidadeAtual = velocidadeAtual + add;
            }
            
        }

        public void Frear()
        {
            this.velocidadeAtual = 0;
        }

        public void AlterarMarcha(int marcha)
        {
            try
            {
                if (marcha < 0 || marcha > 6) // Baseado nos carros padrões marchas de 1 a 5 + marcha ré (0)
                {
                    throw new Exception("Marcha Inválida !");
                }

                if (marcha == 0 && this.velocidadeAtual > 0)
                {
                    throw new Exception("Para usar a marcha Ré, primeiro diminua a velocidade para 0!!");
                }

                this.marchaAtual = marcha;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message,
                        "Tratamento de Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }


        }


        public void Imprimir()
        {
            Console.WriteLine("\nMarca: " + marca +
                              "\nModelo: " + modelo +
                              "\nCor: " + cor +
                              "\nChassi: " + chassi +
                              "\nNumero de Portas: " + numPortas +
                              "\nVelocidade Máxima: " + velocidadeMaxima +
                              "\nNumero de Marchas: " + numMarchas +
                              "\nMarcha Atual: " + marchaAtual +
                              "\nVelocidade Atual: " + velocidadeAtual +
                              "\nProprietario: " + proprietario +
                              "\n------------------------------------------------------\n");
        }
    }
}
