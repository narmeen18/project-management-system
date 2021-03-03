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
    public partial class Delete_team : UserControl
    {
        private string strTableName = "Project";
        private string strConn;
        private string SERVER = "DESKTOP-R3F55TP";
        //Working
        //
        private string DATABASE = "PMS";
        private string USERID = "sa";
        private string PASSWORD = "Ahmedali";
        private SqlConnection con;
        private SqlCommand cmd;
        public Delete_team()
        {
            InitializeComponent();
            base.CreateParams.ExStyle |= 0x20;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            BackColor = Color.FromArgb(0x80, 0x80, 0x80, 0x80);
            this.strConn = "server=" + this.SERVER + ";Database=" + this.DATABASE + ";User Id=" + this.USERID + ";Password=" + this.PASSWORD + ";";
            con = new SqlConnection(this.strConn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select Team.T_Id,Pro_Status from Team,Project where Team.T_Id=Project.T_Id and Pro_Status=1";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teammng t = new Teammng();
            t.delete(Convert.ToInt32(textBox1.Text));
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["T_Id"].Value.ToString();

                //txtstatus.Text = row.Cells["pro_status"].Value.ToString();
            }
        }
    }
}
