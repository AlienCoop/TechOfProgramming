
namespace Zubkova2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DispersionLabel = new System.Windows.Forms.Label();
            this.MeanLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MassiveOne = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MassiveTwo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MassiveThree = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LastMassive = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.MassiveFour = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DispersionLabel);
            this.groupBox2.Controls.Add(this.MeanLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(10, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 140);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Среднее значение и дисперсия";
            // 
            // DispersionLabel
            // 
            this.DispersionLabel.AutoSize = true;
            this.DispersionLabel.Location = new System.Drawing.Point(105, 66);
            this.DispersionLabel.Name = "DispersionLabel";
            this.DispersionLabel.Size = new System.Drawing.Size(0, 13);
            this.DispersionLabel.TabIndex = 12;
            // 
            // MeanLabel
            // 
            this.MeanLabel.AutoSize = true;
            this.MeanLabel.Location = new System.Drawing.Point(105, 38);
            this.MeanLabel.Name = "MeanLabel";
            this.MeanLabel.Size = new System.Drawing.Size(0, 13);
            this.MeanLabel.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Дисперсия:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Среднее значение:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MassiveFour);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.MassiveOne);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MassiveTwo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MassiveThree);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 251);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Первичные массивы";
            // 
            // MassiveOne
            // 
            this.MassiveOne.Location = new System.Drawing.Point(5, 30);
            this.MassiveOne.Name = "MassiveOne";
            this.MassiveOne.Size = new System.Drawing.Size(195, 38);
            this.MassiveOne.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Третий массив";
            // 
            // MassiveTwo
            // 
            this.MassiveTwo.Location = new System.Drawing.Point(5, 81);
            this.MassiveTwo.Name = "MassiveTwo";
            this.MassiveTwo.Size = new System.Drawing.Size(195, 38);
            this.MassiveTwo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Второй массив";
            // 
            // MassiveThree
            // 
            this.MassiveThree.Location = new System.Drawing.Point(5, 133);
            this.MassiveThree.Name = "MassiveThree";
            this.MassiveThree.Size = new System.Drawing.Size(195, 38);
            this.MassiveThree.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Первый массив";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 20);
            this.button1.TabIndex = 22;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LastMassive);
            this.groupBox3.Location = new System.Drawing.Point(10, 442);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 94);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Конечный массив";
            // 
            // LastMassive
            // 
            this.LastMassive.Location = new System.Drawing.Point(5, 20);
            this.LastMassive.Name = "LastMassive";
            this.LastMassive.Size = new System.Drawing.Size(280, 69);
            this.LastMassive.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(303, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Конечный массив";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(475, 557);
            this.chart1.TabIndex = 46;
            this.chart1.Text = "chart1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Четвертый массив";
            // 
            // MassiveFour
            // 
            this.MassiveFour.Location = new System.Drawing.Point(6, 184);
            this.MassiveFour.Name = "MassiveFour";
            this.MassiveFour.Size = new System.Drawing.Size(195, 38);
            this.MassiveFour.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 612);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Лабораторная №2";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label MeanLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label MassiveOne;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MassiveTwo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MassiveThree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label DispersionLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LastMassive;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label MassiveFour;
    }
}

