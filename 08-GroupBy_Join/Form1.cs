using System.Windows.Forms;

namespace _08_GroupBy_Join
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Departman> deparmanlar = new List<Departman>()
        {
            new Departman() {DepartmanId= 1, DepartmanAdi= "Bilgi Ýþlem"},
            new Departman() {DepartmanId= 2, DepartmanAdi= "Muhasabe"},
            new Departman() {DepartmanId= 3, DepartmanAdi= "Satýn Alma"}
        };

        List<Personel> personeller = new List<Personel>()
        {
            new Personel() {PersonelId= 1, Name = "Iþýlay", Age = 38, DepartmanId= 1 },
            new Personel() {PersonelId= 2, Name = "Barýþ", Age = 25, DepartmanId= 1 },
            new Personel() {PersonelId= 3, Name = "Muhammed", Age = 25, DepartmanId= 2 },
            new Personel() {PersonelId= 4, Name = "Iþýl Bilge", Age = 38, DepartmanId= 3 },
            new Personel() {PersonelId= 5, Name = "Ayça", Age = 23, DepartmanId= 3 }
        };
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGroupAge_Click(object sender, EventArgs e)
        {
            var list = personeller.GroupBy(x => x.Age).ToList();
            List<PersonelSatir> yeniPersonelListesi = new List<PersonelSatir>();
            foreach (var item in list)
            {
                PersonelSatir personelSatir = new PersonelSatir();
                personelSatir.Yas = item.Key; //key gruplama yapýlan alanýn deðerini veriyor.
                personelSatir.Isimler = string.Join(", ", item.Select(x => x.Name));

                yeniPersonelListesi.Add(personelSatir);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = yeniPersonelListesi;

        }

        private void btnPersonelDepartman_Click(object sender, EventArgs e)
        {
            var list = personeller.Join(
                                        deparmanlar,
                                        p => p.DepartmanId,
                                        d => d.DepartmanId,
                                        (personel, departman) => new DepartmanSatir
                                        {
                                            PersName = personel.Name,
                                            DepName = departman.DepartmanAdi
                                        }).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }
    }
}

public class Personel
{
    public int PersonelId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int DepartmanId { get; set; }

}
public class Departman
{
    public int DepartmanId { get; set; }
    public string DepartmanAdi { get; set; }
}
public class PersonelSatir
{
    public int Yas { get; set; }
    public string Isimler { get; set; }
}
public class DepartmanSatir
{
    public string PersName { get; set; }
    public string DepName { get; set; }
}