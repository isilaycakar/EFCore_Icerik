namespace _02_LinqSorgulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] iller = new string[] { "Ankara", "Ýstanbul", "Ýzmir", "Antalya", "Konya", "Hatay", "Kahramanmaraþ", "Muðla" };

        private void btnTumunuListele_Click(object sender, EventArgs e)
        {
            lbxListe.DataSource = null;
            lbxListe.DataSource = iller;
        }

        private void btnAltidanFazlaOlan_Click(object sender, EventArgs e)
        {
            IEnumerable<string> list = from il in iller
                                       where il.Length > 6
                                       select il;

            lbxListe.DataSource = null;
            lbxListe.DataSource = list.ToList();
        }

        private void btnAdanZyeSirala_Click(object sender, EventArgs e)
        {
            IEnumerable<string> list = from il in iller
                                       orderby il ascending
                                       select il;

            lbxListe.DataSource = null;
            lbxListe.DataSource = list.ToList();
        }

        private void btnZdenAyaSirala_Click(object sender, EventArgs e)
        {
            IEnumerable<string> list = from il in iller
                                       orderby il descending
                                       select il;

            lbxListe.DataSource = null;
            lbxListe.DataSource = list.ToList();
        }

        private void btnAÝleBaslayanlar_Click(object sender, EventArgs e)
        {
            IEnumerable<string> list = from il in iller
                                       where il.StartsWith("A")
                                       select il;

            lbxListe.DataSource = null;
            lbxListe.DataSource = list.ToList();
        }

        private void btnYaÝleBitenler_Click(object sender, EventArgs e)
        {
            IEnumerable<string> list = from il in iller
                                       where il.EndsWith("ya")
                                       select il;

            lbxListe.DataSource = null;
            lbxListe.DataSource = list.ToList();
        }
    }
}