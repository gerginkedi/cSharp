namespace NesneUzerindenMetod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Matematik matematik = new Matematik();
            double sonuc = matematik.Topla(12, 3, 5); 
             
            //obje. yazdigimizda cikan ve classin icinde bulunan metodlarin disindaki metodlar object oldugu icin olur
            MessageBox.Show(Convert.ToString(sonuc));
            Matematik matematik1 = new Matematik();
            Matematik matematik2 = null;
        }
    }
}