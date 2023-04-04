namespace _02_LinqSorgulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] iller = new string[] { "Ankara", "�stanbul", "�zmir", "Antalya", "Konya", "Hatay", "Kahramanmara�", "Mu�la" };

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

        private void btnA�leBaslayanlar_Click(object sender, EventArgs e)
        {
            IEnumerable<string> list = from il in iller
                                       where il.StartsWith("A")
                                       select il;

            lbxListe.DataSource = null;
            lbxListe.DataSource = list.ToList();
        }

        private void btnYa�leBitenler_Click(object sender, EventArgs e)
        {
            IEnumerable<string> list = from il in iller
                                       where il.EndsWith("ya")
                                       select il;

            lbxListe.DataSource = null;
            lbxListe.DataSource = list.ToList();
        }
    }
}