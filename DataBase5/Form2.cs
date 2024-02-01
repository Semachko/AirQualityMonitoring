//#define DataBaseExists
using Microsoft.Reporting.WinForms;
using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;



namespace DataBase5
{
    public partial class Form2 : Form
    {
        public Form2()
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
            webView21.Source = new Uri("https://app.powerbi.com/view?r=eyJrIjoiMzk0YTc3YmItOTEyZC00OTRmLWFhOTktODY0MGQ4Mjc4NDM3IiwidCI6ImQ2NTk5ZjY4LTJkMmMtNGNhZS05ZWNmLTYwMDUyYjdkMGJkOSIsImMiOjl9");
            webView22.Source = new Uri("https://app.powerbi.com/view?r=eyJrIjoiNTE3NWE1ZTMtN2JhYi00MjgwLWI5MzctNWJlM2Q3MWRmZjE5IiwidCI6ImQ2NTk5ZjY4LTJkMmMtNGNhZS05ZWNmLTYwMDUyYjdkMGJkOSIsImMiOjl9");
            webView23.Source = new Uri("https://app.powerbi.com/view?r=eyJrIjoiY2UxMjc4ZjMtZDljZS00YjhkLThmNTMtMGU5MzJiZTlmYjNlIiwidCI6ImQ2NTk5ZjY4LTJkMmMtNGNhZS05ZWNmLTYwMDUyYjdkMGJkOSIsImMiOjl9");
         #if DataBaseExists

            if (Form1.login == "guest")
                tabControl1.TabPages[0].Enabled = false;
            else
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(Form1.connectionString))
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
        private void LoadDataGridView(string sql)
        {
            using (conn = new NpgsqlConnection(Form1.connectionString))
            {
                try
                {
                    conn.Open();
                    cmd = new NpgsqlCommand(sql, conn);
                    dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    conn.Close();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Помилка відображення уявлення: " + ex.Message);
                }
            }
        }
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
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Report2Button_Click(object sender, EventArgs e)
        {
            try
            {
                using (conn = new NpgsqlConnection(Form1.connectionString))
                {
                    conn.Open();


                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT Title, max(maxi) as maxi,  min(mini) as mini, round(avg(avgi)::numeric, 5) as avgi FROM ReportMeasurments WHERE name_ = @stationName AND Time_ BETWEEN @startDate AND @endDate group by Title", conn))
                    {
                        command.Parameters.AddWithValue("@stationName", StationsBox.Text);
                        command.Parameters.AddWithValue("@startDate", dateStart.Value);
                        command.Parameters.AddWithValue("@endDate", dateEnd.Value);

                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            reportMeasurments.LocalReport.DataSources.Clear();
                            ReportDataSource source = new ReportDataSource("DataSet", dt);
                            reportMeasurments.LocalReport.ReportPath = "../../ReportMeasurments.rdlc";
                            reportMeasurments.LocalReport.DataSources.Add(source);

                            reportMeasurments.RefreshReport();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void StationsButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (conn = new NpgsqlConnection(Form1.connectionString))
                {
                    conn.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("select * from ReportStations", conn))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            reportStations.LocalReport.DataSources.Clear();
                            ReportDataSource source = new ReportDataSource("DataSet1", dt);
                            reportStations.LocalReport.ReportPath = "../../ReportStations.rdlc";
                            reportStations.LocalReport.DataSources.Add(source);
                            reportStations.RefreshReport();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
