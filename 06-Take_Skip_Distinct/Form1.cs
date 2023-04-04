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
            new Personel() {PersonelId= 1, Name = "I��lay1", Age = 24 },
            new Personel() {PersonelId= 2, Name = "I��lay1", Age = 19 },
            new Personel() {PersonelId= 3, Name = "I��lay3", Age = 21 },
            new Personel() {PersonelId= 4, Name = "I��lay4", Age = 25 },
            new Personel() {PersonelId= 5, Name = "I��lay5", Age = 32 }
        };
        private void Form1_Load(object sender, EventArgs e)
        {
            //Take() : SQL deki TOP keyword'�ne kar��l�k gelmektedir. Yani Elimizdeki listenin i�erisindeki ilk n kayd� geriye d�ner. (ilk 5, ilk 10 gibi)

            // Skip() : Elimizdeki listenin i�indeki ilk n kayd�d atlar ve sonrakileri geri d�ner.

            //Distincit(): Yinelenen sat�lar� kald�rarak tekil olarak liste halinde geriye d�ner.
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

        private void btnPersonel�simTekil_Click(object sender, EventArgs e)
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