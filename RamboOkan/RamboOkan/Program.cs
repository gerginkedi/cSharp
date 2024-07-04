char[] consonants = new char[] { 'z', 'y', 'v', 't', 'ş', 's', 'r', 'm', 'l', 'k', 'h', 'j', 'ğ', 'g', 'd', 'ç', 'c', 'b', 'x', 'w', 'f'};



Console.WriteLine("kelime giriniz");
string? word = Console.ReadLine();

int? wordLenght = word?.Length;

Console.WriteLine(word);
for (int i = 0; i < wordLenght - 1; i++)
{

    if (word[i] == word[i + 1])
          Console.WriteLine(word[i] + "'harfinden yanyana 2 tane var");

}