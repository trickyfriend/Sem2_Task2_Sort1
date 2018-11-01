namespace Sem2_Sort1
{
    partial class ChartsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.changeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.compareChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.changeChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compareChart)).BeginInit();
            this.SuspendLayout();
            // 
            // changeChart
            // 
            chartArea1.Name = "ChartArea1";
            this.changeChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.changeChart.Legends.Add(legend1);
            this.changeChart.Location = new System.Drawing.Point(737, 33);
            this.changeChart.Name = "changeChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "bubble";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "shaker";
            this.changeChart.Series.Add(series1);
            this.changeChart.Series.Add(series2);
            this.changeChart.Size = new System.Drawing.Size(697, 556);
            this.changeChart.TabIndex = 0;
            this.changeChart.Text = "changeChart";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "Changes";
            this.changeChart.Titles.Add(title1);
            // 
            // compareChart
            // 
            chartArea2.Name = "ChartArea1";
            this.compareChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.compareChart.Legends.Add(legend2);
            this.compareChart.Location = new System.Drawing.Point(26, 33);
            this.compareChart.Name = "compareChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "bubble";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "shaker";
            this.compareChart.Series.Add(series3);
            this.compareChart.Series.Add(series4);
            this.compareChart.Size = new System.Drawing.Size(705, 556);
            this.compareChart.TabIndex = 1;
            this.compareChart.Text = "Compare count";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.Name = "Compares";
            title2.Text = "Compares";
            this.compareChart.Titles.Add(title2);
            // 
            // ChartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 615);
            this.Controls.Add(this.compareChart);
            this.Controls.Add(this.changeChart);
            this.Name = "ChartsForm";
            this.Text = "ChartsForm";
            ((System.ComponentModel.ISupportInitialize)(this.changeChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compareChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart changeChart;
        public System.Windows.Forms.DataVisualization.Charting.Chart compareChart;
    }
}