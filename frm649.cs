using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//frm649
//Name:Ali Bahiraei
//Date : 18/07/2023
//descripton:it's frm649 class that we use class according to word document
namespace project_section1
{
    public partial class frm649 : Form
    {
        public frm649()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            List<int> numbersList = Enumerable.Range(1, 49).ToList();
            Random random = new Random();
            string numbers = "";


            for (int i = numbersList.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                int temp = numbersList[i];
                numbersList[i] = numbersList[j];
                numbersList[j] = temp;
            }

            int frm649 = 8;
            int numNumbers = frm649;


            for (int i = 0; i < 7; i++)
            {
                numbers += numbersList[i].ToString() + "\t";
            }


            numbers = numbers.TrimEnd(',');


            string lotteryName = "649";
            string dateTime = DateTime.Now.ToString("yyyy/M/d h:mm:ss tt");
            string line = $"{lotteryName}, {dateTime}, {numbers}";

            string filePath = @".\Files\LottoNbrs649.txt";
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));

            StreamWriter writer = new StreamWriter(filePath, true);
            writer.WriteLine(line);
            writer.Close();

            textBox1.Text = numbers;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileContent;
            string filePath = @".\Files\LottoNbrs649.txt";

            StreamReader reader = new StreamReader(filePath);
            fileContent = reader.ReadToEnd();
            reader.Close();

            string message = $"Lottery Numbers:\n\n{fileContent}";
            string title = "Lotto Numbers - Ali Bahiraei";
            MessageBox.Show(message, title);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close theApp.? ", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void Generatedali_Load(object sender, EventArgs e)
        {

        }
    }
}
