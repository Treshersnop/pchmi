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
    public partial class Form4 : Form
    {
        OleDbConnection dbConnection;
        int code_recipe;
        public Form4()
        {
            InitializeComponent();           
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            recipe(code_recipe);
        }
        void recipe(int k)
        {
            OleDbDataReader dbReader;                                         
            //string query = "SELECT * FROM таблица WHERE Код =" + k.ToString();
            //OleDbCommand dbCommand = new OleDbCommand(query, dbConnection); // команда
            //dbReader = dbCommand.ExecuteReader();
            OleDbCommand dbCommand = new OleDbCommand("SELECT * FROM таблица WHERE Метка = @k", dbConnection);
            dbCommand.Parameters.AddWithValue("k", k);
            dbReader = dbCommand.ExecuteReader();
            if (dbReader.HasRows == false)
            {
                MessageBox.Show("Данные не найдены!", "Ошибка!");
            }
            else
            {
                // Чтение данных
                dbReader.Read();
                // Выводим данные
                name_r.Text = dbReader["Название"].ToString();
                time_r.Text = dbReader["Время приготовления"].ToString();
                string t = dbReader["КБЖУ"].ToString();
                val_r.Text = t.Replace(";", "\n");
                desc.Text = dbReader["Описание"].ToString();
                ingr.Text = dbReader["Ингредиенты"].ToString();
            }
            dbConnection.Close();
        }
        public void init_db_code(OleDbConnection con, int code)
        {
            dbConnection = con;
            code_recipe = code;
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
    }
}
