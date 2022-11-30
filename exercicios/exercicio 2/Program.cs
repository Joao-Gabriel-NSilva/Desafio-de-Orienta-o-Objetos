using Models;

var tolkien = new Autor("Tolkien", "tokiel12@gmail.com");
var livro = new Livro("Senhor dos anéis", tolkien);

Console.WriteLine(livro);

var autor1 = new Autor("HP Lovecraft", "Lovecraft@gmail.com");
var autor2 = new Autor("Rick Riordan", "rriordan@gmail.com");
List<Autor> listaAutores = new List<Autor>() {autor1, autor2};

var livro2 = new Livro("Percy Jackson e o conto de Cthullu", listaAutores);
Console.WriteLine(livro2);