namespace BubbleSortExercise
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BubbleSortButton = new System.Windows.Forms.Button();
            this.ShowList = new System.Windows.Forms.Button();
            this.Graphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.NumberChoosed = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Graphic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberChoosed)).BeginInit();
            this.SuspendLayout();
            // 
            // BubbleSortButton
            // 
            this.BubbleSortButton.Location = new System.Drawing.Point(15, 285);
            this.BubbleSortButton.Name = "BubbleSortButton";
            this.BubbleSortButton.Size = new System.Drawing.Size(196, 55);
            this.BubbleSortButton.TabIndex = 0;
            this.BubbleSortButton.Text = "BubbleSort";
            this.BubbleSortButton.UseVisualStyleBackColor = true;
            this.BubbleSortButton.Click += new System.EventHandler(this.DoBubbleSort);
            // 
            // ShowList
            // 
            this.ShowList.Location = new System.Drawing.Point(518, 285);
            this.ShowList.Name = "ShowList";
            this.ShowList.Size = new System.Drawing.Size(196, 55);
            this.ShowList.TabIndex = 2;
            this.ShowList.Text = "ShowList";
            this.ShowList.UseVisualStyleBackColor = true;
            this.ShowList.Click += new System.EventHandler(this.ShowAllList);
            // 
            // Graphic
            // 
            chartArea1.Name = "ChartArea1";
            this.Graphic.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Graphic.Legends.Add(legend1);
            this.Graphic.Location = new System.Drawing.Point(2, 9);
            this.Graphic.Name = "Graphic";
            this.Graphic.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.Graphic.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black};
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Graphic.Series.Add(series1);
            this.Graphic.Size = new System.Drawing.Size(699, 270);
            this.Graphic.TabIndex = 3;
            this.Graphic.Text = "chart1";
            // 
            // NumberChoosed
            // 
            this.NumberChoosed.Location = new System.Drawing.Point(305, 304);
            this.NumberChoosed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumberChoosed.Name = "NumberChoosed";
            this.NumberChoosed.Size = new System.Drawing.Size(120, 20);
            this.NumberChoosed.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 352);
            this.Controls.Add(this.NumberChoosed);
            this.Controls.Add(this.Graphic);
            this.Controls.Add(this.ShowList);
            this.Controls.Add(this.BubbleSortButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Graphic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberChoosed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BubbleSortButton;
        private System.Windows.Forms.Button ShowList;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graphic;
        private System.Windows.Forms.NumericUpDown NumberChoosed;
    }
}

