using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Informe um valor:");
    int A = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe outro valor: ");
    int B = int.Parse(Console.ReadLine());
    int X = A / B;
    int Z = A % B;
    Console.WriteLine("Divisão = " + X);
    Console.WriteLine("Resto = " + Z);
  }
}
