namespace project_section1
{
    partial class IPvalidatoralibh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.v4address = new System.Windows.Forms.TextBox();
            this.v6address = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.ValidateIP = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbldate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Today :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter IP v4 Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter IP v6 Address:";
            // 
            // v4address
            // 
            this.v4address.Location = new System.Drawing.Point(179, 58);
            this.v4address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.v4address.Name = "v4address";
            this.v4address.Size = new System.Drawing.Size(205, 23);
            this.v4address.TabIndex = 3;
            // 
            // v6address
            // 
            this.v6address.Location = new System.Drawing.Point(179, 103);
            this.v6address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.v6address.Name = "v6address";
            this.v6address.Size = new System.Drawing.Size(205, 23);
            this.v6address.TabIndex = 4;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(317, 165);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(82, 22);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ValidateIP
            // 
            this.ValidateIP.Location = new System.Drawing.Point(118, 165);
            this.ValidateIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ValidateIP.Name = "ValidateIP";
            this.ValidateIP.Size = new System.Drawing.Size(99, 22);
            this.ValidateIP.TabIndex = 6;
            this.ValidateIP.Text = "Validate IP";
            this.ValidateIP.UseVisualStyleBackColor = true;
            this.ValidateIP.Click += new System.EventHandler(this.ValidateIP_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(209, 139);
            this.Reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(115, 22);
            this.Reset.TabIndex = 7;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(202, 191);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 22);
            this.button3.TabIndex = 8;
            this.button3.Text = "Read and display";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(268, 41);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(31, 15);
            this.lbldate.TabIndex = 9;
            this.lbldate.Text = "Date";
            // 
            // IPvalidatoralibh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 382);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.ValidateIP);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.v6address);
            this.Controls.Add(this.v4address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IPvalidatoralibh";
            this.Text = "IPvalidatoralibh+AliBahiraei";
            this.Load += new System.EventHandler(this.IPvalidatoralibh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox v4address;
        private TextBox v6address;
        private Button Exit;
        private Button ValidateIP;
        private Button Reset;
        private Button button3;
        private Label lbldate;
    }
}