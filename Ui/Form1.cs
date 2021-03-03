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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            add_employee1.Visible = false;
            add_project1.Visible = false;
            add_Team1.Visible = false;
            add_payment1.Visible = false;
            view_Project1.Visible = false;
            view_employee2.Visible = false;
            view_Team1.Visible = false;
            view_Payment1.Visible = false;
            update_project2.Visible = false;
            delete_team1.Visible = false;

        }

        private void Add_employee_Click(object sender, EventArgs e)
        {
             add_employee1.Visible = true;
            add_project1.Visible = false;
            add_Team1.Visible = false;
            add_payment1.Visible = false;
            view_Project1.Visible = false;
            view_employee2.Visible = false;
            view_Team1.Visible = false;
            view_Payment1.Visible = false;
            update_project2.Visible = false;
            delete_team1.Visible = false;



        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            add_project1.Visible = false;
            add_employee1.Visible = false;
            add_Team1.Visible = false;
            add_payment1.Visible = false;
            view_Project1.Visible = true;
            view_employee2.Visible = false;
            view_Team1.Visible = false;
            view_Payment1.Visible = false;
            update_project2.Visible = false;
            delete_team1.Visible = false;

        }

        private void Add_project_Click(object sender, EventArgs e)
        {
            add_project1.Visible = true;
            add_employee1.Visible = false;
            add_Team1.Visible = false;
            add_payment1.Visible = false;
            view_Project1.Visible = false;
            view_employee2.Visible = false;
            view_Team1.Visible = false;
            view_Payment1.Visible = false;
            update_project2.Visible = false;
            delete_team1.Visible = false;
        }

        private void Add_team_Click(object sender, EventArgs e)
        {
            add_project1.Visible = false;
            add_employee1.Visible = false;
            add_Team1.Visible = true;
            add_payment1.Visible = false;
            view_Project1.Visible = false;
            view_employee2.Visible = false;
            view_Team1.Visible = false;
            view_Payment1.Visible = false;
            update_project2.Visible = false;
            delete_team1.Visible = false;
        }

        private void btnaddpayment_Click(object sender, EventArgs e)
        {
            add_project1.Visible = false;
            add_employee1.Visible = false;
            add_Team1.Visible = false;
            add_payment1.Visible = true;
            view_Project1.Visible = false;
            view_employee2.Visible = false;
            view_Team1.Visible = false;
            view_Payment1.Visible = false;
            update_project2.Visible = false;
            delete_team1.Visible = false;
        }

        private void btnviewemp_Click(object sender, EventArgs e)
        {
            view_employee2.Visible = true;
            add_employee1.Visible = false;
            add_project1.Visible = false;
            add_Team1.Visible = false;
            add_payment1.Visible = false;
            view_Project1.Visible = false;
            view_Team1.Visible = false;
            view_Payment1.Visible = false;
            update_project2.Visible = false;
            delete_team1.Visible = false;
        }

        private void btnviewteam_Click(object sender, EventArgs e)
        {
            view_employee2.Visible = false;
            add_employee1.Visible = false;
            add_project1.Visible = false;
            add_Team1.Visible = false;
            add_payment1.Visible = false;
            view_Project1.Visible = false;
            view_Team1.Visible = true;
            view_Payment1.Visible = false;
            update_project2.Visible = false;
            delete_team1.Visible = false;
        }

        private void btnviewpayment_Click(object sender, EventArgs e)
        {
            view_employee2.Visible = false;
            add_employee1.Visible = false;
            add_project1.Visible = false;
            add_Team1.Visible = false;
            add_payment1.Visible = false;
            view_Project1.Visible = false;
            view_Team1.Visible = false;
            view_Payment1.Visible = true;
            update_project2.Visible = false;
            delete_team1.Visible = false;
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            view_employee2.Visible = false;
            add_employee1.Visible = false;
            add_project1.Visible = false;
            add_Team1.Visible = false;
            add_payment1.Visible = false;
            view_Project1.Visible = false;
            view_Team1.Visible = false;
            view_Payment1.Visible = false;
            update_project2.Visible = true;
            delete_team1.Visible = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            view_employee2.Visible = false;
            add_employee1.Visible = false;
            add_project1.Visible = false;
            add_Team1.Visible = false;
            add_payment1.Visible = false;
            view_Project1.Visible = false;
            view_Team1.Visible = false;
            view_Payment1.Visible = false;
            update_project2.Visible =false;
            delete_team1.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
