// See https://aka.ms/new-console-template for more information
using Relacionamentos.Model;

Livro livro1 = new Livro();
livro1.Titulo = "O Alquimista de aço";

Autor autor1 = new Autor();
autor1.Nome = "Paulo Coelho";

livro1.Autores.Add(autor1);
autor1.LivrosEscritos.Add(livro1);

Console.WriteLine("O livro {0} foi escrito por", livro1.Titulo);
foreach(Autor autor in livro1.Autores)
{
    Console.WriteLine(autor.Nome);
}

Console.WriteLine("O autor {0} escreveu {1} livro(s).", autor1.Nome, autor1.LivrosEscritos.Count());
