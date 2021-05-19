namespace DangNhap
{
     partial class TK_HocSinh
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartHS_Tron = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartHS_Cot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxLoaiThongKe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHS_Tron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHS_Cot)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.comboBoxLoaiThongKe);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chartHS_Tron);
            this.panel1.Controls.Add(this.chartHS_Cot);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 539);
            this.panel1.TabIndex = 2;
            // 
            // chartHS_Tron
            // 
            this.chartHS_Tron.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chartHS_Tron.BackColor = System.Drawing.Color.Silver;
            chartArea7.Name = "ChartArea1";
            this.chartHS_Tron.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartHS_Tron.Legends.Add(legend7);
            this.chartHS_Tron.Location = new System.Drawing.Point(590, 138);
            this.chartHS_Tron.Name = "chartHS_Tron";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series7.Legend = "Legend1";
            series7.Name = "Số lượng HS";
            this.chartHS_Tron.Series.Add(series7);
            this.chartHS_Tron.Size = new System.Drawing.Size(328, 309);
            this.chartHS_Tron.TabIndex = 1;
            this.chartHS_Tron.Text = "chart2";
            // 
            // chartHS_Cot
            // 
            this.chartHS_Cot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chartHS_Cot.BackColor = System.Drawing.Color.Silver;
            chartArea8.Name = "ChartArea1";
            this.chartHS_Cot.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartHS_Cot.Legends.Add(legend8);
            this.chartHS_Cot.Location = new System.Drawing.Point(165, 138);
            this.chartHS_Cot.Name = "chartHS_Cot";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Số lượng HS";
            this.chartHS_Cot.Series.Add(series8);
            this.chartHS_Cot.Size = new System.Drawing.Size(363, 309);
            this.chartHS_Cot.TabIndex = 0;
            this.chartHS_Cot.Text = "Thống kê số lượng HS";
            title4.Name = "Thống kê số lượng học sinh";
            this.chartHS_Cot.Titles.Add(title4);
            // 
            // comboBoxLoaiThongKe
            // 
            this.comboBoxLoaiThongKe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBoxLoaiThongKe.FormattingEnabled = true;
            this.comboBoxLoaiThongKe.Items.AddRange(new object[] {
            "Khối 10",
            "Khối 11",
            "Khối 12"});
            this.comboBoxLoaiThongKe.Location = new System.Drawing.Point(276, 12);
            this.comboBoxLoaiThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxLoaiThongKe.Name = "comboBoxLoaiThongKe";
            this.comboBoxLoaiThongKe.Size = new System.Drawing.Size(387, 28);
            this.comboBoxLoaiThongKe.TabIndex = 5;
            this.comboBoxLoaiThongKe.SelectedIndexChanged += new System.EventHandler(this.comboBoxLoaiThongKe_SelectedIndexChanged);
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
            this.label1.TabIndex = 4;
            this.label1.Text = "Thống kê theo: ";
            // 
            // TK_HocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TK_HocSinh";
            this.Size = new System.Drawing.Size(1090, 539);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHS_Tron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHS_Cot)).EndInit();
            this.ResumeLayout(false);

          }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHS_Cot;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHS_Tron;
        private System.Windows.Forms.ComboBox comboBoxLoaiThongKe;
        private System.Windows.Forms.Label label1;
    }
}
