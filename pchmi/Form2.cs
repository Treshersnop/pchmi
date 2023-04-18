using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pchmi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void breakfast_Click(object sender, EventArgs e)
        {
            what_dinner("Завтрак");
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            recs.Enabled = false;
        }

        private void lunch_Click(object sender, EventArgs e)
        {
            what_dinner("Обед");
        }

        private void dinner_Click(object sender, EventArgs e)
        {
            what_dinner("Ужин");
        }

        private void snack_Click(object sender, EventArgs e)
        {
            what_dinner("Перекус");
        }
        void what_dinner(string din)
        {
            this.Dispose();
            var form = new Form3();
            form.dinner(din);
            form.Show();
        }

        private void diary_Click(object sender, EventArgs e)
        {
            this.Dispose();
            var form = new Form5();
            form.Show();
        }

        private void basic_Click(object sender, EventArgs e)
        {
            this.Dispose();
            var form = new Form1();
            form.Show();
        }
    }
}
