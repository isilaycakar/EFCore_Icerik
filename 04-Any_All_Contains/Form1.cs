namespace _04_Any_All_Contains
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] iller = new string[] { "Ankara", "�stanbul", "�zmir", "Antalya", "Konya", "Hatay", "Kahramanmara�", "Mu�la" };
        List<Personel> personeller = new List<Personel>()
        {
            new Personel() {PersonelId= 1, Name = "I��lay1", Age = 24 },
            new Personel() {PersonelId= 2, Name = "I��lay2", Age = 19 },
            new Personel() {PersonelId= 3, Name = "I��lay3", Age = 21 },
            new Personel() {PersonelId= 4, Name = "I��lay4", Age = 25 },
            new Personel() {PersonelId= 5, Name = "I��lay5", Age = 32 }
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            //any metodu = listenin i�indeki ko�ullara uyan kay�t varsa true aksiyse false
            //all metodu = listenin i�inde ko�ullara t�m kay�tlar uyuyor mu bak�yor uyarsa true aksiyse false
            //contains metodu = lisenin i�inde ko�ullara uyan kay�t var m� bak�yor uyarsa true aksiyse false. Karma��k listelerde i�levsiz.Basit veri tiplerinde kullan�l�yor.

        }

        private void btnAll1830_Click(object sender, EventArgs e)
        {
            MessageBox.Show(personeller.All(x => x.Age > 18 && x.Age < 30).ToString());
        }

        private void btnAll1840_Click(object sender, EventArgs e)
        {
            MessageBox.Show(personeller.All(x => x.Age > 18 && x.Age < 40).ToString());

        }

        private void btnAge1820_Click(object sender, EventArgs e)
        {
            MessageBox.Show(personeller.Any(x => x.Age > 18 && x.Age < 20).ToString());
        }

        private void btnAge1830_Click(object sender, EventArgs e)
        {
            MessageBox.Show(personeller.Any(x => x.Age > 18 && x.Age < 30).ToString());

        }

        private void btnAdiAnkara_Click(object sender, EventArgs e)
        {
            MessageBox.Show(iller.Contains("Ankara").ToString());
        }

        private void btnPersonelIsilay2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(personeller.Any(x => x.Name == "I��lay").ToString());

        }
    }
}
public class Personel
{
    public int PersonelId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}