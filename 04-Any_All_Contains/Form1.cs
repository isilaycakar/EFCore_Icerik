namespace _04_Any_All_Contains
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] iller = new string[] { "Ankara", "Ýstanbul", "Ýzmir", "Antalya", "Konya", "Hatay", "Kahramanmaraþ", "Muðla" };
        List<Personel> personeller = new List<Personel>()
        {
            new Personel() {PersonelId= 1, Name = "Iþýlay1", Age = 24 },
            new Personel() {PersonelId= 2, Name = "Iþýlay2", Age = 19 },
            new Personel() {PersonelId= 3, Name = "Iþýlay3", Age = 21 },
            new Personel() {PersonelId= 4, Name = "Iþýlay4", Age = 25 },
            new Personel() {PersonelId= 5, Name = "Iþýlay5", Age = 32 }
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            //any metodu = listenin içindeki koþullara uyan kayýt varsa true aksiyse false
            //all metodu = listenin içinde koþullara tüm kayýtlar uyuyor mu bakýyor uyarsa true aksiyse false
            //contains metodu = lisenin içinde koþullara uyan kayýt var mý bakýyor uyarsa true aksiyse false. Karmaþýk listelerde iþlevsiz.Basit veri tiplerinde kullanýlýyor.

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
            MessageBox.Show(personeller.Any(x => x.Name == "Iþýlay").ToString());

        }
    }
}
public class Personel
{
    public int PersonelId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}