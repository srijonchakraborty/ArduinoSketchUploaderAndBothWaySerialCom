namespace TestApp
{
    partial class Form1
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
            this.burnCodeOne = new System.Windows.Forms.Button();
            this.cmbxPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comBxArduino = new System.Windows.Forms.ComboBox();
            this.richTextBoxData = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.btnPickFile = new System.Windows.Forms.Button();
            this.btnClearPath = new System.Windows.Forms.Button();
            this.btnConnectToRead = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.btnSendDataToArduino = new System.Windows.Forms.Button();
            this.txtBoxSendData = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // burnCodeOne
            // 
            this.burnCodeOne.Location = new System.Drawing.Point(87, 78);
            this.burnCodeOne.Name = "burnCodeOne";
            this.burnCodeOne.Size = new System.Drawing.Size(113, 31);
            this.burnCodeOne.TabIndex = 0;
            this.burnCodeOne.Text = "Burn Code";
            this.burnCodeOne.UseVisualStyleBackColor = true;
            this.burnCodeOne.Click += new System.EventHandler(this.burnCodeOne_Click);
            // 
            // cmbxPort
            // 
            this.cmbxPort.FormattingEnabled = true;
            this.cmbxPort.Location = new System.Drawing.Point(87, 45);
            this.cmbxPort.Name = "cmbxPort";
            this.cmbxPort.Size = new System.Drawing.Size(113, 21);
            this.cmbxPort.TabIndex = 2;
            this.cmbxPort.SelectedIndexChanged += new System.EventHandler(this.cmbxPort_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "COM PORT :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ARDUINO :";
            // 
            // comBxArduino
            // 
            this.comBxArduino.FormattingEnabled = true;
            this.comBxArduino.Location = new System.Drawing.Point(274, 45);
            this.comBxArduino.Name = "comBxArduino";
            this.comBxArduino.Size = new System.Drawing.Size(179, 21);
            this.comBxArduino.TabIndex = 4;
            this.comBxArduino.SelectedIndexChanged += new System.EventHandler(this.comBxArduino_SelectedIndexChanged);
            // 
            // richTextBoxData
            // 
            this.richTextBoxData.Location = new System.Drawing.Point(87, 115);
            this.richTextBoxData.Name = "richTextBoxData";
            this.richTextBoxData.Size = new System.Drawing.Size(622, 113);
            this.richTextBoxData.TabIndex = 6;
            this.richTextBoxData.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "RESPONSE :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "FILE PATH :";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(87, 18);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.ReadOnly = true;
            this.textBoxFilePath.Size = new System.Drawing.Size(555, 20);
            this.textBoxFilePath.TabIndex = 9;
            // 
            // btnPickFile
            // 
            this.btnPickFile.Location = new System.Drawing.Point(643, 14);
            this.btnPickFile.Name = "btnPickFile";
            this.btnPickFile.Size = new System.Drawing.Size(33, 27);
            this.btnPickFile.TabIndex = 10;
            this.btnPickFile.Text = "...";
            this.btnPickFile.UseVisualStyleBackColor = true;
            this.btnPickFile.Click += new System.EventHandler(this.btnPickFile_Click);
            // 
            // btnClearPath
            // 
            this.btnClearPath.Location = new System.Drawing.Point(676, 14);
            this.btnClearPath.Name = "btnClearPath";
            this.btnClearPath.Size = new System.Drawing.Size(33, 27);
            this.btnClearPath.TabIndex = 11;
            this.btnClearPath.Text = "X";
            this.btnClearPath.UseVisualStyleBackColor = true;
            this.btnClearPath.Click += new System.EventHandler(this.btnClearPath_Click);
            // 
            // btnConnectToRead
            // 
            this.btnConnectToRead.Location = new System.Drawing.Point(87, 234);
            this.btnConnectToRead.Name = "btnConnectToRead";
            this.btnConnectToRead.Size = new System.Drawing.Size(113, 31);
            this.btnConnectToRead.TabIndex = 12;
            this.btnConnectToRead.Text = "Connect To Read";
            this.btnConnectToRead.UseVisualStyleBackColor = true;
            this.btnConnectToRead.Click += new System.EventHandler(this.btnConnectToRead_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(208, 234);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(113, 31);
            this.btnDisconnect.TabIndex = 13;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Baud Rate:";
            // 
            // comBoxBaudRate
            // 
            this.comBoxBaudRate.FormattingEnabled = true;
            this.comBoxBaudRate.Location = new System.Drawing.Point(528, 45);
            this.comBoxBaudRate.Name = "comBoxBaudRate";
            this.comBoxBaudRate.Size = new System.Drawing.Size(181, 21);
            this.comBoxBaudRate.TabIndex = 14;
            this.comBoxBaudRate.SelectedIndexChanged += new System.EventHandler(this.comBoxBaudRate_SelectedIndexChanged);
            // 
            // btnSendDataToArduino
            // 
            this.btnSendDataToArduino.Location = new System.Drawing.Point(580, 234);
            this.btnSendDataToArduino.Name = "btnSendDataToArduino";
            this.btnSendDataToArduino.Size = new System.Drawing.Size(127, 31);
            this.btnSendDataToArduino.TabIndex = 16;
            this.btnSendDataToArduino.Text = "Send Data to Arduino";
            this.btnSendDataToArduino.UseVisualStyleBackColor = true;
            this.btnSendDataToArduino.Click += new System.EventHandler(this.btnSendDataToArduino_Click);
            // 
            // txtBoxSendData
            // 
            this.txtBoxSendData.Location = new System.Drawing.Point(451, 235);
            this.txtBoxSendData.Multiline = true;
            this.txtBoxSendData.Name = "txtBoxSendData";
            this.txtBoxSendData.Size = new System.Drawing.Size(123, 30);
            this.txtBoxSendData.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "SEND DATA :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 276);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxSendData);
            this.Controls.Add(this.btnSendDataToArduino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comBoxBaudRate);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnectToRead);
            this.Controls.Add(this.btnClearPath);
            this.Controls.Add(this.btnPickFile);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBoxData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comBxArduino);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbxPort);
            this.Controls.Add(this.burnCodeOne);
            this.Name = "Form1";
            this.Text = "Arduino Code Uploader and Response Tester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button burnCodeOne;
        private System.Windows.Forms.ComboBox cmbxPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comBxArduino;
        private System.Windows.Forms.RichTextBox richTextBoxData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button btnPickFile;
        private System.Windows.Forms.Button btnClearPath;
        private System.Windows.Forms.Button btnConnectToRead;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comBoxBaudRate;
        private System.Windows.Forms.Button btnSendDataToArduino;
        private System.Windows.Forms.TextBox txtBoxSendData;
        private System.Windows.Forms.Label label6;
    }
}

