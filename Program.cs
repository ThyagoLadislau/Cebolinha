string fraseUsuario, fraseComDislalia;

Console.Write("Digite uma flase: ");
fraseUsuario = Console.ReadLine()!;


fraseComDislalia = fraseUsuario
    .Replace("r", "l")
    .Replace("R", "L");

Console.WriteLine(fraseComDislalia);
