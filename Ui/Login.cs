using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ui
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Clear();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            if (textBox3.Text == "Password")
            {
                textBox3.Clear();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="admin" && textBox3.Text == "admin"&& comboBox1.SelectedItem.Equals("Admin"))
            {
                Form1 f = new Form1();
                f.Show();

            }
            if (textBox1.Text == "employee" && textBox3.Text == "employee" && comboBox1.SelectedItem.Equals("Employee")) 
            {
                Form1 f = new Form1();
                f.Add_project.Enabled = false;
                f.Add_emp.Enabled = false;
                f.Add_team.Enabled = false;
                f.btnaddpayment.Enabled = false;
                f.btnviewemp.Enabled = false;
                f.btnviewteam.Enabled = false;
                f.btnviewpayment.Enabled = false;
                f.bunifuFlatButton10.Enabled = false;
                f.bunifuFlatButton1.Enabled = false;
                f.Show();

            }



        }
    }
}
