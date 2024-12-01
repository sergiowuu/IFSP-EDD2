using System;
using System.Collections.Generic;

public class Lote
{
    public int Id { get; set; }
    public int Qtde { get; set; }
    public DateTime Venc { get; set; }

    public Lote() { }

    public Lote(int id, int qtde, DateTime venc)
    {
        Id = id;
        Qtde = qtde;
        Venc = venc;
    }

    public override string ToString()
    {
        return $"{Id}-{Qtde}-{Venc}";
    }
}

public class Medicamento
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Laboratorio { get; set; }
    public Queue<Lote> Lotes { get; set; } = new Queue<Lote>();

    public Medicamento() { }

    public Medicamento(int id, string nome, string laboratorio)
    {
        Id = id;
        Nome = nome;
        Laboratorio = laboratorio;
    }

    public int QtdeDisponivel()
    {
        int total = 0;
        foreach (var lote in Lotes)
        {
            total += lote.Qtde;
        }
        return total;
    }

    public void Comprar(Lote lote)
    {
        Lotes.Enqueue(lote);
    }

    public bool Vender(int qtde)
    {
        int totalDisponivel = QtdeDisponivel();
        if (totalDisponivel < qtde) return false;

        while (qtde > 0 && Lotes.Count > 0)
        {
            var lote = Lotes.Peek();
            if (lote.Qtde <= qtde)
            {
                qtde -= lote.Qtde;
                Lotes.Dequeue();
            }
            else
            {
                lote.Qtde -= qtde;
                qtde = 0;
            }
        }
        return true;
    }

    public override string ToString()
    {
        return $"{Id}-{Nome}-{Laboratorio}-{QtdeDisponivel()}";
    }

    public override bool Equals(object obj)
    {
        if (obj is Medicamento medicamento)
        {
            return Id == medicamento.Id;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}

public class Medicamentos
{
    private List<Medicamento> listaMedicamentos = new List<Medicamento>();

    public void Adicionar(Medicamento medicamento)
    {
        listaMedicamentos.Add(medicamento);
    }

    public bool Deletar(Medicamento medicamento)
    {
        if (medicamento.QtdeDisponivel() == 0)
        {
            return listaMedicamentos.Remove(medicamento);
        }
        return false;
    }

    public Medicamento Pesquisar(Medicamento medicamento)
    {
        return listaMedicamentos.Find(m => m.Equals(medicamento)) ?? new Medicamento();
    }

    public void ListarMedicamentos()
    {
        foreach (var medicamento in listaMedicamentos)
        {
            Console.WriteLine(medicamento);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Medicamentos medicamentos = new Medicamentos();
        int opcao;
        do
        {
            Console.WriteLine("0. Finalizar processo");
            Console.WriteLine("1. Cadastrar medicamento");
            Console.WriteLine("2. Consultar medicamento (sintético)");
            Console.WriteLine("3. Consultar medicamento (analítico)");
            Console.WriteLine("4. Comprar medicamento");
            Console.WriteLine("5. Vender medicamento");
            Console.WriteLine("6. Listar medicamentos");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Laboratório: ");
                    string laboratorio = Console.ReadLine();
                    medicamentos.Adicionar(new Medicamento(id, nome, laboratorio));
                    break;
                case 2:
                    Console.Write("ID do medicamento: ");
                    id = int.Parse(Console.ReadLine());
                    var medicamento = medicamentos.Pesquisar(new Medicamento { Id = id });
                    Console.WriteLine(medicamento);
                    break;
                case 3:
                    Console.Write("ID do medicamento: ");
                    id = int.Parse(Console.ReadLine());
                    medicamento = medicamentos.Pesquisar(new Medicamento { Id = id });
                    Console.WriteLine(medicamento);
                    foreach (var lote in medicamento.Lotes)
                    {
                        Console.WriteLine(lote);
                    }
                    break;
                case 4:
                    Console.Write("ID do medicamento:  ");
                    id = int.Parse(Console.ReadLine());
                    medicamento = medicamentos.Pesquisar(new Medicamento { Id = id });
                    if (medicamento.Id != 0)
                    {
                        Console.Write("ID do lote: ");
                        int loteId = int.Parse(Console.ReadLine());
                        Console.Write("Quantidade: ");
                        int qtde = int.Parse(Console.ReadLine());
                        Console.Write("Data de vencimento (dd-MM-yyyy): ");
                        DateTime venc = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
                        medicamento.Comprar(new Lote(loteId, qtde, venc));
                    }
                    break;
                case 5:
                    Console.Write("ID do medicamento: ");
                    id = int.Parse(Console.ReadLine());
                    medicamento = medicamentos.Pesquisar(new Medicamento { Id = id });
                    if (medicamento.Id != 0)
                    {
                        Console.Write("Quantidade a vender: ");
                        int qtde = int.Parse(Console.ReadLine());
                        if (medicamento.Vender(qtde))
                        {
                            Console.WriteLine("venda realizada com sucesso.");
                        }
                        else
                        {
                            Console.WriteLine("quantidade insuficiente");
                        }
                    }
                    break;
                case 6:
                    medicamentos.ListarMedicamentos();
                    break;
            }
        } while (opcao != 0);
    }
}
