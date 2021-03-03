using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ui
{
    class Employeemng
    {
        private string strQuery;
        private string strTableName = "Employee";
        private string strConn;
        private string SERVER = "DESKTOP-R3F55TP";
        //Working
        //
        private string DATABASE = "PMS";
        private string USERID = "sa";
        private string PASSWORD = "Ahmedali";
        private SqlConnection con;
        private SqlCommand cmd;


        public Employeemng()
        {
            this.strConn = "server=" + this.SERVER + ";Database=" + this.DATABASE + ";User Id=" + this.USERID + ";Password=" + this.PASSWORD + ";";
            con = new SqlConnection(this.strConn);
        }

        public void Add(Employee obj)
        {
            strQuery = "insert into Employee values(@E_Name,@E_Nic,@E_status,@E_Salary,@E_picture) ";
            cmd = new SqlCommand(strQuery, con);
            cmd.CommandType = System.Data.CommandType.Text;
            try
            {
                con.Open();
                cmd.Parameters.AddWithValue("@E_Name", obj.Name);
                cmd.Parameters.AddWithValue("@E_Nic", obj.Nic);
                cmd.Parameters.AddWithValue("@E_status", obj.Status);
                cmd.Parameters.AddWithValue("@E_Salary", obj.Salary);
                cmd.Parameters.AddWithValue("@E_picture", obj.Image);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (SqlException ex)
            {

            }

        }


        public void Update(int id, Employee obj)
        {
            strQuery = "update Employee set E_Salary ='" + obj.Salary + "'where E_Id ='" + obj.ID + "'";

            try
            {
                con.Open();
                cmd = new SqlCommand(strQuery, con);
                //cmd.CommandText = strQuery;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException ex)
            {

            }
        }

        public void Delete(int id)
        {
            strQuery = "delete from " + this.strTableName + " where id = " + id + "";
            try
            {
                //cmd.CommandText = strQuery;
                cmd.CommandType = System.Data.CommandType.Text;
                con.Open();
                cmd = new SqlCommand(strQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException ex)
            {

            }

        }
        public List<Employee> getAll()
        {
            List<Employee> list = new List<Employee>();
            Employee rec;
            strQuery = "select * from " + this.strTableName + "";
            SqlDataReader dr;
            try
            {
                con.Open();
                cmd = new SqlCommand(strQuery, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    rec = new Employee();

                    rec.ID = dr.GetInt32(0);
                    rec.Name = dr.GetString(1);
                    rec.Nic = dr.GetString(2);
                    rec.Status = dr.GetString(3);
                    rec.Salary = dr.GetString(4);
                    //   rec.Image = dr.GetBytes(5);

                    list.Add(rec);
                }
                con.Close();
            }
            catch (SqlException ex)
            {

            }
            return list;
        }


    }
}
