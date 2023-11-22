using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
//Name : ALi Bahiraei
//Date :20/07/2023
//description : it's converter project
namespace Project_Final
{
    public partial class FrmTemp : Form
    {
        private string conversionFilePath = @".\Files\TempConversions.txt";
        public FrmTemp()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cnvr_Click(object sender, EventArgs e)
        {
            try
            {
                string temp = textBox_C.Text;
                if (string.IsNullOrEmpty(temp)) throw new Exception("Please enter a temperature");

                // REGEX
                if (!Regex.IsMatch(temp, @"^-?\d*\.?\d*$")) throw new Exception("Please enter a valid number");

                double tempValue = double.Parse(temp);

                StreamWriter sw = new StreamWriter(conversionFilePath, true);
                string description = ""; // initialize the variable 
                if (radioButton_CF.Checked)
                {
                    double result = (tempValue - 32) * 5 / 9;
                    textBox2.Text = result.ToString();
                    description = GetDescription(result);
                    sw.WriteLine($"{temp} F = {result} C, {DateTime.Now} {description}");

                    textBox_C.BackColor = GetColor(result);
                }
                else if (radioButton_FC.Checked)
                {
                    //double result = tempValue * 9 / 5 + 32;
                    //textBox2.Text = result.ToString();
                    //description = GetDescription(tempValue);
                    //sw.WriteLine($"{temp} C = {result} F, {DateTime.Now} {description}");

                    //textBox_C.BackColor = GetColorF(tempValue);

                    double result = tempValue * 9 / 5 + 32;
                    textBox2.Text = result.ToString();
                    description = GetDescriptionF(result);
                    sw.WriteLine($"{temp} C = {result} F, {DateTime.Now} {description}");

                    textBox_C.BackColor = GetColorF(result);
                }

                textBox_message.Text = description; // Added this line to display the description
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader(conversionFilePath))
                {
                    string content = sr.ReadToEnd();
                    MessageBox.Show(content, "Temperature Conversions - Erfan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {        
                if (MessageBox.Show("Do you want to close theApp.? ", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
                {
                    this.Close();
                }
            
        }

        private void radioButton_CF_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_CF.Checked)
            {
                // Get the current positions of the labels
                Point labelFPosition = Label_F.Location;
                Point labelCPosition = Label_C.Location;

                // Swap the positions of the labels
                Label_F.Location = labelCPosition;
                Label_C.Location = labelFPosition;
            }
        }

        private void radioButton_FC_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_FC.Checked)
            {
                // Get the current positions of the labels
                Point labelFPosition = Label_F.Location;
                Point labelCPosition = Label_C.Location;

                // Swap the positions of the labels
                Label_F.Location = labelCPosition;
                Label_C.Location = labelFPosition;
            }
        }

        
        private string GetDescription(double temp)
        {  
            if (temp >= 100)
                return "Water boils";
            else if (temp >= 40)
                return "Hot Bath";
            else if (temp >= 37)
                return "Body temperature";
            else if (temp >= 30)
                return "Beach weather";
            else if (temp >= 21)
                return "Room temperature";
            else if (temp >= 10)
                return "Cool Day";
            else if (temp >= 0)
                return "Freezing point of water";
            else if (temp >= -18)
                return "Very Cold Day";
            else
                return "Extremely Cold Day";
        }

        private Color GetColor(double temp)
        {
            if (temp >= 30)
                return Color.Red;
            else if (temp >= 10)
                return Color.Green;
            else
                return Color.Blue;
        }

        private Color GetColorF(double temp)
        {
            if (temp >= 86)
                return Color.Red;
            else if (temp >= 55)
                return Color.Green;
            else
                return Color.Blue;
        }



        private string GetDescriptionF(double temp)
        {
            if (temp >= 212)
                return "Water boils";
            else if (temp >= 104)
                return "Hot Bath";
            else if (temp >= 98.6)
                return "Body temperature";
            else if (temp >= 86)
                return "Beach weather";
            else if (temp >= 70)
                return "Room temperature";
            else if (temp >= 50)
                return "Cool Day";
            else if (temp >= 32)
                return "Freezing point of water";
            else if (temp >= 0)
                return "Very Cold Day";
            else
                return "Extremely Cold Day";
        }

        private void FrmTemp_Load(object sender, EventArgs e)
        {

        }
    }
}
