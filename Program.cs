using DesafioPOO.Models;

Nokia nokia1 = new Nokia("34992300095", "Nokia23", 8, 64);
Iphone iphone1 = new Iphone("34992300096", "Iphone14", 12, 128);

nokia1.Ligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("WhatsApp");

iphone1.Ligar();
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("Instagram");
