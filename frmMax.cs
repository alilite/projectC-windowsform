using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//frmMax
//Name:Ali Bahiraei
//Date : 18/07/2023
//descripton:it's frmMax class that we use class according to word document
namespace project_section1
{
    public partial class frmMax : Form
    {
        public frmMax()
        {
            InitializeComponent();
        }

        private void lottoali2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> numbersList = Enumerable.Range(1, 50).ToList(); // Creates a list of numbers 1 to 50
            Random random = new Random();
            string numbers = "";

            // Shuffle my numbers
            for (int i = numbersList.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                int temp = numbersList[i];
                numbersList[i] = numbersList[j];
                numbersList[j] = temp;
            }

            // Determine the number of random numbers to generate
            int frmMax = 8;
            int numNumbers = frmMax; // same thing for 649




            // Add the first 8 to the shuffled numbers to the string
            for (int i = 0; i < 8; i++)
            {
                numbers += numbersList[i].ToString() + "\t";
            }



            // Remove the trailing comma
            numbers = numbers.TrimEnd(',');


            // Create the line to be saved in the text file
            string lotteryName = "Max"; // we will do the same for 649 
            string dateTime = DateTime.Now.ToString("yyyy/M/d h:mm:ss tt");
            string line = $"{lotteryName}, {dateTime}, {numbers}";
            string filePath = @".\Files\LottoNbrsMax.txt";


            // Save the line to the text file
            StreamWriter writer = new StreamWriter(filePath, true);
            writer.WriteLine(line);
            writer.Close();

            textBox1.Text = numbers;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Read the contents of the text file
            string fileContent;
            string filePath = @".\Files\LottoNbrsMax.txt";
            StreamReader reader = new StreamReader(filePath);
            fileContent = reader.ReadToEnd();
            reader.Close();

            // Display the contents in a message box
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
    }
}
