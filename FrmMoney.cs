using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
//Ali Bahiraei
//cash convertor
//Date:25/07/2023

namespace Project_Final
{
    public partial class FrmMoney : Form
    {
        private string conversionFilePath = @".\Files\MoneyConversions.txt";
        Stopwatch elapsedTime = new Stopwatch();
        public FrmMoney()
        {
            InitializeComponent();
            elapsedTime.Start();
        }

        private void btn_Cnvr_Click(object sender, EventArgs e)
        {
            try
            {
                Regex regex = new Regex(@"^\d*\.?\d*$");

                if (!regex.IsMatch(textBox_inputValue.Text))
                {
                    MessageBox.Show("Input must be a number.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                double inputValue = double.Parse(textBox_inputValue.Text);

                double cadToUsd = 0.73;
                double cadToEur = 0.67;
                double cadToGbp = 0.57;
                double cadToIrr = 31682.7;
                double cadToVnd = 17860.1;

                double usdToCad = 1.36;
                double usdToEur = 0.91;
                double usdToGbp = 0.76;
                double usdToIrr = 42105.0;
                double usdToVnd = 23680.3;

                double eurToCad = 1.49;
                double eurToUsd = 1.10;
                double eurToGbp = 0.84;
                double eurToIrr = 46830.7;
                double eurToVnd = 26058;

                double gbpToCad = 1.76;
                double gbpToUsd = 1.31;
                double gbpToEur = 1.19;
                double gbpToIrr = 55805.7;
                double gbpToVnd = 30550.1;

                double irrToCad = 0.000031;
                double irrToUsd = 0.000024;
                double irrToEur = 0.000021;
                double irrToGbp = 0.000018;
                double irrToVnd = 0.55676;

                double usd, cad, eur, gbp, irr, vnd;

                if (radioButtonCAD.Checked)
                {
                    cad = inputValue;
                    usd = cad * cadToUsd;
                    eur = cad * cadToEur;
                    gbp = cad * cadToGbp;
                    irr = cad * cadToIrr;
                    vnd = cad * cadToVnd;
                }
                else if (radioButtonUSD.Checked)
                {
                    usd = inputValue;
                    cad = usd * usdToCad;
                    eur = usd * usdToEur;
                    gbp = usd * usdToGbp;
                    irr = usd * usdToIrr;
                    vnd = usd * usdToVnd;
                }
                else if (radioButtonEUR.Checked)
                {
                    eur = inputValue;
                    cad = eur * eurToCad;
                    usd = eur * eurToUsd;
                    gbp = eur * eurToGbp;
                    irr = eur * eurToIrr;
                    vnd = eur * eurToVnd;
                }
                else if (radioButtonGBP.Checked)
                {
                    gbp = inputValue;
                    cad = gbp * gbpToCad;
                    usd = gbp * gbpToUsd;
                    eur = gbp * gbpToEur;
                    irr = gbp * gbpToIrr;
                    vnd = gbp * gbpToVnd;
                }
                else // radioButtonIRN.Checked
                {
                    irr = inputValue;
                    cad = irr * irrToCad;
                    usd = irr * irrToUsd;
                    eur = irr * irrToEur;
                    gbp = irr * irrToGbp;
                    vnd = irr * irrToVnd;

                }

                textBox_CAD.Text = cad.ToString("F6");
                textBox_USD.Text = usd.ToString("F6");
                textBox_EUR.Text = eur.ToString("F6");
                textBox_GBP.Text = gbp.ToString("F6");
                textBox_IRN.Text = irr.ToString("F6");
                textBox_VND.Text = vnd.ToString("F6");
                //textBox_VND.Text = cadToVnd.ToString("F6");
                //textBox_VND.Text = usdToVnd.ToString("F6");
                //textBox_VND.Text = eurToVnd.ToString("F6");
                //textBox_VND.Text = gbpToVnd.ToString("F6");
                //textBox_VND.Text = irrToVnd.ToString("F6");


                //string conversion = $"{DateTime.Now}\n{inputValue} input = {cad} CAD; {usd} USD; {eur} EUR; {gbp} GBP; {irr} IRR;\n";
                //string conversion = $"{DateTime.Now}\n{inputValue:F6} input = {cad:F6} CAD; {usd:F6} USD; {eur:F6} EUR; {gbp:F6} GBP; {irr:F6} IRR;\n";
                string conversion = $"{DateTime.Now}\n{inputValue:F6} input = {cad:F6} CAD; {usd:F6} USD; {eur:F6} EUR; {gbp:F6} GBP; {irr:F6} IRR; {vnd:F6} VND;\n"; // this line is modified


                StreamWriter sw = new StreamWriter(conversionFilePath, true);
                sw.Write(conversion);
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ReadDisplayTextFile_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader(conversionFilePath);
                MessageBox.Show(sr.ReadToEnd(), "Money Conversions - Erfan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButtonCAD_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonUSD_CheckedChanged(object sender, EventArgs e)
        {
            //radiobuttonUSD
        }

        private void radioButtonEUR_CheckedChanged(object sender, EventArgs e)
        {
            //radioEUR
        }

        private void radioButtonGBP_CheckedChanged(object sender, EventArgs e)
        {
            //radiobuttonGBP
        }

        private void radioButtonIRN_CheckedChanged(object sender, EventArgs e)
        {
            //radioIRN
        }

        private void textBox_inputValue_TextChanged(object sender, EventArgs e)
        {
            //inputvalue
        }

        private void textBox_CAD_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_EUR_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_IRN_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_USD_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_GBP_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_VND_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            elapsedTime.Stop();
            TimeSpan ts = elapsedTime.Elapsed;

            string elapsedTimeFormatted = String.Format("{0:00} minutes, {1:00} seconds",
            ts.Minutes, ts.Seconds);

            DialogResult dialogResult = MessageBox.Show($"Do you want to quit this app? You have been here for {elapsedTimeFormatted}.",
                                                        "Exit Application",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                elapsedTime.Start();
            }
        }

        private void FrmMoney_Load(object sender, EventArgs e)
        {

        }
    }
}
