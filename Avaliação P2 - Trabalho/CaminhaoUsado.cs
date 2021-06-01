using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliação_P2___Trabalho
{
    class CaminhaoUsado: VeiculoUsado
    {
        private int capacidade;
        private int nroEixos;


        public int Capacidade { get { return capacidade; } set { capacidade = value; } }
        public int NnroEixos { get { return nroEixos; } set { nroEixos = value; } }

        public override float calcularDepreciacao()
        {
            return valor * 0.30f;
        }

        public override void ImprimirDados()
        {
            base.ImprimirDados();
            Console.WriteLine("Capacidade: " + capacidade + 
                              "\nNúmero de Eixos: " + nroEixos +
                              "\n---------------------------------------------");
        }
    }

}
