Console.WriteLine("How old are you?");
string ageS = Console.ReadLine();
int age = Convert.ToInt32(ageS);
bool isChild = 0 <= age && age <= 12;
bool isTeenager = 13 <= age && age <= 19;
bool isAdult = 19 < age;
if (isChild)
{
    Console.WriteLine("You're a child");
}
else if (isTeenager)
{
    Console.WriteLine("You're a teenager");
}
else if (isAdult)
{
    Console.WriteLine("You're an adult");
}
else
{
    Console.WriteLine("Please try again");
}