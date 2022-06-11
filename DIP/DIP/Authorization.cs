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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DA;Initial Catalog=DIPLOM;Integrated Security=True";
            SqlConnection MyConnection = new SqlConnection(connectionString);

            string loginUser = loginBox.Text;
            string passwordUser = passwordBox.Text;
            string roleSysadmin = "sysadmin";
            string roleAdmin = "admin";

            string loginsQuery = "SELECT * FROM Users";

            SqlDataReader Reader1;
            SqlCommand loginCmd = new SqlCommand(loginsQuery, MyConnection);
            MyConnection.Open();
            Reader1 = loginCmd.ExecuteReader();
            while (Reader1.Read())
            {
                string workerID = Reader1[1].ToString();
                string login = Reader1[2].ToString();
                string password = Reader1[3].ToString();
                string role = Reader1[4].ToString();

                if (login == loginUser && password == passwordUser)
                {
                    if (role == roleSysadmin)
                    {
                        NameUser.nameUser = workerID;
                        RoleUser.roleUser = role;
                        Main main = new Main();
                        main.Show();
                        this.Hide();
                        return;
                    }

                    else if (role == roleAdmin)
                    {
                        NameUser.nameUser = workerID;
                        RoleUser.roleUser = role;
                        Main main = new Main();
                        main.Show();
                        this.Hide();
                        return;
                    }
                }
            }
            label3.Text = "Введен неверный логин или пароль";
            MyConnection.Close();
        }
    }
}
