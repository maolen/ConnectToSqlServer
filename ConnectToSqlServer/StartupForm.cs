using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConnectToSqlServer
{
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
        }

        private void ConnectButtonClick(object sender, EventArgs eventArgs)
        {
            var builder = new SqlConnectionStringBuilder();
            builder["Server"] = "DESKTOP-NVDGPN3";
            builder["Database"] = "MyDB";
            builder["Trusted_Connection"] = true;

            using (var connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                MessageBox.Show("Успешно подключено!");
            }
        }
    }
}
