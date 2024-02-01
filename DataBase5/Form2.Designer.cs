namespace DataBase5
{
    partial class Form2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportStations = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Report2Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelll = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.StationsBox = new System.Windows.Forms.ComboBox();
            this.reportMeasurments = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.webView22 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.StationsButton = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.webView23 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView22)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView23)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.ItemSize = new System.Drawing.Size(103, 40);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(30, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1284, 737);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1288, 699);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Інформація";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Список станцій",
            "Перелік випробувань",
            "Оптимальні значення параметрів"});
            this.comboBox1.Location = new System.Drawing.Point(23, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(396, 37);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1235, 592);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.StationsButton);
            this.tabPage2.Controls.Add(this.reportStations);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1276, 689);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Станції";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportStations
            // 
            this.reportStations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportStations.Location = new System.Drawing.Point(3, 3);
            this.reportStations.Name = "reportStations";
            this.reportStations.ServerReport.BearerToken = null;
            this.reportStations.Size = new System.Drawing.Size(1270, 683);
            this.reportStations.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.webView21);
            this.tabPage4.Location = new System.Drawing.Point(4, 44);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1276, 689);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Станції PowerBI";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.Location = new System.Drawing.Point(0, 0);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1276, 689);
            this.webView21.TabIndex = 3;
            this.webView21.ZoomFactor = 1D;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Report2Button);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.labelll);
            this.tabPage3.Controls.Add(this.dateStart);
            this.tabPage3.Controls.Add(this.dateEnd);
            this.tabPage3.Controls.Add(this.StationsBox);
            this.tabPage3.Controls.Add(this.reportMeasurments);
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1276, 689);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Вимірювання";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Report2Button
            // 
            this.Report2Button.Font = new System.Drawing.Font("Calibri", 20F);
            this.Report2Button.Location = new System.Drawing.Point(1012, 40);
            this.Report2Button.Name = "Report2Button";
            this.Report2Button.Size = new System.Drawing.Size(188, 50);
            this.Report2Button.TabIndex = 6;
            this.Report2Button.Text = "Зформувати";
            this.Report2Button.UseVisualStyleBackColor = true;
            this.Report2Button.Click += new System.EventHandler(this.Report2Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Початок та кінець вимірювань";
            // 
            // labelll
            // 
            this.labelll.AutoSize = true;
            this.labelll.Location = new System.Drawing.Point(161, 11);
            this.labelll.Name = "labelll";
            this.labelll.Size = new System.Drawing.Size(90, 29);
            this.labelll.TabIndex = 4;
            this.labelll.Text = "Станція";
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(490, 53);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 37);
            this.dateStart.TabIndex = 3;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(709, 53);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 37);
            this.dateEnd.TabIndex = 2;
            // 
            // StationsBox
            // 
            this.StationsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StationsBox.FormattingEnabled = true;
            this.StationsBox.Location = new System.Drawing.Point(62, 53);
            this.StationsBox.Name = "StationsBox";
            this.StationsBox.Size = new System.Drawing.Size(305, 37);
            this.StationsBox.TabIndex = 1;
            // 
            // reportMeasurments
            // 
            this.reportMeasurments.Location = new System.Drawing.Point(0, 111);
            this.reportMeasurments.Name = "reportMeasurments";
            this.reportMeasurments.ServerReport.BearerToken = null;
            this.reportMeasurments.Size = new System.Drawing.Size(1288, 582);
            this.reportMeasurments.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.webView22);
            this.tabPage5.Location = new System.Drawing.Point(4, 44);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1276, 689);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Вимірювання PowerBI";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // webView22
            // 
            this.webView22.AllowExternalDrop = true;
            this.webView22.CreationProperties = null;
            this.webView22.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView22.Location = new System.Drawing.Point(0, 0);
            this.webView22.Name = "webView22";
            this.webView22.Size = new System.Drawing.Size(1276, 689);
            this.webView22.TabIndex = 0;
            this.webView22.ZoomFactor = 1D;
            // 
            // StationsButton
            // 
            this.StationsButton.Font = new System.Drawing.Font("Calibri", 20F);
            this.StationsButton.Location = new System.Drawing.Point(1068, 621);
            this.StationsButton.Name = "StationsButton";
            this.StationsButton.Size = new System.Drawing.Size(188, 50);
            this.StationsButton.TabIndex = 7;
            this.StationsButton.Text = "Зформувати";
            this.StationsButton.UseVisualStyleBackColor = true;
            this.StationsButton.Click += new System.EventHandler(this.StationsButton_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.webView23);
            this.tabPage6.Location = new System.Drawing.Point(4, 44);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1276, 689);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Візуалізація";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // webView23
            // 
            this.webView23.AllowExternalDrop = true;
            this.webView23.CreationProperties = null;
            this.webView23.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView23.Location = new System.Drawing.Point(0, 0);
            this.webView23.Name = "webView23";
            this.webView23.Size = new System.Drawing.Size(1276, 689);
            this.webView23.TabIndex = 1;
            this.webView23.ZoomFactor = 1D;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1284, 737);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Моніторинг повітря (Вакуленко)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView22)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView23)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer reportStations;
        private Microsoft.Reporting.WinForms.ReportViewer reportMeasurments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelll;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.ComboBox StationsBox;
        private System.Windows.Forms.Button Report2Button;
        private System.Windows.Forms.TabPage tabPage4;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.TabPage tabPage5;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView22;
        private System.Windows.Forms.Button StationsButton;
        private System.Windows.Forms.TabPage tabPage6;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView23;
    }
}