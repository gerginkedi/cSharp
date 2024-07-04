namespace konsolapp_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region string to int
            string b = "123";
            int a = Convert.ToInt32(b);
            //Console.WriteLine(a);            
            //Console.Read();

            #endregion

            #region double to string
            double qu = 12.3;
            string ku = Convert.ToString(qu);
            //Console.WriteLine(ku);
            //Console.Read();
            #endregion

            #region bool to string
            bool ax = true;
            string xa = Convert.ToString(ax);
            //Console.WriteLine(xa);
            //Console.ReadLine();
            #endregion

            #region string to boolean
            string aw = "true";
            Boolean owo = Convert.ToBoolean(aw);
            //Console.WriteLine(owo);
            //Console.ReadLine();
            #endregion

            #region int.parse
            //parse metodu sadece string ifadeeleri cevirir
            string koa = "123";
            int kuj = int.Parse(koa);
            //Console.WriteLine(kuj);
            //Console.ReadLine();
            #endregion

            #region string to decimal
            string hok = "321";
            decimal uk = int.Parse(hok);
            //Console.WriteLine(uk);
            //Console.ReadLine();
            #endregion

            #region char to int 
            char luk = 'o';
            int jul = Convert.ToInt32(luk);
            //Console.WriteLine(jul);
            //Console.ReadLine();

            int j = 110;
            char hu = Convert.ToChar(j);
            //Console.WriteLine(hu);
            //Console.ReadLine();
            #endregion

            #region checked - uncheckhed
            checked
            {
                int oky = 122;
                byte ru = Convert.ToByte(oky);
                Console.WriteLine(ru);
                Console.ReadLine();
            }
            
            
            #endregion


        }
    }
}