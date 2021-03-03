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
    public partial class Add_employee : UserControl
    {
        Employee em = new Employee();
        Employeemng me = new Employeemng();
        Image image;
        string FileName;
        public Add_employee()
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

                em.Name = txtname.Text;
                em.Nic = txtcnic.Text;
                em.Salary = txtsalary.Text;
                em.Status = txtstatus.Text;
                em.Image = ImageToByteArray(image);
                me.Add(em);
                lblmsg.Text = "Added";
            }
            catch (Exception ex)
            {
                lblmsg.Text = ex.Message;
            }
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg) | *.jpg";
            //openFileDialog.OpenFile();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                image = new Bitmap(FileName);
                pictureBox1.Image = image;

            }
        }
        public byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        private void Add_employee_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
