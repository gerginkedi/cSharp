List<string> reverse = new List<string>();

Console.WriteLine("tersden yazılmasını istediğiniz ifadeyi giriniz");
string? pharse = Console.ReadLine();


for (int j = 0; j< pharse?.Length; j++)
{

    var asd = pharse[j].ToString();
    reverse.Add(asd);
}


string[] reverseArray = reverse.ToArray();
Array.Reverse(reverseArray);

for(int y = 0; y < pharse?.Length; y++)
{
    Console.Write(reverseArray[y]);
}