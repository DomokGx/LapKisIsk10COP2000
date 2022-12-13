using LapKisIsk10COP2000.Properties;
using Microsoft.Data.SqlClient;

namespace LapKisIsk10COP2000
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            using SqlConnection conn = new(Resources.ConnectionString);
            conn.Open();

            string sql = 
               "SELECT nev, sum(osszeg) FROM naplo, bank " +
               "WHERE sorszam = ki and sorszam != 0 and osszeg > 0 " +
               "GROUP BY nev;";

            var reader = new SqlCommand(sql, conn).ExecuteReader();

            while (reader.Read())
            {
                dgvOsszesito.Rows.Add(
                    reader[0],
                    $"{reader[1]} Ft");
            }

            reader.Close();

            sql =
               "SELECT sum(osszeg) FROM bank " +
               "WHERE leiras = 'fenymasolas';";

            reader = new SqlCommand(sql, conn).ExecuteReader();

            reader.Read();
            tbFenymasolasraOsszesen.Text = $"{reader[0]} Ft";

            reader.Close();

            sql = 
                "SELECT nev FROM naplo " +
                "WHERE sorszam != 0";

            reader = new SqlCommand(sql, conn).ExecuteReader();

            while (reader.Read())
            {
                cbDiakok.Items.Add(
                    reader[0]);
            }

            reader.Close();

            sql = "SELECT nev, sorszam FROM naplo;";

            reader = new SqlCommand(sql, conn).ExecuteReader();

            while (reader.Read())
            {
                Program.nevekSorszama.Add(reader.GetString(0), reader.GetInt32(1));
            }
        }

        private void CbDiakok_SelectedIndexChanged(object sender, EventArgs e)
        {
            using SqlConnection conn = new(Resources.ConnectionString);
            conn.Open();

            rtdDiakTranzakcioi.Clear();
            int ki = Program.nevekSorszama[cbDiakok.Text];
            string sql =
               "SELECT mikor, leiras, osszeg FROM bank " +
               $"WHERE ki = {ki};";

            var reader = new SqlCommand(sql, conn).ExecuteReader();

            while (reader.Read())
            {
                rtdDiakTranzakcioi.AppendText($"{reader[0]} {reader[1]} {reader[2]} Ft\n");
            }
        }

        private void MenuUjTetel_Click(object sender, EventArgs e)
        {
            _ = new FrmUjTetel(cbDiakok).ShowDialog();
            Application.Restart();
        }

        private void MenuSzamlaKimut_Click(object sender, EventArgs e)
        {
            _ = new FrmSzamlaKimut().ShowDialog();
        }
    }
}