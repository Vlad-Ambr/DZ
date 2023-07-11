using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=HOME;Database=ListITComp;Trusted_Connection=True;TrustServerCertificate=True;";
        string sqlCommand = "SELECT * FROM [ITComp]";
        int y = 48;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            Download_Data_From_DataBase();
        }
        private void Download_Data_From_DataBase()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, connectionString);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable ITCompTable = ds.Tables[0];
                foreach (DataRow dr in ITCompTable.Rows)
                {
                    var item = new UserControl1(dr.ItemArray[0].ToString(), dr.ItemArray[1].ToString(), dr.ItemArray[2].ToString(), dr.ItemArray[3].ToString(), dr.ItemArray[4].ToString());
                    item.Name = $"UserControl_{count++}";
                    item.Location = new Point(0, y);
                    y += item.Height - 1;
                    this.Controls.Add(item);
                }
            }
            y = 48;
        }
        private void Change_Language(string lang)
        {
            ComponentResourceManager maneger = new ComponentResourceManager(typeof(Form1));
            CultureInfo culture = new CultureInfo(lang);
            foreach (Control item in this.Controls)
            {
                maneger.ApplyResources(item, item.Name, culture);
            }
        }
        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Language("en");
        }

        private void ukrainianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Language("uk");
        }

        private void sPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Language("es");
        }

        private void gERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Language("de");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Change_Language("de");
        }

        private void englishToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            while(count >= 0)
            {
                this.Controls.RemoveByKey($"UserControl_{count--}");
            }
            count = 0;
            Download_Data_From_DataBase();
        }
    }
}