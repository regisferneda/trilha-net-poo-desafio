using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia = new Nokia(numero: "(11)998575441", modelo: "Modelo 1", imei: "88887777", memoria: 64);
Console.WriteLine($"Smartphone Nokia: {nokia.Numero} ");
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");


Smartphone iphone = new Iphone(numero: "(11)965545622", modelo: "Modelo 2", imei: "22225555", memoria: 128);
Console.WriteLine($"Smartphone iPhone: {iphone.Numero}");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");