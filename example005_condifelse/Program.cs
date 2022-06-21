Console.Write("Input your name: ");
string username = Console.ReadLine();

if(username.ToLower() == "bob")
{
    Console.WriteLine ("That is Bob");
}
else
{
    Console.Write ("Hello, ");
    Console.WriteLine(username);
}