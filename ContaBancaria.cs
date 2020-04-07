using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ContaBancaria
{
    class ContaBancaria
    {
        //prop +tab tab | privada por não poder ser modificada
        public int numeroConta { get; private set; }
        public string titularConta { get; private set; }
        public float depositoInicial { get; private set; }
        public float saldoConta { get; private set; }

        public ContaBancaria(int numeroConta, string titularConta) 
        {
            this.numeroConta = numeroConta;
            this.titularConta = titularConta;
        }
        public ContaBancaria(int numeroConta, string titularConta, float depositoInicial, float saldoConta) : this( numeroConta, titularConta)
        {
            this.depositoInicial = depositoInicial;
            this.saldoConta = saldoConta;
        }
        public override string ToString()
        {
            return "Conta: "+numeroConta
                +"Titular:"+titularConta
                +"Saldo: "+saldoConta.ToString("F2",CultureInfo.InvariantCulture); 
                //base.ToString();
        }

        public float Depositar(float valorDeposito) {
            this.saldoConta = (this.saldoConta + valorDeposito);
            return this.saldoConta;
        }

        public float Sacar(float valorDeposito)
        {
            this.saldoConta = (this.saldoConta - valorDeposito);
            return this.saldoConta;
        }




        //clase construtora


    }
}
