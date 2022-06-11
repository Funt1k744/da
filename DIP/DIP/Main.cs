using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIP
{
    public partial class Main : Form
    {
        string role = RoleUser.roleUser; 


        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (role == "sysadmin")
            {
                buttonSave.Visible = false;
                button2.Visible = false;
                button4.Visible = false;
                button6.Visible = false;
                button8.Visible = false;
                usersPage.Parent = null;
            }

            // TODO: данная строка кода позволяет загрузить данные в таблицу "dIPLOMDataSet.Transactions". При необходимости она может быть перемещена или удалена.
            this.transactionsTableAdapter.Fill(this.dIPLOMDataSet.Transactions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dIPLOMDataSet.Movies". При необходимости она может быть перемещена или удалена.
            this.moviesTableAdapter.Fill(this.dIPLOMDataSet.Movies);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dIPLOMDataSet.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.dIPLOMDataSet.Workers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dIPLOMDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.dIPLOMDataSet.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dIPLOMDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.dIPLOMDataSet.Users);

            string connectionString = @"Data Source=DA;Initial Catalog=DIPLOM;Integrated Security=True";
            SqlConnection MyConnection = new SqlConnection(connectionString);

            MyConnection.Open();
            string queryString = "SELECT Workers.FIO FROM Workers WHERE Workers.idWorker = " + NameUser.nameUser + "";
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, MyConnection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                label1.Text = "Здравствуйте, " + table.Rows[0][0].ToString();
            }
            MyConnection.Close();
        }

        // Сохранение //
        private void buttonSave_Click(object sender, EventArgs e)
        {
            usersTableAdapter.Update(dIPLOMDataSet.Users);
            this.usersTableAdapter.Fill(this.dIPLOMDataSet.Users);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clientsTableAdapter.Update(dIPLOMDataSet.Clients);
            this.clientsTableAdapter.Fill(this.dIPLOMDataSet.Clients);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            workersTableAdapter.Update(dIPLOMDataSet.Workers);
            this.workersTableAdapter.Fill(this.dIPLOMDataSet.Workers);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            moviesTableAdapter.Update(dIPLOMDataSet.Movies);
            this.moviesTableAdapter.Fill(this.dIPLOMDataSet.Movies);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            transactionsTableAdapter.Update(dIPLOMDataSet.Transactions);
            this.transactionsTableAdapter.Fill(this.dIPLOMDataSet.Transactions);
        }

        // . //

        // Фильмы //
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string titleMovie = comboBox1.Text;
            string connectionString = @"Data Source=DA;Initial Catalog=DIPLOM;Integrated Security=True";
            SqlConnection MyConnection = new SqlConnection(connectionString);

            MyConnection.Open();
            string queryString = "SELECT Movies.Genre, Movies.Description, Movies.Price FROM Movies WHERE Movies.Title = '" + titleMovie + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, MyConnection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                textBox1.Text = table.Rows[0][0].ToString();
                textBox2.Text = table.Rows[0][1].ToString();
                textBox3.Text = table.Rows[0][2].ToString();
            }
            MyConnection.Close();
        }

        // . //

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idMovie = Convert.ToInt32(comboBox4.SelectedValue).ToString();
            string connectionString = @"Data Source=DA;Initial Catalog=DIPLOM;Integrated Security=True";
            SqlConnection MyConnection = new SqlConnection(connectionString);
            MyConnection.Open();
            string queryString = "SELECT Movies.Price FROM Movies WHERE Movies.idMovie = '" + idMovie + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, MyConnection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                textBox4.Text = table.Rows[0][0].ToString();
            }
            MyConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DA;Initial Catalog=DIPLOM;Integrated Security=True";
            SqlConnection MyConnection = new SqlConnection(connectionString);
            MyConnection.Open();

            string idClient = Convert.ToInt32(comboBox2.SelectedValue).ToString();
            string idWorker = Convert.ToInt32(comboBox3.SelectedValue).ToString();
            string idMovie = Convert.ToInt32(comboBox4.SelectedValue).ToString();
            string sum = textBox4.Text;

            string addQuery = "INSERT INTO Transactions(idClient,idWorker,idMovie,Sum) VALUES(" + idClient + "," + idWorker + "," + idMovie + "," + sum + ")";

            SqlCommand addCmd = new SqlCommand(addQuery, MyConnection);

            addCmd.ExecuteReader();
            MyConnection.Close();

            MessageBox.Show("Добавлено");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DA;Initial Catalog=DIPLOM;Integrated Security=True";
            SqlConnection MyConnection = new SqlConnection(connectionString);
            MyConnection.Open();

            string nameClient = textBox5.Text;
            string surnameClient = textBox8.Text;
            string patronymicClient = textBox9.Text;
            string phoneClient = textBox6.Text;
            string emailClient = textBox7.Text;

            string addQuery = "INSERT INTO Clients(FIO,Phone,Email) VALUES('" + nameClient + " " + surnameClient + " " + patronymicClient + "','" + phoneClient + "','" + emailClient +"')";

            SqlCommand addCmd = new SqlCommand(addQuery, MyConnection);

            addCmd.ExecuteReader();
            MyConnection.Close();

            MessageBox.Show("Добавлено");
        }
    }
}
