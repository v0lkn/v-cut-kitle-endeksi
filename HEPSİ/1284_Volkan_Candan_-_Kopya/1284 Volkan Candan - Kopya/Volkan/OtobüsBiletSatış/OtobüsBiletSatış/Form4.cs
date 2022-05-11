using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtobüsBiletSatış
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                Data dt = new Data();
                dt.SubeEkle(textBox2.Text,textBox3.Text);
                DatagridviewListele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data dt = new Data();
            dt.SubeSil(ID);
            DatagridviewListele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DatagridviewListele();
        }
        public void DatagridviewListele()
        {
            Data.conn.Open();
            string Select = "SELECT * FROM Sube";
            SqlDataAdapter da = new SqlDataAdapter(Select, Data.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Data.conn.Close();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            DatagridviewListele();
        }
        public int ID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Data dt = new Data();
            dt.SubeGuncelle(ID,textBox2.Text, textBox3.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
