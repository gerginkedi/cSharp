Console.WriteLine("Enter a Word");
string? Word = Console.ReadLine();

Console.WriteLine("Enter The Number");
int Number = Convert.ToInt32(Console.ReadLine());

string newWord = string.Empty;
for (int indexWordChar = 0; indexWordChar < Word.Length; indexWordChar++)
{
    if (indexWordChar == Number)
        continue;
    newWord += Word[indexWordChar];
}
Console.WriteLine(newWord) ;

return;

List<string> Array = new List<string>();

int Lngth = Word.Length;

for(int i = 0; i<Lngth; i++)
{
   string Banana = Word.ToCharArray()[i].ToString();
   Array.Add(Banana);
}

string[] a = Array.ToArray();
    
Array.RemoveAt(Number-1);


for (int i = 0; i < Array.Count; i++)
{
    Console.WriteLine(Array[i]);
}
