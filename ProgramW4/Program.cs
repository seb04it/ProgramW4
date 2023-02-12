//Zał: Są tylko 2 płcie (Mężczyzna/Kobieta)
//Zał: Są tylko 2 imiona (Ewa/Marek)
//Zał: Imiona przypisujemy płci (np. Marek/Mężczyzna, Ewa/Kobieta)

string name = "Marek";
string gender = "Mężczyzana";
int age = 33;

if(gender == "Kobieta" && age < 30)
{
    Console.WriteLine("Kobieta, poniżej 30");
}
else if(name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if(gender != "Kobieta" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else if(gender != "Kobieta" && age > 18)
{
    Console.WriteLine("Pełnoletni mężczyzna");
}