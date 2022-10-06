using System; 

class URI {

    static void Main(string[] args) { 

    String nome = Console.ReadLine();
    Double sal = Double.Parse(Console.ReadLine());
    Double vendas = Double.Parse(Console.ReadLine());
    Double bonus = vendas*0.15;
    Double total = sal + bonus;
    Console.WriteLine($"TOTAL = R$ {total:0.00}");
    
      }

}