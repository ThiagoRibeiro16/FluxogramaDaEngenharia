Console.Clear();

string respostaMover;
string respostaDeveria;

Console.WriteLine("--- Fluxograma da Engenharia ---");

Console.Write("O objeto está se movendo (S/N)? ");
respostaMover = Console.ReadLine()!.ToUpper();

Console.Write("Deveria (S/N)? ");
respostaDeveria = Console.ReadLine()!.ToUpper();

if (respostaMover == "S" && respostaDeveria == "S")
{
    Console.WriteLine("Otímo");
}

else if (respostaMover == "S" && respostaDeveria == "N")
{
    Console.WriteLine("Use Silver Tape.");
}

else if (respostaMover == "N" && respostaDeveria == "S")
{
    Console.WriteLine("Use WD-40.");
}

else if (respostaMover == "N" && respostaDeveria == "N")
{
    Console.WriteLine("Otímo");
}
else
{
    Console.WriteLine("Resposta inválida.");
}


