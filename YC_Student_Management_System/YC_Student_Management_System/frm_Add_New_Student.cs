using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YC_Student_Management_System
{
    public partial class frm_Add_New_Student : Form
    {
        public frm_Add_New_Student()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=YC_Student_Management_System_db;Integrated Security=True");
        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }

        }
        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }


        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }


        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey)))
            {
                e.Handled = true;
            }
        }

        int Auto_Incr()
        {
            int cnt = 0;
            Con.Open();
            SqlCommand Cmd = new SqlCommand();
            Cmd.CommandText = "Select Count(*) From Student_Details";

            cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (cnt > 0)
            {
                Cmd.CommandText = "Select Max(Roll_No) From Student_Details";
                cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }
            else
            {
                cnt = 101;
            }
            Con_Close();
            return cnt;
        }

        void Clear_Controls()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mobile_No.Clear();

            dtp_DOB.ResetText();
            cmb_Course.SelectedIndex = -1;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {  
            Con_Open();

            if (tb_Roll_No.Text != "" && tb_Name.Text != "" && tb_Mobile_No.TextLength == 10 && cmb_Course.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert into Student_Details(Roll_No,Name,DOB,Mobile_No,Course)values(@RNo,@Name,@DOB,@MNo,@Course)";


                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;
                Cmd.Parameters.Add("Name", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                Cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                Cmd.ExecuteNonQuery();


                MessageBox.Show("Record inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tb_Roll_No.Clear();
                tb_Name.Clear();
                tb_Mobile_No.Clear();
                dtp_DOB.ResetText();
                cmb_Course.SelectedIndex = -1;

            }
            else
            {
                MessageBox.Show("First fill all fields", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Con_Close();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Student_Login obj = new frm_Student_Login();
            obj.Show();
            this.Hide();
        }

        private void btn_View_All_Student_List_Click(object sender, EventArgs e)
        {
            frm_View_All_Student_List obj = new frm_View_All_Student_List();
            obj.Show();
            this.Hide();
        }

        private void btn_Search_Student_Details_Click(object sender, EventArgs e)
        {
            frm_Search_Student_Details obj = new frm_Search_Student_Details();
            obj.Show();
            this.Hide();   
        }

       
    }
}





