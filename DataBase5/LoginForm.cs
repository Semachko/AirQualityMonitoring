using Npgsql;
using System;
using System.Windows.Forms;

namespace DataBase5
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public static string connectionString;
        public static string login;
        public static string pass;

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            login = loginText.Text;
            pass = passText.Text;
            connectionString = $"Host=localhost;Port=5432;Username={loginText.Text};Password={passText.Text};Database=Host;";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    //connection.Open();
                    MainWindow form2 = new MainWindow();
                    form2.Show();
                    Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка підключення до бази данних: " + ex.Message);
                }
            }
        }
    }
}
