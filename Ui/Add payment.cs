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
    public partial class Add_payment : UserControl
    {
        public Add_payment()
        {
            InitializeComponent();
            base.CreateParams.ExStyle |= 0x20;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            BackColor = Color.FromArgb(0x80, 0x80, 0x80, 0x80);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            PAYMENTMNG MNG = new PAYMENTMNG();
            Payment P = new Payment();
            Project PROJECT = new Project();
            try
            {
                P.CID = textBox1.Text;
                P.Date = textBox2.Text;
                P.Amount = Convert.ToInt32(textBox3.Text);
                PROJECT.pro_id = Convert.ToInt32(textBox4.Text);
                MNG.Add(P, PROJECT);
                lblmsg.Text = "Done";

                

            }catch(Exception ex)
            {

            }
        }
    }
}
