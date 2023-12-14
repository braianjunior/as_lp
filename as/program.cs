class Program
{
    static void Main()
    {
        // Criando instâncias de Biblioteca e Livro
        Biblioteca minhaBiblioteca = new Biblioteca();
        Livro livro1 = new Livro(1, "C# Programming", "Autor1");
        Livro livro2 = new Livro(2, "Introduction to .NET", "Autor2");

        // Adicionando livros à biblioteca
        minhaBiblioteca.AdicionarItem(livro1);
        minhaBiblioteca.AdicionarItem(livro2);

        // Buscando livro por título
        Livro livroEncontrado = (Livro)minhaBiblioteca.BuscarItemPorTitulo("C# Programming");

        // Exibindo a Descrição Interna do livro, se encontrado
        if (livroEncontrado != null)
        {
            livroEncontrado.ExibirDescricaoInterna();
        }
        else
        {
            Console.WriteLine("Livro não encontrado.");
        }

        // Removendo um livro da biblioteca
        minhaBiblioteca.RemoverItem(livro2);
    }
}