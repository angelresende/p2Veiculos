using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliação_P2___Trabalho
{
    class VeiculoUsado
    {
        protected string modelo;
        protected int anoFab;
        protected float valor;

        public string Modelo { get { return modelo; } set { modelo = value; } }
        public int AnoFab { get { return anoFab; } set { anoFab = value; } }
        public float Valor { get { return valor; } set { valor = value; } }

        public virtual float calcularDepreciacao()
        {
            return valor * 0.10f;
        }

        public virtual void ImprimirDados()
        {
            Console.WriteLine("\nModelo: " + modelo +
                              "\nAno de Fabricação: " + anoFab +
                              "\nValor do veículo: " + valor +
                              "\nValor da depreciaçõa: " + calcularDepreciacao());
        }
    }
}
