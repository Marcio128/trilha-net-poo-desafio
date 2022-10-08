using DesafioPOO.Models;

Iphone iphone1 = new Iphone("12316584","Iphone3","8887778",256);
Nokia nokia1 = new Nokia("98765433","Nokia1","1117778",128);


Console.WriteLine($"Telefone:\r\nNúmero: {iphone1.Numero}\r\nModelo: {iphone1.Modelo}\r\nIMEI:{iphone1.IMEI}\r\nMemória:{iphone1.Memoria}");
iphone1.Ligar();
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("APP Iphone");
iphone1.Numero = "1234568";
Console.ReadLine();
Console.Clear();

Console.WriteLine($"Telefone:\r\nNúmero: {iphone1.Numero}\r\nModelo: {iphone1.Modelo}\r\nIMEI:{iphone1.IMEI}\r\nMemória:{iphone1.Memoria}");
Console.ReadLine();
Console.Clear();

Console.WriteLine($"Telefone:\r\nNúmero: {nokia1.Numero}\r\nModelo: {nokia1.Modelo}\r\nIMEI:{nokia1.IMEI}\r\nMemória:{nokia1.Memoria}");
nokia1.Ligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("APP Nokia");
Console.ReadLine();
Console.Clear();

nokia1.Numero = "55544446";
Console.WriteLine($"Telefone:\r\nNúmero: {nokia1.Numero}\r\nModelo: {nokia1.Modelo}\r\nIMEI:{nokia1.IMEI}\r\nMemória:{nokia1.Memoria}");
Console.ReadLine();
Console.Clear();