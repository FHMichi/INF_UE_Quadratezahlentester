namespace INF_UE_Quadratezahlentester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //wird beim Start des Programms einmal ausgeführt 
            lblDiffifulty.Text = tbDifficulty.Value.ToString();
        }

        private void btmNewTest_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            lblRandomZ.Text = "" + rand.Next(1, tbDifficulty.Value);
        }


        private void btmTest_Click(object sender, EventArgs e)
        {
            int userEntry = Int32.Parse(tbEntry.Text);
            int squared = Int32.Parse(lblRandomZ.Text);


            if (Math.Pow(squared, 2) == userEntry)
                lblResult.Text = "Richtig geraten";
            else
                lblResult.Text = "Falsch geraten";
        }

        private void tbDifficulty_Scroll(object sender, EventArgs e)
        {
            lblDiffifulty.Text = tbDifficulty.Value.ToString();
        }
    }
}
