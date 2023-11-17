namespace zinsGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CmdAusrechnen_Click(object sender, EventArgs e)
        {
            double Startkapital = double.Parse(tBStartkapital.Text);
            double Zinsatz = double.Parse(tBZinssatz.Text) / 100;
            int Jahrezuberchnen = int.Parse(tBJahrezuberechnen.Text);
            double Zwischenzahl;


            for (int Jahr = 1; Jahr <= Jahrezuberchnen; Jahr++)
            {
                Zwischenzahl = Startkapital * Zinsatz;
                Startkapital = Startkapital + Zwischenzahl;
                LblAusgabe.Text += ($"Jahr {Jahr}: Kapital = {Startkapital:C2}\n");
        }
        }
    }
}