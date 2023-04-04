namespace _06_Take_Skip_Distinct
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
            new Personel() {PersonelId= 2, Name = "Iþýlay1", Age = 19 },
            new Personel() {PersonelId= 3, Name = "Iþýlay3", Age = 21 },
            new Personel() {PersonelId= 4, Name = "Iþýlay4", Age = 25 },
            new Personel() {PersonelId= 5, Name = "Iþýlay5", Age = 32 }
        };
        private void Form1_Load(object sender, EventArgs e)
        {
            //Take() : SQL deki TOP keyword'üne karþýlýk gelmektedir. Yani Elimizdeki listenin içerisindeki ilk n kaydý geriye döner. (ilk 5, ilk 10 gibi)

            // Skip() : Elimizdeki listenin içindeki ilk n kaydýd atlar ve sonrakileri geri döner.

            //Distincit(): Yinelenen satýlarý kaldýrarak tekil olarak liste halinde geriye döner.
        }

        private void btnTumunuGetir_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = personeller;
        }

        private void btnIlk2Kayit_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = personeller.Take(2).ToList();
        }

        private void btnSonraki2Kayit_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = personeller.Skip(2).Take(2).ToList();
        }

        private void btnPersonelÝsimTekil_Click(object sender, EventArgs e)
        {
            List<string> list = personeller.Select(x => x.Name).Distinct().ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;

            string isimler = string.Join(", ", list);
            MessageBox.Show(isimler);
        }
    }
}

public class Personel
{
    public int PersonelId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}