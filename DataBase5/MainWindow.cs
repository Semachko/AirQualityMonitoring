
// If you have a database and you have entered the correct data to connect to it in LoginForm.cs
//#define DataBaseExists

using Microsoft.Reporting.WinForms;
using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;



namespace DataBase5
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        private NpgsqlCommand cmd;
        private DataTable dt;

        private void Form2_Load(object sender, System.EventArgs e)
        {
            
            comboBox1.SelectedIndex = -1;
            dataGridView1.DefaultCellStyle.Font = new Font("Calibri", 12);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 14, FontStyle.Bold);
            this.reportStations.RefreshReport();
            this.reportMeasurments.RefreshReport();
            // Online reports using PowerBI:
            webView21.Source = new Uri("https://app.powerbi.com/view?r=eyJrIjoiMzk0YTc3YmItOTEyZC00OTRmLWFhOTktODY0MGQ4Mjc4NDM3IiwidCI6ImQ2NTk5ZjY4LTJkMmMtNGNhZS05ZWNmLTYwMDUyYjdkMGJkOSIsImMiOjl9");
            webView22.Source = new Uri("https://app.powerbi.com/view?r=eyJrIjoiNTE3NWE1ZTMtN2JhYi00MjgwLWI5MzctNWJlM2Q3MWRmZjE5IiwidCI6ImQ2NTk5ZjY4LTJkMmMtNGNhZS05ZWNmLTYwMDUyYjdkMGJkOSIsImMiOjl9");
            webView23.Source = new Uri("https://app.powerbi.com/view?r=eyJrIjoiY2UxMjc4ZjMtZDljZS00YjhkLThmNTMtMGU5MzJiZTlmYjNlIiwidCI6ImQ2NTk5ZjY4LTJkMmMtNGNhZS05ZWNmLTYwMDUyYjdkMGJkOSIsImMiOjl9");

#if DataBaseExists

            //In case if user is logged in as a guest/employee filling comboBox (StationsBox) with different options

            if (LoginForm.login == "guest")
                tabControl1.TabPages[0].Enabled = false;
            else
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(LoginForm.connectionString))
                {
                    connection.Open();

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("select name_ from Station", connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        StationsBox.DataSource = dt;
                        StationsBox.DisplayMember = "name_";
                    }
                }
            }
#endif
        }

        //Depending on the selected item, filling the table with data
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
      #if DataBaseExists
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    LoadDataGridView("select* from ShowStations");
                    dataGridView1.Columns[0].Width = 250;
                    break;
                case 1:
                    LoadDataGridView("select* from ShowMeasurments");
                    dataGridView1.Columns[0].Width = 210;
                    dataGridView1.Columns[1].Width = 130;
                    dataGridView1.Columns[2].Width = 160;
                    break;
                case 2:
                    LoadDataGridView("select* from ShowOptimalValues");
                    dataGridView1.Columns[0].Width = 140;
                    dataGridView1.Columns[4].Width = 130;
                    break;
            }
      #endif 
        }
        private void LoadDataGridView(string sql)
        {
            //Filling the table using the specified SQL query
            using (conn = new NpgsqlConnection(LoginForm.connectionString))
            {
                try
                {
                    conn.Open();
                    cmd = new NpgsqlCommand(sql, conn);
                    dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    conn.Close();
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Помилка відображення уявлення: " + ex.Message);
                }
            }
        }

        //Measurment info on specific date
        private void Report2Button_Click(object sender, EventArgs e) 
        {
            try {
                using (conn = new NpgsqlConnection(LoginForm.connectionString)) {
                    conn.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT Title, max(maxi) as maxi,  min(mini) as mini, round(avg(avgi)::numeric, 5) as avgi FROM ReportMeasurments WHERE name_ = @stationName AND Time_ BETWEEN @startDate AND @endDate group by Title", conn))
                    {
                        command.Parameters.AddWithValue("@stationName", StationsBox.Text);
                        command.Parameters.AddWithValue("@startDate", dateStart.Value);
                        command.Parameters.AddWithValue("@endDate", dateEnd.Value);

                        FillReportView(command, reportMeasurments, "DataSet", "../../ReportMeasurments.rdlc");
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        // Station info report
        private void StationsButton_Click(object sender, EventArgs e) 
        {
            try {
                using (conn = new NpgsqlConnection(LoginForm.connectionString)) {
                    conn.Open(); 
                    using (NpgsqlCommand command = new NpgsqlCommand("select * from ReportStations", conn)) {
                        FillReportView(command, reportStations, "DataSet1", "../../ReportStations.rdlc");
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //Filling the specified <report> with the <reportPath> template using the sql <command> request and data from the <reportDataSource>
        private void FillReportView(NpgsqlCommand command, ReportViewer report, string reportDataSource, string reportPath)
        {
            using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                report.LocalReport.DataSources.Clear();
                ReportDataSource source = new ReportDataSource(reportDataSource, dt);
                report.LocalReport.ReportPath = reportPath;
                report.LocalReport.DataSources.Add(source);

                report.RefreshReport();
            }
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
