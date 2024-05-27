using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Teste no Nokia: ");
Smartphone nokia = new Nokia("777", "Tijolo", "237", 256);
nokia.Ligar();
nokia.InstalarAplicativo("Pou");

Console.WriteLine("Teste no Iphone: ");
Smartphone iphone = new Iphone("1515", "Iphone 13", "887", 512);
iphone.Ligar();
iphone.InstalarAplicativo("Amazon Store");
