namespace _05_First_Single_Last
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Personel> personeller = new List<Personel>()
        {
            new Personel() {PersonelId= 1, Name = "Iþýlay1", Age = 24 },
            new Personel() {PersonelId= 2, Name = "Iþýlay2", Age = 19 },
            new Personel() {PersonelId= 3, Name = "Iþýlay3", Age = 21 },
            new Personel() {PersonelId= 4, Name = "Iþýlay4", Age = 25 },
            new Personel() {PersonelId= 5, Name = "Iþýlay5", Age = 32 }
        };

        List<Personel> personelBos = new List<Personel>();
        List<Personel> personelTek = new List<Personel>()
        {
            new Personel() {PersonelId= 1, Name = "Iþýlay", Age = 24 }
        };


        private void Form1_Load(object sender, EventArgs e)
        {
            //First metodu = listedeki ilk elemaný döner. Eleman yoksa hata verir.
            //FirstOrDefault metodu = Listenin ilk elemaný döner. Eleman yoksa elemanýn varsayýlan deðerleriyle bir deðer döner.

            //Single metodu = listede bir tane eleman var mý yok mu diye bakar, bir tane varsa o elemaný döner. Yoksa veya birden fazlaysa hata verir.
            //SingleOrDefault metodu = listede bir tane eleman var mý yok mu diye bakar, bir tane varsa o elemaný döner. Yoksa hata vermez varsayýlann deðeri döner. Birden fazlaysa hata verir.

            //Last metodu = listedeki son elemaný döner. Eleman yoksa hata verir.
            //LastOrDefault metodu = Listenin son elemaný döner. Eleman yoksa elemanýn varsayýlan deðerleriyle bir deðer döner.
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            Personel personel = personeller.First(x => x.Age >= 25);
            MessageBox.Show(personel.Name);
        }

        private void btnFirstOrDefault_Click(object sender, EventArgs e)
        {
            Personel personel = personeller.FirstOrDefault();
            MessageBox.Show(personel.Name);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            Personel personel = personeller.Last(x => x.Age >= 25);
            MessageBox.Show(personel.Name);
        }

        private void btnLastOrDefault_Click(object sender, EventArgs e)
        {
            Personel personel = personeller.LastOrDefault();
            MessageBox.Show(personel.Name);
        }

        private void btnSingle_Click(object sender, EventArgs e)
        {
            Personel personel = personelTek.Single();
            MessageBox.Show(personel.Name);
        }

        private void btnSingleOrDefault_Click(object sender, EventArgs e)
        {
            Personel personel = personeller.SingleOrDefault();
            MessageBox.Show(personel.Name);
        }
    }
}

public class Personel
{
    public int PersonelId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}