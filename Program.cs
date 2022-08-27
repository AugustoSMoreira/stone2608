Desafio();

static void Desafio()
{
  var user = new string[3];

  Console.Clear();

  Console.WriteLine("Informe seu nome, por favor");
  user[0] = Console.ReadLine();
  Console.WriteLine("Informe salário, por favor");
  user[1] = Console.ReadLine();
  Console.WriteLine("Informe sua Carga Horária diária, por favor");
  user[2] = Console.ReadLine();

  Condicao.Loop(user);

  Console.WriteLine("Gostaria de sair? Sim ou Não?");
  var res = Console.ReadLine().ToLower();

  while (res == "não")
  {
    Desafio();
  }

  System.Environment.Exit(0);
}
