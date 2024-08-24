

using DesafioPOO.Models;

Nokia nokia1 = new Nokia("0001","Patch 1", "1234", 250);
Iphone iphone1 = new Iphone("0001","Patch 1", "1234", 250);

nokia1.Ligar("(71) 999688-1608");
nokia1.InstalarAplicativo("Instagram");
nokia1.ReceberLigacao();


iphone1.Ligar("(71) 999688-1608");

iphone1.InstalarAplicativo("Nubank");