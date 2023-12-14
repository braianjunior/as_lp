using System;
using System.Collections.Generic;
class Livro : itemBiblioteca
{
    // Propriedade adicional
    public string Autor { get; set; }

    // Construtor
    public Livro(int id, string titulo, string autor) : base(id, titulo)
    {
        Autor = autor;
    }

    //método abstrato
    public override void ExibirDescricaoInterna()
    {
        Console.WriteLine($"Descrição Interna do Livro {titulo}: {descricaointerna}");
    }
}