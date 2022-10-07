/* // See https://aka.ms/new-console-template for more information
Console.WriteLine
("Hello, World!")
;
string[] names = new string[3] { "John", "Mary", "Bob" };
Console.WriteLine(names[0]);
int tallen = 3;
int tallto = 4;
Console.WriteLine(tallen);
Console.WriteLine(tallen + tallto);
Console.WriteLine(tallen - tallto);
Console.WriteLine(tallen * tallto);
Console.WriteLine(tallen / tallto);
Console.WriteLine(tallen % tallto);
Console.WriteLine(tallen++);
Console.WriteLine("tallen er nå " + tallen);
if (tallen == tallto)
{
Console.WriteLine("tallen er lik tallto");
}
else
{
Console.WriteLine("tallen er ikke lik tallto");
};

float floaten = 3.5f;
float floatto = 4.5f;

if (floaten > floatto) // >, <, >=, <=, ==, !=
{
Console.WriteLine("floaten er større enn floatto");
}
else
{
Console.WriteLine("floaten er ikke større enn floatto");
};



int dag = 5;
switch (dag)
{
    case 1:
        Console.WriteLine("Mandag");
        break;
    case 2:
        Console.WriteLine("Tirsdag");
        break;
    case 3:
        Console.WriteLine("Onsdag");
        break;
    case 4:
        Console.WriteLine("Torsdag");
        break;
    case 5:
        Console.WriteLine("Fredag");
        break;
    default:
        Console.WriteLine("det er ikke helg");
        break;
}

if (dag == 6)
{
    Console.WriteLine("Lørdag");
}
else if (dag == 7)
{
    Console.WriteLine("Søndag");
}
else
{
    Console.WriteLine("noe gikk galt");
}
*/