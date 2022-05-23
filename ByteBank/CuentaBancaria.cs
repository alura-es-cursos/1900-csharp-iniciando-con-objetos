using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.DatosCliente;

namespace ByteBank
{
    public class CuentaBancaria
    {
        //Atributos o campos

        //public string nombreCliente;
        //private Cliente cliente;
        //public string numeroCuenta;
        //public string numeroAgencia;
        private double saldo;
        //public double tasaInteres;
        //public double limiteSobregiro;
        //public bool cuentaActiva;

        //Propiedades
        public Cliente Cliente
        {
            get;set;
        }

        public string NumeroCuenta
        {
            get;set;
        }

        public string NumeroAgencia
        {
            get; set;
        }


        public double Saldo
        {
            get { return saldo; }
            set {
                if (value >= 0)
                {
                    saldo = value;
                }
                else
                {
                    saldo = 0;
                }
            }
        }

        public double TasaInteres
        {
            get;set;
        }

        public double LimiteSobregiro
        {
            get; set;
        }

        public bool CuentaActiva
        {
            get; set;
        }

        //Métodos

        //Método RetirarDinero
        public bool RetirarDinero(double valorARetirar)
        {

            if (saldo < valorARetirar)
            {
                Console.WriteLine("No hay saldo suficiente para el retiro");
                return false;
            } else if (valorARetirar <= 0)
            {
                Console.WriteLine("El valor a retirar debe ser mayor a 0");
                return false;
            }

            //saldo = saldo - valorARetirar;
            saldo-= valorARetirar;

            return true;
        }

        //Método DepositarDinero
        public void DepositarDinero(double valorADepositar)
        {
            if (valorADepositar < 0)
            {
                Console.WriteLine("No es posible depositar valores negativos");
                return;
            }
            saldo += valorADepositar;
            return;
        }

        //Método TransferirSaldo
        public double TransferirSaldo(double valorATransferir, CuentaBancaria cuentaReceptora)
        {
            //Retiramos el saldo de la cuenta origen
            RetirarDinero(valorATransferir);

            cuentaReceptora.DepositarDinero(valorATransferir);

            return saldo;

        }

        /*
        public void DefinirSaldo(double saldoInicial)
        {
            if (saldoInicial >= 0)
            {
                saldo = saldoInicial;
            }
            else
            {
                Console.WriteLine("Saldo Inicial debe ser mayor o igual que 0");
            }
        }

        public double ObtenerSaldo()
        {
            return saldo;
        }
        */
    }
}
