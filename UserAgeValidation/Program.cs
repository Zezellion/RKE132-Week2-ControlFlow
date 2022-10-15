// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajalt valida tema sugu (m/f)
//rakendus küsib kasutajal sisestada tema perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgnevalt:
//"Welcome, Mr. [kasutaja perekonnanimi] / "Welcome, Ms [kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gender (m/f):");

char userGender = char.Parse(Console.ReadLine());

Console.WriteLine("Please, enter your last name");
string userLastname = Console.ReadLine();


if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr.{userLastname}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms.{userLastname}!");
}
else
{
    Console.WriteLine("Welcome!");
}
