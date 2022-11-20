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
    public partial class frm_Search_Student_Details : Form
    {
        public frm_Search_Student_Details()
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

        void Clear_Controls()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mobile_No.Clear();

            dtp_DOB.ResetText();
            cmb_Course.SelectedIndex = -1;
        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student obj = new frm_Add_New_Student();
            obj.Show();
            this.Hide();
        }

        private void btn_View_All_Student_List_Click(object sender, EventArgs e)
        {
            frm_View_All_Student_List obj = new frm_View_All_Student_List();
            obj.Show();
            this.Hide();
        }


        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            {
                Con_Open();
                SqlCommand Cmd = new SqlCommand("Select * From Student_Details where Roll_No = @RNo",Con);

                Cmd.Parameters.Add("RNo",SqlDbType.Int).Value = tb_Roll_No.Text;
                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Name.Text=Dr.GetString(Dr.GetOrdinal("Name"));
                    tb_Mobile_No.Text=(Dr["Mobile_No"].ToString());
                    dtp_DOB.Text=(Dr["DOB"].ToString());
                    cmb_Course.Text=Dr.GetString(Dr.GetOrdinal("Course"));
                }
                else
                {
                    MessageBox.Show("No Record Found","Invalid Roll No");
                    tb_Roll_No.Clear();
                }
                Con_Close();
            }
        }

        private void frm_Search_Student_Details_Load(object sender, EventArgs e)
        {
            lbl_Uname.Text=Shared_Class.Username;
            tb_Roll_No.Focus();
            tb_Name.Enabled=false;
            tb_Mobile_No.Enabled = false;
            dtp_DOB.Enabled=false;
            cmb_Course.Enabled=false;
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult Res=MessageBox.Show("Are You Sure..You Want To Logout???","LOGOUT",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(Res == DialogResult.Yes)
            {
                frm_Student_Login obj = new frm_Student_Login();
                obj.Show();
                this.Hide();
            }
        }
  
    }
}
