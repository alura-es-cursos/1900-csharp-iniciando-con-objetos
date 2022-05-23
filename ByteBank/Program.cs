using ByteBank;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Aplicación de cuentas bancarias!");

CuentaBancaria cuentaLeonardo = new CuentaBancaria();

cuentaLeonardo.nombreCliente = "Leonardo";
cuentaLeonardo.numeroCuenta = "1234567890";
cuentaLeonardo.numeroAgencia = "123";
cuentaLeonardo.saldo = 1254.65;
cuentaLeonardo.tasaInteres = 1.25;
cuentaLeonardo.limiteSobregiro = 500.67;
cuentaLeonardo.cuentaActiva = true;



//CuentaBancaria cuentaLeonardo2 = new CuentaBancaria();

//cuentaLeonardo2.nombreCliente = "Leonardo";
//cuentaLeonardo2.numeroCuenta = "1234567890";
//cuentaLeonardo2.numeroAgencia = "123";
//cuentaLeonardo2.saldo = 1254.65;
//cuentaLeonardo2.tasaInteres = 1.25;
//cuentaLeonardo2.limiteSobregiro = 500.67;
//cuentaLeonardo2.cuentaActiva = true;

//Variables por valor
string nombre1 = "Leonardo";
string nombre2 = "Luis";

Console.WriteLine("Validación de Variables por valor: ");
Console.WriteLine(nombre1 == nombre2);

CuentaBancaria cuentaLeonardo2;

cuentaLeonardo2 = cuentaLeonardo;

Console.WriteLine("Validación de Variables por valor entre primitivos y atributos de objetos: ");
Console.WriteLine(cuentaLeonardo.nombreCliente == nombre1);


//Console.WriteLine("Nombre de cliente: " + cuentaLeonardo.nombreCliente);
//Console.WriteLine("Número de cuenta: " + cuentaLeonardo.numeroCuenta);
//Console.WriteLine("Número de agencia: " + cuentaLeonardo.numeroAgencia);
//Console.WriteLine("Saldo: " + cuentaLeonardo.saldo);
//Console.WriteLine("Tasa de interés: " + cuentaLeonardo.tasaInteres);
//Console.WriteLine("Límite de sobregiro: " + cuentaLeonardo.limiteSobregiro);
//Console.WriteLine("Cuenta Activa: " + cuentaLeonardo.cuentaActiva);

Console.ReadLine();