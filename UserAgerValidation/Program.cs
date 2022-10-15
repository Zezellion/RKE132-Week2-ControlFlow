// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal sisestada tema vanuse
//kui kasutaja vanus on väiksem, siis konsoolis kuvatakse:
//"You are yoo young to use Instagram"
//muul juhul
//konsoolis kuvatakse "Welcome to Instagram"

Console.WriteLine("Enter your age:");

int userAge = Int32.Parse(Console.ReadLine());

if(userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
}
else
{
    Console.WriteLine("You are too young to use Instagram");
}