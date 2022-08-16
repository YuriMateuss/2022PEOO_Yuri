using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Informe um valor:");
    int A = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe outro valor: ");
    int B = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe outro valor: ");
    int C = int.Parse(Console.ReadLine());
    int Z = A;
    if(Z < B);
    else{
      Z = B;
    }
    if(Z < C);
    else{
      Z = C;
    }
    int soma = A + B + C;
    Console.WriteLine("Soma dos dois maiores: " + (soma - Z));
  }
}
