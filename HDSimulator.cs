
Console.WriteLine("Welcome to the HD Repair Simulator");
Console.WriteLine("Run down of how things work............");

Console.WriteLine("Please Select a job and get to work: ");
Console.WriteLine("(Choose a job by selecting 1, 2, or 3: )");
void FirstJobOfTheDay() 
{
    Console.WriteLine("1. Customer states there is a weird noise coming from the front of the bike but only in 3rd gear");
    Console.WriteLine("2. Customer states theres a leak coming from the back tire and they want a 1K service **CUSTOMER IS A WAITER**");
    Console.WriteLine("3. Customer wants new front and rear tires/diag bearings front");
}

string jobSelection = Console.ReadLine();
if (jobSelection != null && jobSelection == "1") 
{
    Console.WriteLine("Oooh I dont know if you want to get wrapped up in a diag before you take care of a waiter, why dont you look at your options again?");
    FirstJobOfTheDay();
}
if (jobSelection != null && jobSelection == "2")
{
    Console.WriteLine("Lets get started you started on that waiter");
}
if (jobSelection != null && jobSelection == "3")
{
    Console.WriteLine("Oooh I dont know if you want to get wrapped up in a diag before you take care of a waiter, why dont you look at your options again?");
    FirstJobOfTheDay();
}
void WaiterScenerio() 
{
    
}
