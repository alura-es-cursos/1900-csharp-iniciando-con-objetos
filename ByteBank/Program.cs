using ByteBank;
using ByteBank.DatosCliente;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Aplicación de cuentas bancarias!");

CuentaBancaria cuentaMaria = new CuentaBancaria();

Cliente datosMaria = new Cliente();

datosMaria.Nombre = "María";
datosMaria.Dni = "80018";
datosMaria.Profesion = "Profesora";

//cuentaMaria.nombreCliente = "Maria";
cuentaMaria.Cliente = datosMaria;
cuentaMaria.NumeroCuenta = "9865656565";
cuentaMaria.NumeroAgencia = "986";
cuentaMaria.Saldo = 1000;
cuentaMaria.TasaInteres = 1.25;
cuentaMaria.LimiteSobregiro = 800;
cuentaMaria.CuentaActiva = true;

Console.WriteLine("Nombre cliente: " + cuentaMaria.Cliente.Nombre);
Console.WriteLine("DNI cliente: " + cuentaMaria.Cliente.Dni);

Console.WriteLine("Número de cuenta: " + cuentaMaria.NumeroCuenta);


CuentaBancaria cuentaLeonardo = new CuentaBancaria();

//cuentaLeonardo.nombreCliente = "Leonardo";
if (cuentaLeonardo.Cliente == null)
{
    cuentaLeonardo.Cliente = new Cliente();
}

cuentaLeonardo.Cliente.Nombre = "Leonardo";
cuentaLeonardo.Cliente.Dni = "13804";
cuentaLeonardo.Cliente.Profesion = "Ingeniero";

Console.WriteLine("Nombre cliente: " + cuentaLeonardo.Cliente.Nombre);
Console.WriteLine("DNI cliente: " + cuentaLeonardo.Cliente.Dni);

Console.WriteLine("Número de cuenta: " + cuentaLeonardo.NumeroCuenta);


cuentaLeonardo.NumeroCuenta = "1234567890";
cuentaLeonardo.NumeroAgencia = "123";
cuentaLeonardo.Saldo = 1254.65;
cuentaLeonardo.TasaInteres = 1.25;
cuentaLeonardo.LimiteSobregiro = 500.67;
cuentaLeonardo.CuentaActiva = true;

Console.WriteLine("Saldo Inicial - Cuenta Leonardo:" + cuentaLeonardo.Saldo);
Console.WriteLine("Saldo Inicial - Cuenta María:" + cuentaMaria.Saldo);


Console.WriteLine("Saldo antes del retiro:" + cuentaLeonardo.Saldo);

Console.WriteLine("Retirando 120");

bool retiroHecho = cuentaLeonardo.RetirarDinero(120);

if (retiroHecho)
    Console.WriteLine("Saldo luego del retiro:" + cuentaLeonardo.Saldo);
else
    Console.WriteLine("No fue posible hacer el retiro de:" + cuentaLeonardo.Saldo);

Console.WriteLine("Retirando -40");

if (cuentaLeonardo.RetirarDinero(-40))
{
    Console.WriteLine("Saldo luego del retiro:" + cuentaLeonardo.Saldo);
} else
{
    Console.WriteLine("No fue posible hacer el retiro de -40");
}
Console.WriteLine("Retirando 2000");
if (cuentaLeonardo.RetirarDinero(2000))
{
    Console.WriteLine("Saldo luego del retiro:" + cuentaLeonardo.Saldo);
}
else
{
    Console.WriteLine("No fue posible hacer el retiro de 2000");
}

Console.WriteLine("Depositando 1000");
cuentaLeonardo.DepositarDinero(1000);
Console.WriteLine("Saldo luego del depósito:" + cuentaLeonardo.Saldo);

Console.WriteLine("Depositando -500");
cuentaLeonardo.DepositarDinero(-500);
Console.WriteLine("Saldo luego del depósito:" + cuentaLeonardo.Saldo);

Console.WriteLine("Transferir 500");
double saldoATransferir = 500.00;
double saldoDespuesTransferencia = cuentaLeonardo.TransferirSaldo(500, cuentaMaria);

Console.WriteLine("Saldo luego de transferir:" + saldoDespuesTransferencia);

Console.WriteLine("Saldo de la cuenta que recibió la transferencia:" + cuentaMaria.Saldo);





Console.ReadLine();