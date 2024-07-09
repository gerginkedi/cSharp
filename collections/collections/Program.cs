using System.Collections;
namespace collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArraayList
            //kolksiyolnlari kullanabilmek icin System.Collectionnus using System.Collections; bu sekilde import etmek gerek
            //listler dizilerden daha kullanislidir ama sistemi daha cok yorar ve yavastir
            ArrayList a = new ArrayList();
            a.Add("sifir");
            a.Add("bir");
            a[1] = 0;
            #endregion

            #region List
            //arrayListten farki nesneleri boxing yaparak tumak yerine tip tip tutar tipki dizler gibi 
            List<int> Liste = new List<int>();
            #endregion

        }
    }
}