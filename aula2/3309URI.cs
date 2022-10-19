using System; 

class sep {
  public static int separar_casas(int a, ref int unidade,ref int dezena,ref int centena, ref int unidade_milhar,ref int dezena_milhar,ref int centena_milhar){
  unidade=a%10;
   dezena=a%100;
   centena=a%1000;
   unidade_milhar=a%10000;
   dezena_milhar=a%100000;
   centena_milhar=a%1000000;
  return unidade;
  }
}






class happy {
  public static int happynumber  (int x){
  sep.separar_casas(x);
  int happy = (unidade**2)+(dezena**2)+(centena**2)+(unidade_milhar**2)+(dezena_milhar**2)+(centena_milhar**2);
  if (happy==1){
    return happy;
  }
  else {
    happynumber(happy);
  }
    if (happy=x){
      return happy = 0;
    }
  
  }
  
}






class URI {

    static void Main(string[] args) { 
        int nl = int.Parse(Console.ReadLine());
        
      for (int num=1;num < nl;num=num+1){
        int n1 = int.Parse(Console.ReadLine());
      }










    }
}