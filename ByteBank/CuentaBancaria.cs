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
        //Propiedades

        //public string nombreCliente;
        public Cliente cliente;
        public string numeroCuenta;
        public string numeroAgencia;
        public double saldo;
        public double tasaInteres;
        public double limiteSobregiro;
        public bool cuentaActiva;

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

    }
}
