using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Modelo 1", imei: "121221211212", memoria: 64); 
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "123455559", modelo: "Modelo 2", imei: "155551211212", memoria: 128); 
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");