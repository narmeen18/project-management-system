using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ui
{
    public partial class Add_Team : UserControl
    {
       
       
        public Add_Team()
        {
            InitializeComponent();
            base.CreateParams.ExStyle |= 0x20;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            BackColor = Color.FromArgb(0x80, 0x80, 0x80, 0x80);
          
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                Teammng t = new Teammng();
                Team t1 = new Team();
                Employee emp = new Employee();

                t1.T_Member = Convert.ToInt32(textBox1.Text);
                t1.T_Wh = Convert.ToInt32(textBox2.Text);
                emp.ID = Convert.ToInt32(txtemp.Text);
                t.Add(t1,emp);
                lblmsg.Text = "Done";
            }
            catch(Exception ex)
            {
              
                

            }
        }
    }


        }






 


