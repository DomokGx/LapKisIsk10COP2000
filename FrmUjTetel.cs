using LapKisIsk10COP2000.Properties;
using Microsoft.Data.SqlClient;

namespace LapKisIsk10COP2000
{
    public partial class FrmUjTetel : Form
    {
        public FrmUjTetel(ComboBox combobox)
        {
            InitializeComponent();

            for (int i = 0; i < combobox.Items.Count; i++)
            {
                cbNevek.Items.Add(combobox.Items[i]);
            }
        }

        private void BtnRogzit_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new(Resources.ConnectionString);
            conn.Open();

            string sql =
               "INSERT INTO bank VALUES " +
               $"('{txtbLeiras.Text}', '{dtpMikor.Value.Year}-{dtpMikor.Value.Month}-{dtpMikor.Value.Day}', {Program.nevekSorszama[cbNevek.Text]}, {nudOsszeg.Value});";

            SqlDataAdapter adapter = new()
            {
                InsertCommand = new SqlCommand(sql, conn)
            };
            adapter.InsertCommand.ExecuteNonQuery();
        }

        private void cbNevek_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRogzit.Enabled = true;
        }
    }
}
