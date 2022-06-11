namespace DIP
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainControl = new System.Windows.Forms.TabControl();
            this.tablesPage = new System.Windows.Forms.TabPage();
            this.tablesControl = new System.Windows.Forms.TabControl();
            this.usersPage = new System.Windows.Forms.TabPage();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idWorkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dIPLOMDataSet = new DIP.DIPLOMDataSet();
            this.clientsPage = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersPage = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idWorkerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesPage = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.idMovieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.transactionsPage = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.idTransactionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClientDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idWorkerDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMovieDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesPage1 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.moviesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.addTransactionPage = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.moviesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.workersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.addClientPage = new System.Windows.Forms.TabPage();
            this.usersTableAdapter = new DIP.DIPLOMDataSetTableAdapters.UsersTableAdapter();
            this.clientsTableAdapter = new DIP.DIPLOMDataSetTableAdapters.ClientsTableAdapter();
            this.workersTableAdapter = new DIP.DIPLOMDataSetTableAdapters.WorkersTableAdapter();
            this.moviesTableAdapter = new DIP.DIPLOMDataSetTableAdapters.MoviesTableAdapter();
            this.transactionsTableAdapter = new DIP.DIPLOMDataSetTableAdapters.TransactionsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.fKTransactionsMoviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.mainControl.SuspendLayout();
            this.tablesPage.SuspendLayout();
            this.tablesControl.SuspendLayout();
            this.usersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIPLOMDataSet)).BeginInit();
            this.clientsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.workersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            this.moviesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            this.transactionsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            this.moviesPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource1)).BeginInit();
            this.addTransactionPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            this.addClientPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKTransactionsMoviesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainControl
            // 
            this.mainControl.Controls.Add(this.tablesPage);
            this.mainControl.Controls.Add(this.moviesPage1);
            this.mainControl.Controls.Add(this.addTransactionPage);
            this.mainControl.Controls.Add(this.addClientPage);
            this.mainControl.Location = new System.Drawing.Point(12, 12);
            this.mainControl.Name = "mainControl";
            this.mainControl.SelectedIndex = 0;
            this.mainControl.Size = new System.Drawing.Size(822, 495);
            this.mainControl.TabIndex = 0;
            // 
            // tablesPage
            // 
            this.tablesPage.BackColor = System.Drawing.Color.Gainsboro;
            this.tablesPage.Controls.Add(this.tablesControl);
            this.tablesPage.Location = new System.Drawing.Point(4, 22);
            this.tablesPage.Name = "tablesPage";
            this.tablesPage.Padding = new System.Windows.Forms.Padding(3);
            this.tablesPage.Size = new System.Drawing.Size(814, 469);
            this.tablesPage.TabIndex = 0;
            this.tablesPage.Text = "Таблицы";
            // 
            // tablesControl
            // 
            this.tablesControl.Controls.Add(this.usersPage);
            this.tablesControl.Controls.Add(this.clientsPage);
            this.tablesControl.Controls.Add(this.workersPage);
            this.tablesControl.Controls.Add(this.moviesPage);
            this.tablesControl.Controls.Add(this.transactionsPage);
            this.tablesControl.Location = new System.Drawing.Point(6, 6);
            this.tablesControl.Name = "tablesControl";
            this.tablesControl.SelectedIndex = 0;
            this.tablesControl.Size = new System.Drawing.Size(802, 457);
            this.tablesControl.TabIndex = 0;
            // 
            // usersPage
            // 
            this.usersPage.BackColor = System.Drawing.Color.DarkGray;
            this.usersPage.Controls.Add(this.buttonSave);
            this.usersPage.Controls.Add(this.dataGridView1);
            this.usersPage.Location = new System.Drawing.Point(4, 22);
            this.usersPage.Name = "usersPage";
            this.usersPage.Padding = new System.Windows.Forms.Padding(3);
            this.usersPage.Size = new System.Drawing.Size(794, 431);
            this.usersPage.TabIndex = 0;
            this.usersPage.Text = "Пользователи";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(713, 402);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUserDataGridViewTextBoxColumn,
            this.idWorkerDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(701, 419);
            this.dataGridView1.TabIndex = 0;
            // 
            // idUserDataGridViewTextBoxColumn
            // 
            this.idUserDataGridViewTextBoxColumn.DataPropertyName = "idUser";
            this.idUserDataGridViewTextBoxColumn.HeaderText = "idUser";
            this.idUserDataGridViewTextBoxColumn.Name = "idUserDataGridViewTextBoxColumn";
            this.idUserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idWorkerDataGridViewTextBoxColumn
            // 
            this.idWorkerDataGridViewTextBoxColumn.DataPropertyName = "idWorker";
            this.idWorkerDataGridViewTextBoxColumn.HeaderText = "idWorker";
            this.idWorkerDataGridViewTextBoxColumn.Name = "idWorkerDataGridViewTextBoxColumn";
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dIPLOMDataSet;
            // 
            // dIPLOMDataSet
            // 
            this.dIPLOMDataSet.DataSetName = "DIPLOMDataSet";
            this.dIPLOMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsPage
            // 
            this.clientsPage.BackColor = System.Drawing.Color.DarkGray;
            this.clientsPage.Controls.Add(this.button2);
            this.clientsPage.Controls.Add(this.dataGridView2);
            this.clientsPage.Location = new System.Drawing.Point(4, 22);
            this.clientsPage.Name = "clientsPage";
            this.clientsPage.Padding = new System.Windows.Forms.Padding(3);
            this.clientsPage.Size = new System.Drawing.Size(794, 431);
            this.clientsPage.TabIndex = 1;
            this.clientsPage.Text = "Клиенты";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClientDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.clientsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(701, 419);
            this.dataGridView2.TabIndex = 0;
            // 
            // idClientDataGridViewTextBoxColumn
            // 
            this.idClientDataGridViewTextBoxColumn.DataPropertyName = "idClient";
            this.idClientDataGridViewTextBoxColumn.HeaderText = "idClient";
            this.idClientDataGridViewTextBoxColumn.Name = "idClientDataGridViewTextBoxColumn";
            this.idClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "FIO";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.dIPLOMDataSet;
            // 
            // workersPage
            // 
            this.workersPage.BackColor = System.Drawing.Color.DarkGray;
            this.workersPage.Controls.Add(this.button4);
            this.workersPage.Controls.Add(this.dataGridView3);
            this.workersPage.Location = new System.Drawing.Point(4, 22);
            this.workersPage.Name = "workersPage";
            this.workersPage.Padding = new System.Windows.Forms.Padding(3);
            this.workersPage.Size = new System.Drawing.Size(794, 431);
            this.workersPage.TabIndex = 2;
            this.workersPage.Text = "Работники";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(716, 403);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idWorkerDataGridViewTextBoxColumn1,
            this.fIODataGridViewTextBoxColumn1,
            this.ageDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn1,
            this.postDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.workersBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(6, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(704, 419);
            this.dataGridView3.TabIndex = 0;
            // 
            // idWorkerDataGridViewTextBoxColumn1
            // 
            this.idWorkerDataGridViewTextBoxColumn1.DataPropertyName = "idWorker";
            this.idWorkerDataGridViewTextBoxColumn1.HeaderText = "idWorker";
            this.idWorkerDataGridViewTextBoxColumn1.Name = "idWorkerDataGridViewTextBoxColumn1";
            this.idWorkerDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fIODataGridViewTextBoxColumn1
            // 
            this.fIODataGridViewTextBoxColumn1.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn1.HeaderText = "FIO";
            this.fIODataGridViewTextBoxColumn1.Name = "fIODataGridViewTextBoxColumn1";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn1
            // 
            this.phoneDataGridViewTextBoxColumn1.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn1.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn1.Name = "phoneDataGridViewTextBoxColumn1";
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            // 
            // postDataGridViewTextBoxColumn
            // 
            this.postDataGridViewTextBoxColumn.DataPropertyName = "Post";
            this.postDataGridViewTextBoxColumn.HeaderText = "Post";
            this.postDataGridViewTextBoxColumn.Name = "postDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "Workers";
            this.workersBindingSource.DataSource = this.dIPLOMDataSet;
            // 
            // moviesPage
            // 
            this.moviesPage.BackColor = System.Drawing.Color.DarkGray;
            this.moviesPage.Controls.Add(this.dataGridView4);
            this.moviesPage.Controls.Add(this.button6);
            this.moviesPage.Location = new System.Drawing.Point(4, 22);
            this.moviesPage.Name = "moviesPage";
            this.moviesPage.Padding = new System.Windows.Forms.Padding(3);
            this.moviesPage.Size = new System.Drawing.Size(794, 431);
            this.moviesPage.TabIndex = 3;
            this.moviesPage.Text = "Фильмы";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMovieDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.moviesBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(6, 6);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(701, 419);
            this.dataGridView4.TabIndex = 7;
            // 
            // idMovieDataGridViewTextBoxColumn
            // 
            this.idMovieDataGridViewTextBoxColumn.DataPropertyName = "idMovie";
            this.idMovieDataGridViewTextBoxColumn.HeaderText = "idMovie";
            this.idMovieDataGridViewTextBoxColumn.Name = "idMovieDataGridViewTextBoxColumn";
            this.idMovieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataMember = "Movies";
            this.moviesBindingSource.DataSource = this.dIPLOMDataSet;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(713, 402);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Сохранить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // transactionsPage
            // 
            this.transactionsPage.BackColor = System.Drawing.Color.DarkGray;
            this.transactionsPage.Controls.Add(this.button8);
            this.transactionsPage.Controls.Add(this.dataGridView5);
            this.transactionsPage.Location = new System.Drawing.Point(4, 22);
            this.transactionsPage.Name = "transactionsPage";
            this.transactionsPage.Padding = new System.Windows.Forms.Padding(3);
            this.transactionsPage.Size = new System.Drawing.Size(794, 431);
            this.transactionsPage.TabIndex = 4;
            this.transactionsPage.Text = "Транзакции";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(713, 403);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "Сохранить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTransactionDataGridViewTextBoxColumn,
            this.idClientDataGridViewTextBoxColumn1,
            this.idWorkerDataGridViewTextBoxColumn2,
            this.idMovieDataGridViewTextBoxColumn1,
            this.sumDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.transactionsBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(6, 6);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(701, 419);
            this.dataGridView5.TabIndex = 0;
            // 
            // idTransactionDataGridViewTextBoxColumn
            // 
            this.idTransactionDataGridViewTextBoxColumn.DataPropertyName = "idTransaction";
            this.idTransactionDataGridViewTextBoxColumn.HeaderText = "idTransaction";
            this.idTransactionDataGridViewTextBoxColumn.Name = "idTransactionDataGridViewTextBoxColumn";
            this.idTransactionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idClientDataGridViewTextBoxColumn1
            // 
            this.idClientDataGridViewTextBoxColumn1.DataPropertyName = "idClient";
            this.idClientDataGridViewTextBoxColumn1.HeaderText = "idClient";
            this.idClientDataGridViewTextBoxColumn1.Name = "idClientDataGridViewTextBoxColumn1";
            // 
            // idWorkerDataGridViewTextBoxColumn2
            // 
            this.idWorkerDataGridViewTextBoxColumn2.DataPropertyName = "idWorker";
            this.idWorkerDataGridViewTextBoxColumn2.HeaderText = "idWorker";
            this.idWorkerDataGridViewTextBoxColumn2.Name = "idWorkerDataGridViewTextBoxColumn2";
            // 
            // idMovieDataGridViewTextBoxColumn1
            // 
            this.idMovieDataGridViewTextBoxColumn1.DataPropertyName = "idMovie";
            this.idMovieDataGridViewTextBoxColumn1.HeaderText = "idMovie";
            this.idMovieDataGridViewTextBoxColumn1.Name = "idMovieDataGridViewTextBoxColumn1";
            // 
            // sumDataGridViewTextBoxColumn
            // 
            this.sumDataGridViewTextBoxColumn.DataPropertyName = "Sum";
            this.sumDataGridViewTextBoxColumn.HeaderText = "Sum";
            this.sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "Transactions";
            this.transactionsBindingSource.DataSource = this.dIPLOMDataSet;
            // 
            // moviesPage1
            // 
            this.moviesPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.moviesPage1.Controls.Add(this.textBox3);
            this.moviesPage1.Controls.Add(this.label5);
            this.moviesPage1.Controls.Add(this.textBox2);
            this.moviesPage1.Controls.Add(this.label4);
            this.moviesPage1.Controls.Add(this.textBox1);
            this.moviesPage1.Controls.Add(this.label3);
            this.moviesPage1.Controls.Add(this.label2);
            this.moviesPage1.Controls.Add(this.comboBox1);
            this.moviesPage1.Location = new System.Drawing.Point(4, 22);
            this.moviesPage1.Name = "moviesPage1";
            this.moviesPage1.Padding = new System.Windows.Forms.Padding(3);
            this.moviesPage1.Size = new System.Drawing.Size(814, 469);
            this.moviesPage1.TabIndex = 1;
            this.moviesPage1.Text = "Фильмы";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(69, 441);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(335, 21);
            this.textBox3.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Цена";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(69, 67);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(739, 368);
            this.textBox2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Описание";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 37);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 21);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Жанр";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.moviesBindingSource1;
            this.comboBox1.DisplayMember = "Title";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(69, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(335, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Title";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // moviesBindingSource1
            // 
            this.moviesBindingSource1.DataMember = "Movies";
            this.moviesBindingSource1.DataSource = this.dIPLOMDataSet;
            // 
            // addTransactionPage
            // 
            this.addTransactionPage.BackColor = System.Drawing.Color.Gainsboro;
            this.addTransactionPage.Controls.Add(this.button1);
            this.addTransactionPage.Controls.Add(this.textBox4);
            this.addTransactionPage.Controls.Add(this.label9);
            this.addTransactionPage.Controls.Add(this.comboBox4);
            this.addTransactionPage.Controls.Add(this.label8);
            this.addTransactionPage.Controls.Add(this.comboBox3);
            this.addTransactionPage.Controls.Add(this.label7);
            this.addTransactionPage.Controls.Add(this.comboBox2);
            this.addTransactionPage.Controls.Add(this.label6);
            this.addTransactionPage.Location = new System.Drawing.Point(4, 22);
            this.addTransactionPage.Name = "addTransactionPage";
            this.addTransactionPage.Padding = new System.Windows.Forms.Padding(3);
            this.addTransactionPage.Size = new System.Drawing.Size(814, 469);
            this.addTransactionPage.TabIndex = 2;
            this.addTransactionPage.Text = "Добавить транзакцию";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(121, 92);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(136, 20);
            this.textBox4.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Сумма";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.moviesBindingSource2;
            this.comboBox4.DisplayMember = "Title";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(121, 68);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(266, 21);
            this.comboBox4.TabIndex = 6;
            this.comboBox4.ValueMember = "idMovie";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // moviesBindingSource2
            // 
            this.moviesBindingSource2.DataMember = "Movies";
            this.moviesBindingSource2.DataSource = this.dIPLOMDataSet;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Название фильма";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.workersBindingSource1;
            this.comboBox3.DisplayMember = "FIO";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(121, 42);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(266, 21);
            this.comboBox3.TabIndex = 4;
            this.comboBox3.ValueMember = "idWorker";
            // 
            // workersBindingSource1
            // 
            this.workersBindingSource1.DataMember = "Workers";
            this.workersBindingSource1.DataSource = this.dIPLOMDataSet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "ФИО Работника";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.clientsBindingSource1;
            this.comboBox2.DisplayMember = "FIO";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(121, 15);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(266, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.ValueMember = "idClient";
            // 
            // clientsBindingSource1
            // 
            this.clientsBindingSource1.DataMember = "Clients";
            this.clientsBindingSource1.DataSource = this.dIPLOMDataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "ФИО Клиента";
            // 
            // addClientPage
            // 
            this.addClientPage.BackColor = System.Drawing.Color.Gainsboro;
            this.addClientPage.Controls.Add(this.textBox9);
            this.addClientPage.Controls.Add(this.textBox8);
            this.addClientPage.Controls.Add(this.label14);
            this.addClientPage.Controls.Add(this.label13);
            this.addClientPage.Controls.Add(this.button3);
            this.addClientPage.Controls.Add(this.textBox7);
            this.addClientPage.Controls.Add(this.textBox6);
            this.addClientPage.Controls.Add(this.textBox5);
            this.addClientPage.Controls.Add(this.label12);
            this.addClientPage.Controls.Add(this.label11);
            this.addClientPage.Controls.Add(this.label10);
            this.addClientPage.Location = new System.Drawing.Point(4, 22);
            this.addClientPage.Name = "addClientPage";
            this.addClientPage.Padding = new System.Windows.Forms.Padding(3);
            this.addClientPage.Size = new System.Drawing.Size(814, 469);
            this.addClientPage.TabIndex = 3;
            this.addClientPage.Text = "Добавить клиента";
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
            // 
            // transactionsTableAdapter
            // 
            this.transactionsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(606, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // fKTransactionsMoviesBindingSource
            // 
            this.fKTransactionsMoviesBindingSource.DataMember = "FK_Transactions_Movies";
            this.fKTransactionsMoviesBindingSource.DataSource = this.moviesBindingSource;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(714, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Имя";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Телефон";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Почта";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(64, 9);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(227, 20);
            this.textBox5.TabIndex = 3;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(64, 87);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(227, 20);
            this.textBox6.TabIndex = 4;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(64, 113);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(227, 20);
            this.textBox7.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(714, 432);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 31);
            this.button3.TabIndex = 10;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Фамилия";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Отчество";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(64, 35);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(227, 20);
            this.textBox8.TabIndex = 13;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(64, 61);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(227, 20);
            this.textBox9.TabIndex = 14;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(846, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainControl);
            this.Name = "Main";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.Main_Load);
            this.mainControl.ResumeLayout(false);
            this.tablesPage.ResumeLayout(false);
            this.tablesControl.ResumeLayout(false);
            this.usersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIPLOMDataSet)).EndInit();
            this.clientsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.workersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            this.moviesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            this.transactionsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            this.moviesPage1.ResumeLayout(false);
            this.moviesPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource1)).EndInit();
            this.addTransactionPage.ResumeLayout(false);
            this.addTransactionPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            this.addClientPage.ResumeLayout(false);
            this.addClientPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKTransactionsMoviesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainControl;
        private System.Windows.Forms.TabPage tablesPage;
        private System.Windows.Forms.TabControl tablesControl;
        private System.Windows.Forms.TabPage usersPage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage clientsPage;
        private System.Windows.Forms.TabPage moviesPage1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage workersPage;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage moviesPage;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TabPage transactionsPage;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dataGridView5;
        private DIPLOMDataSet dIPLOMDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DIPLOMDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWorkerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private DIPLOMDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private DIPLOMDataSetTableAdapters.WorkersTableAdapter workersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWorkerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn postDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private DIPLOMDataSetTableAdapters.MoviesTableAdapter moviesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMovieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        private DIPLOMDataSetTableAdapters.TransactionsTableAdapter transactionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTransactionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWorkerDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMovieDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource moviesBindingSource1;
        private System.Windows.Forms.BindingSource fKTransactionsMoviesBindingSource;
        private System.Windows.Forms.TabPage addTransactionPage;
        private System.Windows.Forms.TabPage addClientPage;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource moviesBindingSource2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource workersBindingSource1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource clientsBindingSource1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}