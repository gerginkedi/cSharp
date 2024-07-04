using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınıflaaar
{
    internal class emlak
    {
        private string semt;
        private int odaSayisi;
        private string renk;
        private int katNo;
        private double alan;

        public string Semti
        {
            get { return semt; }
            set { semt = value.ToUpper(); }
        }
            public string Rengi 
        { 
            get { return renk; }
            set { renk = value.ToUpper(); }
        }
        
        public int OdaSayisi
        {
            get { return odaSayisi; }
            set { odaSayisi = Math.Abs(value); }
        }
        public int KatNo
        {
            get { return katNo; }
            set { katNo = Math.Abs(value); }
        }


    }
}
