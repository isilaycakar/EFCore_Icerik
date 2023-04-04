namespace _03_ExtensionMethodİleLinq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] iller = new string[] { "Ankara", "İstanbul", "İzmir", "Antalya", "Konya", "Hatay", "Kahramanmaraş", "Muğla" };

        private void btnTumunuListele_Click(object sender, EventArgs e)
        {
            lbxListe.DataSource = null;
            lbxListe.DataSource = iller;
        }

        private void btnAltidanFazlaOlan_Click(object sender, EventArgs e)
        {
            List<string> list = iller.Where(il => il.Length > 6).ToList();

            lbxListe.DataSource = null;
            lbxListe.DataSource = list;
        }

        private void btnAdanZyeSirala_Click(object sender, EventArgs e)
        {
            List<string> list = iller.OrderBy(il => il).Select(x=>x).ToList();

            lbxListe.DataSource = null;
            lbxListe.DataSource = list;

        }

        private void btnZdenAyaSirala_Click(object sender, EventArgs e)
        {
            List<string> list = iller.OrderByDescending(il => il).Select(x => x).ToList();

            lbxListe.DataSource = null;
            lbxListe.DataSource = list;
        }

        private void btnAİleBaslayanlar_Click(object sender, EventArgs e)
        {
            List<string> list = iller.Where(il =>il.StartsWith("A")).ToList();

            lbxListe.DataSource = null;
            lbxListe.DataSource = list;
        }

        private void btnYaİleBitenler_Click(object sender, EventArgs e)
        {
            //List<string> list = iller.Where(il => il.EndsWith("ya")).ToList();
            
            List<string> liste = new List<string>();

            foreach (var item in iller)
            {
                if (item.EndsWith("ya"))
                {
                    liste.Add(item);
                }
            }

            lbxListe.DataSource = null;
            lbxListe.DataSource = liste;
        }
    }
}