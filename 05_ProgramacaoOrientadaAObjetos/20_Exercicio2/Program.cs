using _20_Exercicio2;

LivroFotos livro1 = new LivroFotos();
Console.WriteLine($"Número de paginas é {livro1.GetNumeroPaginas()}"); ;

LivroFotos livro2 = new LivroFotos(24);
Console.WriteLine($"Número de paginas é {livro2.GetNumeroPaginas()}"); ;

SuperLivroFotos livro3 = new SuperLivroFotos();
Console.WriteLine($"Número de paginas é {livro3.GetNumeroPaginas()}"); ;