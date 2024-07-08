using System.Runtime.InteropServices;

namespace constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ornek o = new Ornek();
            int[] yaslar = new int[4];
            //burda object uretim asamasinda ik itane parantez acip kapatiyosak varysailan constructordir
        }

        
        class Ornek
        {

            
            #region Constructor
            //constructor metod public olmalidir
            //construcotr metodun geri donus degferi olmaz
            //construcor metodun ismi class ismi ile ayni olmak zorundadir
            //geri donus olmiyacagi icin void yazilmasi beklenir ama o da yazilmaz 
            //bir siniftan onject uretilirkenherseyedne once construcotr tetiklenir
            //constructor overload olabilir
            public int x { get; set; }
            public Ornek() // constructor metod
            {
                x = 15;
            }

            #endregion

            #region Static Constructor
            #endregion
        }
    }
}