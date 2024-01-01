var name = "Ewa";
var sex = 'k';
var age = 30;

if (sex == 'k' && age <= 30)
{
    if (name == "Ewa" && age == 30)
    {
        Console.WriteLine("Ewa, lat 30");
    }
    else
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
}
else if (sex == 'm' && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
