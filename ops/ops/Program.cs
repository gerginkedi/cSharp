namespace ops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ++ -- operatorleri
            int b = 12;
            b++;    // dedigimiz zaman once yazar sonra arttirir.
            ++b;    // deidigmiz zaman once arttirir sonra yazar.
                    //yani console.writeline(b++) seklinde yazarsak yine 12 yazcaka ama ondan sonra birdaha byi yazdrimak istersek 13 yazdircak.
            #endregion
            #region >< operatorleri
            int a = 3;
            int k = 5;
            //a<k dersek ve bunu bi degiskene atarsak sonuc boolean turunde true olarak cikicaktir.
            //a>k dersek tam tersi olarak false dondurecektir.
            //<= : kucuk esit, >= buyuk esit demek buyuktur kucuktur ifadelerindeki seyler bunun icin de gecerlidir.
            #endregion
            #region || && operatorleri
            // || veya 
            // && ve 
            // ikisi de boolean tipde sonuc dondurur
            #endregion
            #region swtich case
            int x = 12;
            switch (x) 
            {
                case 0:
                    Console.WriteLine();
                    break;  
                case 12: goto case 0;// eger deger 12 ise 0 yazan case blogunu calistir demektir goto
                    Console.WriteLine("sa");    
                    break;
                    // istedign kadar case break blogu ekleyebilirsin fkaat ustte yazdigin deger hicbirine esiit deilse bos gecicektir
                    // ilk esit olana girer sonrasina bakmaz
                    default:
                    Console.WriteLine("merhaba");
                    break;
                    // default blogu case bloklarindan hicbiri tetiklenmiyorsa tetiklenir
                    
            }
            #endregion
            #region
            if(true)// buraya boolean turunde bi deger yazmak gerekir
            {
                // kosulun degeri true ise burasi calisir   
                // boolean turunde bir degiskenin basina ! koymak false yapar
            }
            else 
            {
                //deilse burasi calisir
            }
            #endregion


        }
    }
}