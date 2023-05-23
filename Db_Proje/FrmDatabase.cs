using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Db_Proje
{
    public partial class FrmDatabase : Form
    {
        public FrmDatabase()
        {
            InitializeComponent();
        }

        private void CmbWindowsAuth_CheckedChanged(object sender, EventArgs e)
        {
            if (CmbWindowsAuth.Checked)
            {
                TxtKullaniciAdi.Enabled = false;
                TxtSifre.Enabled = false;
            }
            else
            {
                TxtKullaniciAdi.Enabled = true;
                TxtSifre.Enabled = true;
            }
        }

        

        private void Veritabanlari_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtSeciliVeritabani.Text = Veritabanlari.Text;
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            string tabloAdi = Veritabanlari.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(tabloAdi))
            {
                MessageBox.Show("Lütfen bir tablo seçin.");
                return;
            }

            string storeProcedureAdi = $"{tabloAdi}_Insert";

            string spScript = GenerateInsertStoreProcedure(tabloAdi);
            TxtProcedure.Text = spScript;
            TxtProsedurAdi.Text = storeProcedureAdi;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string tabloAdi = Veritabanlari.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(tabloAdi))
            {
                MessageBox.Show("Lütfen bir tablo seçin.");
                return;
            }

            string storeProcedureAdi = $"{tabloAdi}_Update";

            string spScript = GenerateUpdateStoreProcedure(tabloAdi);
            TxtProcedure.Text = spScript;
            TxtProsedurAdi.Text = storeProcedureAdi;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string tabloAdi = Veritabanlari.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(tabloAdi))
            {
                MessageBox.Show("Lütfen bir tablo seçin.");
                return;
            }

            string storeProcedureAdi = $"{tabloAdi}_Delete";
            string spScript = GenerateDeleteStoreProcedure(tabloAdi);
            TxtProcedure.Text = spScript;
            TxtProsedurAdi.Text = storeProcedureAdi;
        }

        private string GetBaglantiString()
        {
            string baglantiString = string.Empty;
            string serverName = TxtSunucuAdi.Text;
            string databaseName = CmbVeritabani.Text;
            string username = TxtKullaniciAdi.Text;
            string password = TxtSifre.Text;
            bool useWindowsAuth = CmbWindowsAuth.Checked;

            if (useWindowsAuth)
            {
                if (serverName != "" && databaseName != "")
                {
                    baglantiString = $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True";
                }
                else
                {
                    MessageBox.Show("Server Adı ve/veya Veritabanı Adı Eksik !!");
                }
            }
            else
            {
                if (serverName != "" && databaseName != "" && username != "" && password != "")
                {
                    baglantiString = $"Data Source={serverName};Initial Catalog={databaseName};User ID={username};Password={password}";
                }
            }

            return baglantiString;
        }

        private string GenerateInsertStoreProcedure(string tabloAdi)
        {
            StringBuilder scriptBuilder = new StringBuilder();
            scriptBuilder.AppendLine($"CREATE PROCEDURE {tabloAdi}_Insert");
            scriptBuilder.AppendLine("(");

            DataTable alanlar = GetTabloAlanlariniAl(tabloAdi);

            for (int i = 0; i < alanlar.Rows.Count; i++)
            {
                string alanAdi = alanlar.Rows[i]["COLUMN_NAME"].ToString();
                string veriTipi = alanlar.Rows[i]["DATA_TYPE"].ToString();

                alanAdi = alanAdi.Replace(" ", "");

                scriptBuilder.AppendLine($"\t@{alanAdi} {veriTipi},");

                if (i == alanlar.Rows.Count - 1)
                {
                    scriptBuilder.Remove(scriptBuilder.Length - 3, 1);
                }
            }

            scriptBuilder.AppendLine(")");
            scriptBuilder.AppendLine("AS");
            scriptBuilder.AppendLine("BEGIN");
            scriptBuilder.AppendLine($"\tINSERT INTO {tabloAdi}");
            scriptBuilder.AppendLine("\t(");

            for (int i = 0; i < alanlar.Rows.Count; i++)
            {
                string alanAdi = alanlar.Rows[i]["COLUMN_NAME"].ToString();

                if (alanAdi.Contains(" "))
                {
                    alanAdi = "[" + alanAdi + "]";
                }

                scriptBuilder.AppendLine($"\t\t{alanAdi},");
            }
            scriptBuilder.Remove(scriptBuilder.Length - 3, 1);
            scriptBuilder.AppendLine("\t)");
            scriptBuilder.AppendLine("\tVALUES");
            scriptBuilder.AppendLine("\t(");

            for (int i = 0; i < alanlar.Rows.Count; i++)
            {
                string alanAdi = alanlar.Rows[i]["COLUMN_NAME"].ToString();
                alanAdi = alanAdi.Replace(" ", "");

                scriptBuilder.AppendLine($"\t\t@{alanAdi},");
            }
            scriptBuilder.Remove(scriptBuilder.Length - 3, 1);
            scriptBuilder.AppendLine("\t)");
            scriptBuilder.AppendLine("END");

            return scriptBuilder.ToString();
        }

        private string GenerateUpdateStoreProcedure(string tabloAdi)
        {
            StringBuilder scriptBuilder = new StringBuilder();
            scriptBuilder.AppendLine($"CREATE PROCEDURE {tabloAdi}_Update");
            scriptBuilder.AppendLine("(");

            DataTable alanlar = GetTabloAlanlariniAl(tabloAdi);

            for (int i = 0; i < alanlar.Rows.Count; i++)
            {
                string alanAdi = alanlar.Rows[i]["COLUMN_NAME"].ToString();
                string veriTipi = alanlar.Rows[i]["DATA_TYPE"].ToString();

                alanAdi = alanAdi.Replace(" ", "");

                scriptBuilder.AppendLine($"\t@{alanAdi} {veriTipi},");

                if (i == alanlar.Rows.Count - 1)
                {
                    scriptBuilder.Remove(scriptBuilder.Length - 3, 1);
                }
            }
            scriptBuilder.AppendLine(")");
            scriptBuilder.AppendLine("AS");
            scriptBuilder.AppendLine("BEGIN");
            scriptBuilder.AppendLine($"\tUPDATE {tabloAdi}");
            scriptBuilder.AppendLine("\tSET");
            string idalanı = "ID";
            for (int i = 1; i < alanlar.Rows.Count; i++)
            {
                string alanAdi = alanlar.Rows[i]["COLUMN_NAME"].ToString();

                if (alanAdi.Contains(" "))
                {
                    alanAdi = "[" + alanAdi + "]";
                }

                idalanı = alanlar.Rows[0]["COLUMN_NAME"].ToString();

                scriptBuilder.AppendLine($"\t\t{alanAdi} = @{alanAdi.Replace(" ", "").Replace("[", "").Replace("]", "")},");

                if (i == alanlar.Rows.Count - 1)
                {
                    scriptBuilder.Remove(scriptBuilder.Length - 3, 1);
                }
            }

            scriptBuilder.AppendLine("\tWHERE");
            scriptBuilder.AppendLine($"\t\t{idalanı} = @{idalanı}");
            scriptBuilder.AppendLine("END");

            return scriptBuilder.ToString();
        }

        private string GenerateDeleteStoreProcedure(string tabloAdi)
        {
            StringBuilder scriptBuilder = new StringBuilder();
            scriptBuilder.AppendLine($"CREATE PROCEDURE {tabloAdi}_Delete");
            scriptBuilder.AppendLine("(");

            DataTable alanlar = GetTabloAlanlariniAl(tabloAdi);

            for (int i = 0; i < alanlar.Rows.Count; i++)
            {
                string alanAdi = alanlar.Rows[i]["COLUMN_NAME"].ToString();
                string veriTipi = alanlar.Rows[i]["DATA_TYPE"].ToString();

                alanAdi = alanAdi.Replace(" ", "");

                scriptBuilder.AppendLine($"\t@{alanAdi} {veriTipi},");

                if (i == alanlar.Rows.Count - 1)
                {
                    scriptBuilder.Remove(scriptBuilder.Length - 3, 1);
                }
            }
            string idalanı = alanlar.Rows[0]["COLUMN_NAME"].ToString();
            scriptBuilder.AppendLine(")");
            scriptBuilder.AppendLine("AS");
            scriptBuilder.AppendLine("BEGIN");
            scriptBuilder.AppendLine($"\tDELETE FROM {tabloAdi}");
            scriptBuilder.AppendLine("\tWHERE");
            scriptBuilder.AppendLine($"\t\t{idalanı} = @{idalanı}");

            scriptBuilder.AppendLine("END");

            return scriptBuilder.ToString();
        }

        private DataTable GetTabloAlanlariniAl(string tabloAdi)
        {
            DataTable alanlar = new DataTable();

            string baglantiString = GetBaglantiString();

            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiString))
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand($"SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tabloAdi}'", baglanti);
                    SqlDataAdapter adapter = new SqlDataAdapter(komut);
                    adapter.Fill(alanlar);

                    baglanti.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tablo alanlarını alırken bir hata oluştu: " + ex.Message);
            }

            return alanlar;
        }


        private void CreateStoreProcedure(string storeProcedureAdi, string script)
        {
            try
            {
                string baglantiString = GetBaglantiString();

                using (SqlConnection baglanti = new SqlConnection(baglantiString))
                {
                    baglanti.Open();

                    SqlCommand komut = new SqlCommand(script, baglanti);
                    komut.ExecuteNonQuery();

                    baglanti.Close();
                }

                MessageBox.Show($"{storeProcedureAdi} adında bir store procedure oluşturuldu ve veritabanına eklendi.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Store procedure oluşturma sırasında bir hata oluştu: " + ex.Message);
            }
        }

        private void BtnVeritabaninaAktar_Click(object sender, EventArgs e)
        {
            string storeProcedureAdi = TxtProsedurAdi.Text;
            if (TxtProsedurAdi.Text != "")
            {
                CreateStoreProcedure(storeProcedureAdi, TxtProcedure.Text);
            }
            else
            {
                MessageBox.Show("Lütfen Bir Procedure Oluşturun !!");
            }
        }

        private void BtnEnabled_Click(object sender, EventArgs e)
        {
            if (TxtProcedure.ReadOnly == false)
            {
                TxtProcedure.ReadOnly = true;
                TxtProsedurAdi.ReadOnly = true;
            }
            else
            {
                TxtProcedure.ReadOnly = false;
                TxtProsedurAdi.ReadOnly = false;
            }
        }

        

        private void CmbVeritabani_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            if (TxtSunucuAdi.Text != "" && CmbVeritabani.Text != "")
            {
                TxtProcedure.Text = "";
                TxtProsedurAdi.Text = "";
                TxtSeciliVeritabani.Text = "";
                string serverName = TxtSunucuAdi.Text;
                string databaseName = CmbVeritabani.Text;
                string username = TxtKullaniciAdi.Text;
                string password = TxtSifre.Text;
                bool useWindowsAuth = CmbWindowsAuth.Checked;

                string connectionString;
                if (useWindowsAuth)
                {
                    connectionString = $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True";

                    TablolariGetir(connectionString);
                }
                else
                {
                    if (TxtKullaniciAdi.Text != "" && TxtSifre.Text != "")
                    {
                        connectionString = $"Data Source={serverName};Initial Catalog={databaseName};User ID={username};Password={password}";

                        TablolariGetir(connectionString);
                    }
                    else
                    {
                        connectionString = "";
                        MessageBox.Show("Kullanıcı Adı Ve/Veya Şifre Eksik !!");
                    }
                }              
            }
            else
            {
                MessageBox.Show("Sunucu Adı Ve/Veya Veritabanı Adı Eksik !!");

            }
        }

        private void BtnSorgula_Click(object sender, EventArgs e)
        {
            if (TxtSunucuAdi.Text != "")
            {
                TxtProcedure.Text = "";
                TxtProsedurAdi.Text = "";
                TxtSeciliVeritabani.Text = "";
                string serverName = TxtSunucuAdi.Text;
                string databaseName = CmbVeritabani.Text;
                string username = TxtKullaniciAdi.Text;
                string password = TxtSifre.Text;
                bool useWindowsAuth = CmbWindowsAuth.Checked;
                string connectionString;

                if (useWindowsAuth)
                {
                    connectionString = $"Data Source={serverName};Initial Catalog=master;Integrated Security=True";
                    VeritabanlariniGetir(connectionString);
                }
                else
                {
                    if (TxtKullaniciAdi.Text != "" && TxtSifre.Text != "")
                    {
                        connectionString = $"Data Source={serverName};Initial Catalog=master;User ID={username};Password={password}";
                        VeritabanlariniGetir(connectionString);
                    }
                    else
                    {
                        connectionString = "";
                        MessageBox.Show("Kullanıcı Adı Ve/Veya Şifre Eksik !!");                        
                    }
                }
               

            }
            else
            {
                MessageBox.Show("Sunucu Adı Eksik !!");

            }
        }

        public void VeritabanlariniGetir(string connectionString)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT name FROM sys.databases";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string databaseNames = reader.GetString(0);
                                CmbVeritabani.Items.Add(databaseNames);
                            }
                        }
                    }
                }
                MessageBox.Show("Veritabanları eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanları getirilirken bir hata oluştu: " + ex.Message);
            }
        }

        public void TablolariGetir(string connectionString)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    DataTable tablolar = connection.GetSchema("Tables");
                    Veritabanlari.Items.Clear();
                    foreach (DataRow row in tablolar.Rows)
                    {
                        string tabloAdi = row["TABLE_NAME"].ToString();
                        Veritabanlari.Items.Add(tabloAdi);
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanları getirilirken bir hata oluştu: " + ex.Message);
            }
        }

       
    }
}
