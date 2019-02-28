
using pv03_1707885_FakhriAzisBasiri.Model;
using pv03_1707885_FakhriAzisBasiri.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pv03_1707885_FakhriAzisBasiri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void submitNim_Click(object sender, EventArgs e)
        {
            TodoRepository todo = new TodoRepository();

            string nim = tbNim.Text;
            btnAdd.Enabled = true;

            if(todo.cekNim(nim)==1)
            {
                dataGridView1.DataSource = todo.getByNim(nim);
                tbNim.Enabled = false;
                submitNim.Enabled = false;
            }
            else
            {
                MessageBox.Show("Data tidak ditemukan","Peringatan");
                tbNim.Enabled = true;
                submitNim.Enabled = true;
            }

           // dataGridView1.DataSource = todo.getByNim(nim);
        }

        private void tbNim_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Todo temp = new Todo();

            temp.NimMhs = tbNim.Text;
            temp.Nama = tbNama.Text;
            temp.Kategori = tbKategori.Text;

            TodoRepository todo = new TodoRepository();

            todo.addTodo(temp);

            string nim = tbNim.Text;

            dataGridView1.DataSource = todo.getByNim(nim);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Todo temp = new Todo();

            temp.Id = Convert.ToInt16(tbDelete.Text);

            TodoRepository todo = new TodoRepository();

            todo.deleteTodo(temp);
            btnDelete.Enabled = false;
            string nim = tbNim.Text;

            dataGridView1.DataSource = todo.getByNim(nim);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Todo temp = new Todo();

            temp.Id = Convert.ToInt16(tbUpdateId.Text);
            temp.Nama = tbUpdateNK.Text;
            temp.Kategori = tbUpdateKK.Text;
            btnUpdate.Enabled = false;
            tbUpdateId.Enabled = false;
            TodoRepository todo = new TodoRepository();

            todo.updateTodo(temp);

            string nim = tbNim.Text;

            dataGridView1.DataSource = todo.getByNim(nim);
        }
    }
}
