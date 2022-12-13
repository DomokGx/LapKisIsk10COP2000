using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using LapKisIsk10COP2000.Properties;
using Microsoft.Data.SqlClient;

namespace LapKisIsk10COP2000
{
    public partial class FrmSzamlaKimut : Form
    {
        public FrmSzamlaKimut()
        {
            InitializeComponent();
        }

        private void FrmSzamlaKimut_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                cbHonap.Items.Add(i);
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog directchoosedlg = new FolderBrowserDialog();
            if (directchoosedlg.ShowDialog() == DialogResult.OK)
            {
                string output_path = directchoosedlg.SelectedPath;

                using SqlConnection conn = new(Resources.ConnectionString);
                conn.Open();

                using (StreamWriter sw = new StreamWriter($@"{output_path}\szamla_{cbHonap.Text}.txt"))
                {
                    string sql =
                       "SELECT sum(osszeg) FROM bank " +
                       $"WHERE month(mikor) < {cbHonap.Text};";

                    var reader = new SqlCommand(sql, conn).ExecuteReader();

                    reader.Read();
                    sw.WriteLine($"Kezdőösszeg: {(reader.IsDBNull(0) ? 0 : reader[0])} Ft");

                    reader.Close();

                    sql =
                       "SELECT mikor, nev, leiras, osszeg FROM naplo, bank " +
                       $"WHERE sorszam = ki and month(mikor) = {cbHonap.Text};";

                    reader = new SqlCommand(sql, conn).ExecuteReader();

                    while (reader.Read())
                    {
                        sw.WriteLine($"[{reader[0]}]\t{reader[1]}\t\t{reader[2]} - ({reader[3]} Ft)");
                    }

                    reader.Close();

                    sql =
                       "SELECT sum(osszeg) as a FROM bank " +
                       $"WHERE month(mikor) <= {cbHonap.Text};";

                    reader = new SqlCommand(sql, conn).ExecuteReader();

                    reader.Read();
                    sw.WriteLine($"Végösszeg: {(reader.IsDBNull(0) ? 0 : reader[0])} Ft");
                }
            }
        }

        private void CbHonap_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnExport.Enabled = true;
        }
    }
}
