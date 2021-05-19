namespace DangNhap
{
     partial class TK_GiaoVien
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

          #region Component Designer generated code

          /// <summary> 
          /// Required method for Designer support - do not modify 
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartGV_Tron = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartGV_Cot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGV_Tron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGV_Cot)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Môn học",
            "Trình độ",
            "Khối học"});
            this.comboBox1.Location = new System.Drawing.Point(276, 12);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(387, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(118, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thống kê theo: ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chartGV_Cot);
            this.panel1.Controls.Add(this.chartGV_Tron);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 539);
            this.panel1.TabIndex = 4;
            // 
            // chartGV_Tron
            // 
            this.chartGV_Tron.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chartGV_Tron.BackColor = System.Drawing.Color.Silver;
            this.chartGV_Tron.BorderlineColor = System.Drawing.Color.Silver;
            chartArea8.Name = "ChartArea1";
            this.chartGV_Tron.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartGV_Tron.Legends.Add(legend8);
            this.chartGV_Tron.Location = new System.Drawing.Point(590, 138);
            this.chartGV_Tron.Name = "chartGV_Tron";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series8.Legend = "Legend1";
            series8.Name = "Số lượng GV";
            this.chartGV_Tron.Series.Add(series8);
            this.chartGV_Tron.Size = new System.Drawing.Size(328, 309);
            this.chartGV_Tron.TabIndex = 1;
            this.chartGV_Tron.Text = "chart2";
            this.chartGV_Tron.Click += new System.EventHandler(this.chartGV_Tron_Click);
            // 
            // chartGV_Cot
            // 
            this.chartGV_Cot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chartGV_Cot.BackColor = System.Drawing.Color.Silver;
            this.chartGV_Cot.BorderlineColor = System.Drawing.Color.Silver;
            chartArea7.Name = "ChartArea1";
            this.chartGV_Cot.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartGV_Cot.Legends.Add(legend7);
            this.chartGV_Cot.Location = new System.Drawing.Point(165, 138);
            this.chartGV_Cot.Name = "chartGV_Cot";
            this.chartGV_Cot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Số lượng GV";
            this.chartGV_Cot.Series.Add(series7);
            this.chartGV_Cot.Size = new System.Drawing.Size(363, 309);
            this.chartGV_Cot.TabIndex = 0;
            this.chartGV_Cot.Text = "Thống kê số lượng GV";
            title4.Name = "Thống kê số lượng giáo viên";
            this.chartGV_Cot.Titles.Add(title4);
            // 
            // TK_GiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TK_GiaoVien";
            this.Size = new System.Drawing.Size(1090, 539);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGV_Tron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGV_Cot)).EndInit();
            this.ResumeLayout(false);

          }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGV_Cot;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGV_Tron;
    }
}
