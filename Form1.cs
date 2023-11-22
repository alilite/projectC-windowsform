using Project_Final;

namespace project_section1
{
    //Name:Ali Bahiraei
    //Date : 18/07/2023
    //descripton:it's main form that handle everything
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            IPvalidatoralibh pvalidatoralibh = new IPvalidatoralibh();
            pvalidatoralibh.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            simple_calculatoralibh calculatorali = new simple_calculatoralibh();
            calculatorali.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close theApp.? ", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frm649 Generatedali1 = new frm649();
            Generatedali1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmMax frmMax1 = new frmMax();
            frmMax1.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FrmMoney frmMoney = new FrmMoney();
            frmMoney.Show();
        }

       

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FrmTemp frmTemp1 = new FrmTemp();
            frmTemp1.Show();
        }
    }
}