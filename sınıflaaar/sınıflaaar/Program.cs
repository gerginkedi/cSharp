namespace sınıflaaar
{
    class program
    {
        static void Main(string[] args)
        {
            emlak eml = new emlak();
            eml.Semti = "şişli";
            eml.Rengi = "mavi";
            eml.OdaSayisi = 4;
            eml.KatNo = 8;

            Console.WriteLine("evin bulunduğu semt:"+eml.Semti);
            Console.WriteLine("evin oda renkleri:"+eml.Rengi);
            Console.WriteLine("evin toplam oda sayısı:"+eml.OdaSayisi);
        
        }
    }
}