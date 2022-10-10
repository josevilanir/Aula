using System; 

class URI {

    static void Main(string[] args) { 
      String n1 = Console.ReadLine();
      string [] a= n1.Split(' ');
      int a1 = int.Parse(a[0]);
      int b1 = int.Parse(a[1]);
      int c1 = int.Parse(a[2]);
      int d1 = int.Parse(a[3]);
      int somCD= c1 + d1;
      int somAB = a1 + b1;
       if (b1>c1 & d1>a1 & somCD>somAB & c1>=0 & d1>=0 & a1%2==0) Console.WriteLine("Valores aceitos");
       else
         Console.WriteLine("Valores nao aceitos");
      Console.WriteLine(somAB);
      Console.WriteLine(somCD);
    }
}