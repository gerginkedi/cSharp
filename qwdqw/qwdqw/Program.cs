
Console.WriteLine("alanını bulmak istediğiniz şekili yazınıc");
Console.WriteLine("üçgen, poligon");

string? secim = Console.ReadLine();

if (secim == "üçgen")
{
    Console.WriteLine("Lütfen yükseklik ve taban giriniz");
    var highTriangle = Convert.ToInt32(Console.ReadLine());
    
    var baseTriangle = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine((baseTriangle*highTriangle)/2);
}

else if(secim == "poligon")
{
    Console.WriteLine("lütfen kenar sayısı giriniz");
    var numberOfEdges = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("lütfen kenar uzunluğu giriniz");
    var lenghtOfEdges = Convert.ToInt32(Console.ReadLine());

    
}