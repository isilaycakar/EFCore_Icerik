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
            new Personel() {PersonelId= 1, Name = "I��lay1", Age = 24 },
            new Personel() {PersonelId= 2, Name = "I��lay2", Age = 19 },
            new Personel() {PersonelId= 3, Name = "I��lay3", Age = 21 },
            new Personel() {PersonelId= 4, Name = "I��lay4", Age = 25 },
            new Personel() {PersonelId= 5, Name = "I��lay5", Age = 32 }
        };

        List<Personel> personelBos = new List<Personel>();
        List<Personel> personelTek = new List<Personel>()
        {
            new Personel() {PersonelId= 1, Name = "I��lay", Age = 24 }
        };


        private void Form1_Load(object sender, EventArgs e)
        {
            //First metodu = listedeki ilk eleman� d�ner. Eleman yoksa hata verir.
            //FirstOrDefault metodu = Listenin ilk eleman� d�ner. Eleman yoksa eleman�n varsay�lan de�erleriyle bir de�er d�ner.

            //Single metodu = listede bir tane eleman var m� yok mu diye bakar, bir tane varsa o eleman� d�ner. Yoksa veya birden fazlaysa hata verir.
            //SingleOrDefault metodu = listede bir tane eleman var m� yok mu diye bakar, bir tane varsa o eleman� d�ner. Yoksa hata vermez varsay�lann de�eri d�ner. Birden fazlaysa hata verir.

            //Last metodu = listedeki son eleman� d�ner. Eleman yoksa hata verir.
            //LastOrDefault metodu = Listenin son eleman� d�ner. Eleman yoksa eleman�n varsay�lan de�erleriyle bir de�er d�ner.
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