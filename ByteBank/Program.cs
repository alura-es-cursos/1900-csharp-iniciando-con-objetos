using ByteBank;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Aplicación de cuentas bancarias!");

CuentaBancaria cuentaLeonardo = new CuentaBancaria();

cuentaLeonardo.nombreCliente = "Leonardo José";
cuentaLeonardo.numeroCuenta = "0134-0337-61-5897564";
cuentaLeonardo.numeroAgencia = "0134";
cuentaLeonardo.saldo = 1000.00;
cuentaLeonardo.tasaInteres = 7.5;
cuentaLeonardo.limiteSobregiro = 500.00;

CuentaBancaria cuentaMaria = new CuentaBancaria();

cuentaMaria.nombreCliente = "María Rivas";
cuentaMaria.numeroCuenta = "0168-0337-68-5897564";
cuentaMaria.numeroAgencia = "0168";
cuentaMaria.saldo = 1000.00;
cuentaMaria.tasaInteres = 7.5;
cuentaMaria.limiteSobregiro = 500.00;

Console.WriteLine("Nombre de cliente: " + cuentaLeonardo.nombreCliente);
Console.WriteLine("Número de cuenta: " + cuentaLeonardo.numeroCuenta);
Console.WriteLine("Número de agencia: " + cuentaLeonardo.numeroAgencia);
Console.WriteLine("Saldo: " + cuentaLeonardo.saldo);
Console.WriteLine("Tasa de interés: " + cuentaLeonardo.tasaInteres);
Console.WriteLine("Límite de sobregiro: " + cuentaLeonardo.limiteSobregiro);

Console.WriteLine("Nombre de cliente: " + cuentaMaria.nombreCliente);

Console.ReadLine();