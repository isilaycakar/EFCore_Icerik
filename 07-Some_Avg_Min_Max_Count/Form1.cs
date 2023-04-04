namespace _07_Some_Avg_Min_Max_Count
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

        }
    }
}
public class Personel
{
    public int PersonelId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}