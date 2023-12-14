public abstract class itemBiblioteca
{
    public int id {get; set; }
    public string titulo {get; set;}

    protected string descricaointerna {get; set; }

    public itemBiblioteca (int id, string titulo)
    {
        id = id;
        titulo = titulo;
        descricaointerna = "Descrição padrão.";
    }
    public abstract void ExibirDescricaoInterna();


}

class Biblioteca
{
    // Coleção de itens
    private List<itemBiblioteca> colecao;

    // Construtor
    public Biblioteca()
    {
        colecao = new List<itemBiblioteca>();
    }

    // Método para adicionar um item à coleção
    public void AdicionarItem(itemBiblioteca item)
    {
        colecao.Add(item);
    }

    // Método para remover um item da coleção
    public void RemoverItem(itemBiblioteca item)
    {
        colecao.Remove(item);
    }

    // Método de sobrecarga para buscar por título
    public itemBiblioteca BuscarItemPorTitulo(string titulo)
    {
        return colecao.Find(item => item.titulo == titulo);
    }

    // Método de sobrecarga para buscar por ID
    public itemBiblioteca BuscarItemPorId(int id)
    {
        return colecao.Find(item => item.id == id);
    }
}