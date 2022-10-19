using Bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.Contas
{
    public class ContaCorrente
    {
        private int numero_agencia;

        public int Numero_agencia
        {
            get { return this.numero_agencia; }  
            set {
                    if (value >0)
                    {
                    this.numero_agencia = value;
                    }
            }           
        }
        private string conta;
        public Cliente Titular { get; set; }

        private double saldo;

        public void Depositar(double Valor)
        {
            saldo += Valor;
        }

        public bool Sacar(double Valor)
        {
            if (Valor <= saldo)
            {
                saldo -= Valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }
        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }
        public double GetSaldo()
        {
            return this.saldo;
        }
    }
}
