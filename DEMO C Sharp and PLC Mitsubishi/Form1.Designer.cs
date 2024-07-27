
namespace DEMO_C_Sharp_and_PLC_Mitsubishi
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tbSpeedInverter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDelayTrigger = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMaterialDiameter = new System.Windows.Forms.TextBox();
            this.tbP1P2Distance = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbcntfortrigger = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbTactTime = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbSpeedInverter = new System.Windows.Forms.Label();
            this.lbDelayTrigger = new System.Windows.Forms.Label();
            this.lbMaterialDiaMeter = new System.Windows.Forms.Label();
            this.lbP1P2Distance = new System.Windows.Forms.Label();
            this.lbCountingForTrigger = new System.Windows.Forms.Label();
            this.lbSpeed = new System.Windows.Forms.Label();
            this.lbTactTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(394, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 73);
            this.button2.TabIndex = 1;
            this.button2.Text = "Disconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1346, 115);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 56);
            this.button3.TabIndex = 2;
            this.button3.Text = "Read";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1346, 237);
            this.button4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(182, 54);
            this.button4.TabIndex = 3;
            this.button4.Text = "Write Word";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(776, 129);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(222, 31);
            this.txtAdress.TabIndex = 4;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(776, 248);
            this.txtValue.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtValue.Name = "txtValue";
            this.txtValue.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtValue.Size = new System.Drawing.Size(222, 31);
            this.txtValue.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Giá trị";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1346, 560);
            this.button5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(182, 44);
            this.button5.TabIndex = 8;
            this.button5.Text = "Xung lên";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1346, 640);
            this.button6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(182, 44);
            this.button6.TabIndex = 8;
            this.button6.Text = "Xung xuống";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(696, 38);
            this.button7.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(150, 44);
            this.button7.TabIndex = 9;
            this.button7.Text = "Start Timer";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(936, 38);
            this.button8.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(150, 44);
            this.button8.TabIndex = 9;
            this.button8.Text = "Stop Timer";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "CPU Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "CPU Type:";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1346, 348);
            this.button9.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(232, 54);
            this.button9.TabIndex = 3;
            this.button9.Text = "Write Word (Float)";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1346, 23);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(232, 50);
            this.button10.TabIndex = 11;
            this.button10.Text = "Read Word (Float)";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 283);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 31);
            this.textBox1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 288);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Running";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // tbSpeedInverter
            // 
            this.tbSpeedInverter.Location = new System.Drawing.Point(282, 412);
            this.tbSpeedInverter.Name = "tbSpeedInverter";
            this.tbSpeedInverter.Size = new System.Drawing.Size(168, 31);
            this.tbSpeedInverter.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Speed Inverter";
            this.label6.TextChanged += new System.EventHandler(this.Speed);
            // 
            // tbDelayTrigger
            // 
            this.tbDelayTrigger.Location = new System.Drawing.Point(282, 462);
            this.tbDelayTrigger.Name = "tbDelayTrigger";
            this.tbDelayTrigger.Size = new System.Drawing.Size(168, 31);
            this.tbDelayTrigger.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Delay Trigger";
            this.label7.TextChanged += new System.EventHandler(this.Speed);
            // 
            // tbMaterialDiameter
            // 
            this.tbMaterialDiameter.Location = new System.Drawing.Point(282, 510);
            this.tbMaterialDiameter.Name = "tbMaterialDiameter";
            this.tbMaterialDiameter.Size = new System.Drawing.Size(168, 31);
            this.tbMaterialDiameter.TabIndex = 14;
            // 
            // tbP1P2Distance
            // 
            this.tbP1P2Distance.Location = new System.Drawing.Point(282, 560);
            this.tbP1P2Distance.Name = "tbP1P2Distance";
            this.tbP1P2Distance.Size = new System.Drawing.Size(168, 31);
            this.tbP1P2Distance.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 560);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "P1P2 Distance";
            this.label9.TextChanged += new System.EventHandler(this.Speed);
            // 
            // tbcntfortrigger
            // 
            this.tbcntfortrigger.Location = new System.Drawing.Point(282, 606);
            this.tbcntfortrigger.Name = "tbcntfortrigger";
            this.tbcntfortrigger.Size = new System.Drawing.Size(168, 31);
            this.tbcntfortrigger.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 606);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 25);
            this.label10.TabIndex = 15;
            this.label10.Text = "Counting for trigger";
            this.label10.TextChanged += new System.EventHandler(this.Speed);
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(282, 656);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(168, 31);
            this.tbSpeed.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 656);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 25);
            this.label11.TabIndex = 15;
            this.label11.Text = "Speed";
            this.label11.TextChanged += new System.EventHandler(this.Speed);
            // 
            // tbTactTime
            // 
            this.tbTactTime.Location = new System.Drawing.Point(282, 705);
            this.tbTactTime.Name = "tbTactTime";
            this.tbTactTime.Size = new System.Drawing.Size(168, 31);
            this.tbTactTime.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(59, 705);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 25);
            this.label12.TabIndex = 15;
            this.label12.Text = "Tact Time";
            this.label12.TextChanged += new System.EventHandler(this.Speed);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 510);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Material Diameter";
            this.label8.TextChanged += new System.EventHandler(this.Speed);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(758, 412);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(231, 68);
            this.button11.TabIndex = 16;
            this.button11.Text = "Save Parameter";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lbSpeedInverter
            // 
            this.lbSpeedInverter.AutoSize = true;
            this.lbSpeedInverter.Location = new System.Drawing.Point(494, 412);
            this.lbSpeedInverter.Name = "lbSpeedInverter";
            this.lbSpeedInverter.Size = new System.Drawing.Size(82, 25);
            this.lbSpeedInverter.TabIndex = 17;
            this.lbSpeedInverter.Text = "label13";
            // 
            // lbDelayTrigger
            // 
            this.lbDelayTrigger.AutoSize = true;
            this.lbDelayTrigger.Location = new System.Drawing.Point(494, 468);
            this.lbDelayTrigger.Name = "lbDelayTrigger";
            this.lbDelayTrigger.Size = new System.Drawing.Size(82, 25);
            this.lbDelayTrigger.TabIndex = 17;
            this.lbDelayTrigger.Text = "label13";
            // 
            // lbMaterialDiaMeter
            // 
            this.lbMaterialDiaMeter.AutoSize = true;
            this.lbMaterialDiaMeter.Location = new System.Drawing.Point(494, 513);
            this.lbMaterialDiaMeter.Name = "lbMaterialDiaMeter";
            this.lbMaterialDiaMeter.Size = new System.Drawing.Size(82, 25);
            this.lbMaterialDiaMeter.TabIndex = 17;
            this.lbMaterialDiaMeter.Text = "label13";
            // 
            // lbP1P2Distance
            // 
            this.lbP1P2Distance.AutoSize = true;
            this.lbP1P2Distance.Location = new System.Drawing.Point(494, 560);
            this.lbP1P2Distance.Name = "lbP1P2Distance";
            this.lbP1P2Distance.Size = new System.Drawing.Size(82, 25);
            this.lbP1P2Distance.TabIndex = 17;
            this.lbP1P2Distance.Text = "label13";
            // 
            // lbCountingForTrigger
            // 
            this.lbCountingForTrigger.AutoSize = true;
            this.lbCountingForTrigger.Location = new System.Drawing.Point(494, 606);
            this.lbCountingForTrigger.Name = "lbCountingForTrigger";
            this.lbCountingForTrigger.Size = new System.Drawing.Size(82, 25);
            this.lbCountingForTrigger.TabIndex = 17;
            this.lbCountingForTrigger.Text = "label13";
            // 
            // lbSpeed
            // 
            this.lbSpeed.AutoSize = true;
            this.lbSpeed.Location = new System.Drawing.Point(494, 659);
            this.lbSpeed.Name = "lbSpeed";
            this.lbSpeed.Size = new System.Drawing.Size(82, 25);
            this.lbSpeed.TabIndex = 17;
            this.lbSpeed.Text = "label13";
            // 
            // lbTactTime
            // 
            this.lbTactTime.AutoSize = true;
            this.lbTactTime.Location = new System.Drawing.Point(494, 705);
            this.lbTactTime.Name = "lbTactTime";
            this.lbTactTime.Size = new System.Drawing.Size(82, 25);
            this.lbTactTime.TabIndex = 17;
            this.lbTactTime.Text = "label13";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.lbTactTime);
            this.Controls.Add(this.lbSpeed);
            this.Controls.Add(this.lbCountingForTrigger);
            this.Controls.Add(this.lbP1P2Distance);
            this.Controls.Add(this.lbMaterialDiaMeter);
            this.Controls.Add(this.lbDelayTrigger);
            this.Controls.Add(this.lbSpeedInverter);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbTactTime);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.tbcntfortrigger);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbP1P2Distance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbMaterialDiameter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbDelayTrigger);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbSpeedInverter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tbSpeedInverter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDelayTrigger;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMaterialDiameter;
        private System.Windows.Forms.TextBox tbP1P2Distance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbcntfortrigger;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbSpeed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbTactTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbSpeedInverter;
        private System.Windows.Forms.Label lbDelayTrigger;
        private System.Windows.Forms.Label lbMaterialDiaMeter;
        private System.Windows.Forms.Label lbP1P2Distance;
        private System.Windows.Forms.Label lbCountingForTrigger;
        private System.Windows.Forms.Label lbSpeed;
        private System.Windows.Forms.Label lbTactTime;
    }
}

