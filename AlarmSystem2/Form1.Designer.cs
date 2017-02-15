namespace AlarmSystem2
{
    partial class mainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ConDataButt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.chartS3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartS2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartS1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new AlarmSystem2.DataSet1();
            this.dataTableTableAdapter = new AlarmSystem2.DataSet1TableAdapters.DataTableTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartS3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartS2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // ConDataButt
            // 
            this.ConDataButt.Location = new System.Drawing.Point(133, 12);
            this.ConDataButt.Name = "ConDataButt";
            this.ConDataButt.Size = new System.Drawing.Size(223, 74);
            this.ConDataButt.TabIndex = 3;
            this.ConDataButt.Text = "ConnectDatabase";
            this.ConDataButt.UseVisualStyleBackColor = true;
            this.ConDataButt.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.chartS3);
            this.groupBox1.Controls.Add(this.chartS2);
            this.groupBox1.Controls.Add(this.chartS1);
            this.groupBox1.Location = new System.Drawing.Point(11, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1064, 627);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "เสาอุปกรณ์";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(859, 447);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(176, 138);
            this.button5.TabIndex = 8;
            this.button5.Text = "เสา3";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(859, 243);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 138);
            this.button4.TabIndex = 7;
            this.button4.Text = "เสา2";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(859, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 138);
            this.button3.TabIndex = 6;
            this.button3.Text = "เสา1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // chartS3
            // 
            chartArea1.Name = "ChartArea1";
            this.chartS3.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartS3.Legends.Add(legend1);
            this.chartS3.Location = new System.Drawing.Point(0, 430);
            this.chartS3.Name = "chartS3";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series3";
            this.chartS3.Series.Add(series1);
            this.chartS3.Size = new System.Drawing.Size(831, 179);
            this.chartS3.TabIndex = 2;
            this.chartS3.Text = "chart3";
            // 
            // chartS2
            // 
            chartArea2.Name = "ChartArea1";
            this.chartS2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartS2.Legends.Add(legend2);
            this.chartS2.Location = new System.Drawing.Point(6, 224);
            this.chartS2.Name = "chartS2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chartS2.Series.Add(series2);
            this.chartS2.Size = new System.Drawing.Size(831, 179);
            this.chartS2.TabIndex = 1;
            this.chartS2.Text = "chart2";
            // 
            // chartS1
            // 
            chartArea3.Name = "ChartArea1";
            this.chartS1.ChartAreas.Add(chartArea3);
            this.chartS1.DataSource = this.dataTableBindingSource;
            legend3.Name = "Legend1";
            this.chartS1.Legends.Add(legend3);
            this.chartS1.Location = new System.Drawing.Point(6, 21);
            this.chartS1.Name = "chartS1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartS1.Series.Add(series3);
            this.chartS1.Size = new System.Drawing.Size(831, 179);
            this.chartS1.TabIndex = 0;
            this.chartS1.Text = "chart1";
            // 
            // dataTableBindingSource
            // 
            this.dataTableBindingSource.DataMember = "DataTable";
            this.dataTableBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableTableAdapter
            // 
            this.dataTableTableAdapter.ClearBeforeFill = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 720);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ConDataButt);
            this.Name = "mainForm";
            this.Text = "AlarmSystem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartS3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartS2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ConDataButt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartS3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartS2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartS1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private DataSet1TableAdapters.DataTableTableAdapter dataTableTableAdapter;
        private System.Windows.Forms.Timer timer1;
    }
}

