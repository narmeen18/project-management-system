using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ui
{
    public partial class Add_project : UserControl
    {
        public Add_project()
        {
            InitializeComponent();
            base.CreateParams.ExStyle |= 0x20;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            BackColor = Color.FromArgb(0x80, 0x80, 0x80, 0x80);
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                Team t = new Team();
                Employee em = new Employee();
                Project pro = new Project();
                ProjectMngment pm = new ProjectMngment();
                em.ID = Convert.ToInt32(txtempid.Text);
                t.T_Id = Convert.ToInt32(txtteamid.Text);
                pro.pro_name = txtprojectname.Text;
                pro.pro_startdate = txtprojectS_date.Text;
                pro.pro_enddate = txtProjectE_Date.Text;
                pro.pro_status = Convert.ToInt32(Txtprojectstatus.Text);
                pm.Add(pro, t, em);
                lblmsg.Text = "Done";
            }
            catch(Exception ex)
            {

            }
        }
    }
}
