public class Condicao
{
  public static void Loop(string[] user)
  {
    foreach (var item in user)
    {
      Console.Clear();
      Console.WriteLine("====================");
      Console.WriteLine($"Confira suas informações => {item}");
      Console.WriteLine("====================");
      Console.ReadKey();
    }
  }
}
