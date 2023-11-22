namespace Project_Final
{
    partial class FrmTemp
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
            this.radioButton_CF = new System.Windows.Forms.RadioButton();
            this.radioButton_FC = new System.Windows.Forms.RadioButton();
            this.textBox_C = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.btn_cnvr = new System.Windows.Forms.Button();
            this.btn_ReadFile = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.Label_C = new System.Windows.Forms.Label();
            this.Label_F = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButton_CF
            // 
            this.radioButton_CF.AutoSize = true;
            this.radioButton_CF.Location = new System.Drawing.Point(130, 11);
            this.radioButton_CF.Name = "radioButton_CF";
            this.radioButton_CF.Size = new System.Drawing.Size(85, 19);
            this.radioButton_CF.TabIndex = 0;
            this.radioButton_CF.TabStop = true;
            this.radioButton_CF.Text = "from F to C";
            this.radioButton_CF.UseVisualStyleBackColor = true;
            this.radioButton_CF.CheckedChanged += new System.EventHandler(this.radioButton_CF_CheckedChanged);
            // 
            // radioButton_FC
            // 
            this.radioButton_FC.AutoSize = true;
            this.radioButton_FC.Location = new System.Drawing.Point(130, 49);
            this.radioButton_FC.Name = "radioButton_FC";
            this.radioButton_FC.Size = new System.Drawing.Size(85, 19);
            this.radioButton_FC.TabIndex = 1;
            this.radioButton_FC.TabStop = true;
            this.radioButton_FC.Text = "from C to F";
            this.radioButton_FC.UseVisualStyleBackColor = true;
            this.radioButton_FC.CheckedChanged += new System.EventHandler(this.radioButton_FC_CheckedChanged);
            // 
            // textBox_C
            // 
            this.textBox_C.Location = new System.Drawing.Point(32, 98);
            this.textBox_C.Name = "textBox_C";
            this.textBox_C.Size = new System.Drawing.Size(116, 23);
            this.textBox_C.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "to\r\n\r\n";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(193, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(116, 23);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Message :";
            // 
            // textBox_message
            // 
            this.textBox_message.Location = new System.Drawing.Point(13, 226);
            this.textBox_message.Multiline = true;
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.ReadOnly = true;
            this.textBox_message.Size = new System.Drawing.Size(344, 38);
            this.textBox_message.TabIndex = 6;
            // 
            // btn_cnvr
            // 
            this.btn_cnvr.Location = new System.Drawing.Point(10, 284);
            this.btn_cnvr.Name = "btn_cnvr";
            this.btn_cnvr.Size = new System.Drawing.Size(97, 22);
            this.btn_cnvr.TabIndex = 7;
            this.btn_cnvr.Text = "&Convert";
            this.btn_cnvr.UseVisualStyleBackColor = true;
            this.btn_cnvr.Click += new System.EventHandler(this.btn_cnvr_Click);
            // 
            // btn_ReadFile
            // 
            this.btn_ReadFile.Location = new System.Drawing.Point(130, 284);
            this.btn_ReadFile.Name = "btn_ReadFile";
            this.btn_ReadFile.Size = new System.Drawing.Size(97, 22);
            this.btn_ReadFile.TabIndex = 8;
            this.btn_ReadFile.Text = "&Read File";
            this.btn_ReadFile.UseVisualStyleBackColor = true;
            this.btn_ReadFile.Click += new System.EventHandler(this.btn_ReadFile_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(247, 284);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(97, 22);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "E&xit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Label_C
            // 
            this.Label_C.AutoSize = true;
            this.Label_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_C.Location = new System.Drawing.Point(70, 132);
            this.Label_C.Name = "Label_C";
            this.Label_C.Size = new System.Drawing.Size(18, 17);
            this.Label_C.TabIndex = 10;
            this.Label_C.Text = "C";
            // 
            // Label_F
            // 
            this.Label_F.AutoSize = true;
            this.Label_F.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_F.Location = new System.Drawing.Point(244, 132);
            this.Label_F.Name = "Label_F";
            this.Label_F.Size = new System.Drawing.Size(17, 17);
            this.Label_F.TabIndex = 11;
            this.Label_F.Text = "F";
            // 
            // FrmTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 316);
            this.Controls.Add(this.Label_F);
            this.Controls.Add(this.Label_C);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_ReadFile);
            this.Controls.Add(this.btn_cnvr);
            this.Controls.Add(this.textBox_message);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_C);
            this.Controls.Add(this.radioButton_FC);
            this.Controls.Add(this.radioButton_CF);
            this.Name = "FrmTemp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temp App - Ali Bahiraei";
            this.Load += new System.EventHandler(this.FrmTemp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_CF;
        private System.Windows.Forms.RadioButton radioButton_FC;
        private System.Windows.Forms.TextBox textBox_C;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_message;
        private System.Windows.Forms.Button btn_cnvr;
        private System.Windows.Forms.Button btn_ReadFile;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label Label_C;
        private System.Windows.Forms.Label Label_F;
    }
}