using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_section1
{
    //Name:Ali Bahiraei
    //Date:11/07/2023
    //description:used regex for validate ip address and date & use ismatch method it's continue for validating.
    public partial class IPvalidatoralibh : Form
    {
        FileStream mhb = null;
        public IPvalidatoralibh()
        {
            InitializeComponent();
        }
        string dir = @".\Files\";
        string pathBin = @".\Files\IPv4IPv6Bin.txt";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ValidateIP_Click(object sender, EventArgs e)
        {
            string ipAddress = v4address.Text;
            string ipAddress2 = v6address.Text;


            // Regular expression pattern for IP address validation
            string pattern = @"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";

            // Validate the IP address using regular expression
            bool isValid = Regex.IsMatch(ipAddress, pattern);

            if (isValid)
            {
                //MessageBox.Show("IP address is valid.", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(ipAddress + "\nThe IP is correct.", "Valid IP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    FileStream fs = new FileStream(pathBin, FileMode.Append, FileAccess.Write);
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write(ipAddress);
                    bw.Write(DateTime.Now.ToString("yyyy/MM/dd H;mm;ss tt"));
                    bw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Error");
                }
                finally { if (mhb != null) mhb.Close(); }
            }
            else
            {
                MessageBox.Show("Invalid IP address.", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bool isValid2 = Regex.IsMatch(ipAddress2, pattern);

            if (isValid2)
            {
                MessageBox.Show("IP address is valid.", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid IP address.", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }     
        /*private string ValidateIPAddress(string ipAddress)
        {
            IPAddress ip;
            bool isValid = IPAddress.TryParse(ipAddress, out ip);

            if (isValid)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return "Valid IPv4 address!";
                }
                else if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6)
                {
                    return "Valid IPv6 address!";
                }
                else
                {
                    return "Invalid IP address!";
                }
            }
            else
            {
                return "Invalid IP address!";
            }
        }*/

        private void Reset_Click(object sender, EventArgs e)
        {
            v4address.Clear();
            v6address.Clear();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                this.Close();
        }

        private void IPvalidatoralibh_Load(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString("MMMM dd yyyy");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*string inputData = v4address.Text;
            string inputData2 = v6address.Text;
            string inputData3 = lbldate.Text;
            if (IsValidData(inputData))
            {
                // Display the data in the output control (Label or TextBox)

                MessageBox.Show(inputData + "\n" + inputData2 + "\n" +"\n"+inputData3);

            }
            else
            {
                MessageBox.Show("Invalid data.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            // if (isValid || isValid2)
            {
                //string filePath = "YourFilePath.txt";



                try
                {
                    using (FileStream fileStream = new FileStream(pathBin, FileMode.Open, FileAccess.Read))
                    {
                        using (BinaryReader bR = new BinaryReader(fileStream))
                        {
                            string textToPrint = "";
                            while (bR.PeekChar() != -1)
                            {
                                string IPContent = bR.ReadString();
                                //string IPDate = bR.ReadString();
                                textToPrint += IPContent + "\n";// IPDate + "\n";



                            }
                            MessageBox.Show(textToPrint);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while reading the file: {ex.Message}", "Error");
                }
            }
            //else
            //{
            //    MessageBox.Show("Ip addresses are not validateed yet.", "Validation Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

        }
        private bool IsValidData(string data)
        {
            string ipAddress = v4address.Text;
            string ipAddress2 = v6address.Text;


            // Regular expression pattern for IP address validation
            string pattern = @"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";

            // Validate the IP address using regular expression
            bool isValid = Regex.IsMatch(ipAddress, pattern);
            bool isValid2 = Regex.IsMatch(ipAddress2, pattern);

            return !string.IsNullOrEmpty(data);
        }
    }
}
