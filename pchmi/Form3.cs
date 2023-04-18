using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pchmi
{
    public partial class Form3 : Form
    {
        string rec;
        OleDbConnection dbConnection;
        public Form3()
        {
            InitializeComponent();          
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            recipe(rec);
        }
        void recipe(string period)
        {
            rec1.Visible = false;
            rec2.Visible = false;
            rec3.Visible = false;
            rec4.Visible = false;
            rec5.Visible = false;
            rec6.Visible = false;
            string connectionString = "provider=Microsoft.ACE.OLEDB.16.0;Data Source=database.accdb";//строка соеденения
            dbConnection = new OleDbConnection(connectionString);//создаем соеденение
            dbConnection.Open();
            OleDbDataReader dbReader;                                          // открываем соеденение
            OleDbCommand dbCommand = new OleDbCommand("SELECT * FROM таблица WHERE Метка = @metka", dbConnection);
            dbCommand.Parameters.AddWithValue("@metka", period);//string query = "SELECT * FROM таблица" ;
            dbReader = dbCommand.ExecuteReader();
            if (dbReader.HasRows == false)
            {
                MessageBox.Show("Данные не найдены!", "Ошибка!");
            }
            else
            {
                int i = 0;
                while (dbReader.Read())
                {
                    switch (i)
                    {
                        case 0:
                            add_recipe(label1, label2, label3, dbReader, rec1);
                            i += 1;
                            break;
                        case 1:
                            add_recipe(label4, label5, label6, dbReader, rec2);
                            i += 1;
                            break;
                        case 2:
                            add_recipe(label7, label8, label9, dbReader, rec3);
                            i += 1;
                            break;
                        case 3:
                            add_recipe(label10, label11, label12, dbReader, rec4);
                            i += 1;
                            break;
                        case 4:
                            add_recipe(label13, label14, label15, dbReader, rec5);
                            i += 1;
                            break;
                        case 5:
                            add_recipe(label16, label17, label18, dbReader, rec6);
                            i += 1;
                            break;

                    }
                }
            }
        }
        void add_recipe(Label l1, Label l2, Label l3, OleDbDataReader r, GroupBox gr)
        {
            gr.Visible = true;
            l1.Text = r["Название"].ToString();
            l2.Text = r["Время приготовления"].ToString();
            //l3.Text = r["КБЖУ"].ToString();
            l3.Text = r["Код"].ToString();
            gr.TabIndex = Convert.ToInt32(r["Код"].ToString());
        }
        public void dinner(string s)
        {
            rec = s;
        }

        private void basic_Click(object sender, EventArgs e)
        {
            this.Dispose();
            var form = new Form1();
            form.Show();
        }

        private void recs_Click(object sender, EventArgs e)
        {
            this.Dispose();
            var form = new Form2();
            form.Show();
        }

        private void diary_Click(object sender, EventArgs e)
        {
            this.Dispose();
            var form = new Form5();
            form.Show();
        }

        private void rec_Click(object sender, EventArgs e)
        {
            GroupBox gr = sender as GroupBox;
            var form = new Form4();
            form.init_db_code(dbConnection, gr.TabIndex);
            this.Dispose();
            form.Show();
        }
    }
}
