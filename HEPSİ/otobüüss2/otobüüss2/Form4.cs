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

namespace otobüüss2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public void DatagridviewListele()
        {
            DATA.conn.Open();
            string Select = "SELECT * FROM Sube";
            SqlDataAdapter da = new SqlDataAdapter(Select, DATA.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            DATA.conn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DATA dt = new DATA();
            dt.SubeEkle(textBox2.Text, textBox3.Text);
            DatagridviewListele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DATA dt = new DATA();
            dt.SubeSil(ID);
            DatagridviewListele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DatagridviewListele();
        }
        public void DatagridviewListele()
        {
            DATA.conn.Open();
            string Select = "SELECT * FROM Sube";
            SqlDataAdapter da = new SqlDataAdapter(Select, DATA.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            DATA.conn.Close();
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
            DATA dt = new DATA();
            dt.SubeGuncelle(ID, textBox2.Text, textBox3.Text);
        }

    }
}

