using ByteBank;
using ByteBank.DatosCliente;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Aplicación de cuentas bancarias!");

CuentaBancaria cuentaMaria = new CuentaBancaria();

Cliente datosMaria = new Cliente();

datosMaria.nombre = "María";
datosMaria.dni = "80018";
datosMaria.profesion = "Profesora";

//cuentaMaria.nombreCliente = "Maria";
cuentaMaria.cliente = datosMaria;
cuentaMaria.numeroCuenta = "9865656565";
cuentaMaria.numeroAgencia = "986";
cuentaMaria.saldo = 1000;
cuentaMaria.tasaInteres = 1.25;
cuentaMaria.limiteSobregiro = 800;
cuentaMaria.cuentaActiva = true;

Console.WriteLine("Nombre cliente: " + cuentaMaria.cliente.nombre);
Console.WriteLine("DNI cliente: " + cuentaMaria.cliente.dni);

Console.WriteLine("Número de cuenta: " + cuentaMaria.numeroCuenta);


CuentaBancaria cuentaLeonardo = new CuentaBancaria();

//cuentaLeonardo.nombreCliente = "Leonardo";
if (cuentaLeonardo.cliente == null)
{
    cuentaLeonardo.cliente = new Cliente();
}

cuentaLeonardo.cliente.nombre = "Leonardo";
cuentaLeonardo.cliente.dni = "13804";
cuentaLeonardo.cliente.profesion = "Ingeniero";

Console.WriteLine("Nombre cliente: " + cuentaLeonardo.cliente.nombre);
Console.WriteLine("DNI cliente: " + cuentaLeonardo.cliente.dni);

Console.WriteLine("Número de cuenta: " + cuentaLeonardo.numeroCuenta);


cuentaLeonardo.numeroCuenta = "1234567890";
cuentaLeonardo.numeroAgencia = "123";
cuentaLeonardo.saldo = 1254.65;
cuentaLeonardo.tasaInteres = 1.25;
cuentaLeonardo.limiteSobregiro = 500.67;
cuentaLeonardo.cuentaActiva = true;



/*
Console.WriteLine("Saldo antes del retiro:" + cuentaLeonardo.saldo);

Console.WriteLine("Retirando 120");

bool retiroHecho = cuentaLeonardo.RetirarDinero(120);

if (retiroHecho)
    Console.WriteLine("Saldo luego del retiro:" + cuentaLeonardo.saldo);
else
    Console.WriteLine("No fue posible hacer el retiro de:" + cuentaLeonardo.saldo);

Console.WriteLine("Retirando -40");

if (cuentaLeonardo.RetirarDinero(-40))
{
    Console.WriteLine("Saldo luego del retiro:" + cuentaLeonardo.saldo);
} else
{
    Console.WriteLine("No fue posible hacer el retiro de -40");
}
Console.WriteLine("Retirando 2000");
if (cuentaLeonardo.RetirarDinero(2000))
{
    Console.WriteLine("Saldo luego del retiro:" + cuentaLeonardo.saldo);
}
else
{
    Console.WriteLine("No fue posible hacer el retiro de 2000");
}

Console.WriteLine("Depositando 1000");
cuentaLeonardo.DepositarDinero(1000);
Console.WriteLine("Saldo luego del depósito:" + cuentaLeonardo.saldo);

Console.WriteLine("Depositando -500");
cuentaLeonardo.DepositarDinero(-500);
Console.WriteLine("Saldo luego del depósito:" + cuentaLeonardo.saldo);

Console.WriteLine("Transferir 500");
double saldoATransferir = 500.00;
double saldoDespuesTransferencia = cuentaLeonardo.TransferirSaldo(500, cuentaMaria);

Console.WriteLine("Saldo luego de transferir:" + saldoDespuesTransferencia);

Console.WriteLine("Saldo de la cuenta que recibió la transferencia:" + cuentaMaria.saldo);

*/



Console.ReadLine();