using DesafioPOO.Models;

Console.WriteLine("Smartphone 1 - Nokia");
Smartphone nokia = new Nokia(numero: "1234560", modelo: "nk21", imei: "145637", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("Smartphone 2 - Iphone");
Smartphone iphone = new Iphone(numero: "1456-4253", modelo: "ip14", imei: "786541", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");