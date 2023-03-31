void barra()
{
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("#=============================#");
}
Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("[ Formulário do PETisco!]");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("_________________________");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Qual é a espécie?");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("_________________________");
string especie = Console.ReadLine()!;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Qual é a raça?");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("_________________________");
string raca = Console.ReadLine()!;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Qual é a apelido?");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("_________________________");
string nickname = Console.ReadLine()!;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Qual é a idade?");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("_________________________");
string age = Console.ReadLine()!;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Qual é a Pelagem/Cor?");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("_________________________");
string colorfun = Console.ReadLine()!;
Console.WriteLine("_________________________");
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("Pressione uma tecla para continuar. . .");
Console.ReadKey();












Console.Clear();
barra();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("#======    Pet Hotel!   ======#");
barra();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"# Espécie: {especie.PadRight(18,'.').Substring(0,18)} #"); // 18 pontos.
barra();
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine($"# Raça:    {raca.PadRight(18,'.').Substring(0,18)} #"); // 18 pontos.
barra();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"# Apelido: {nickname.PadRight(18,'.').Substring(0,18)} #"); // 18 pontos.
barra();
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"# Idade:   {age.PadRight(18,'.').Substring(0,18)} #"); // 18 pontos.
barra();
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"# Cor:     {colorfun.PadRight(18,'.').Substring(0,18)} #"); // 18 pontos.
barra();
Console.ResetColor();