using System; 

class URI {

    static void Main(string[] args) { 
    
    int l1 = int.Parse(Console.ReadLine());
    int l2 = int.Parse(Console.ReadLine());
    Double dis = l2*l1;
    Double g = dis/12;
    Console.WriteLine($"{g:0.000}");
       

    }

}