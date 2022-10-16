using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SGM_Student_Management_System
{
    public partial class frm_View_All_Student_List : Form
    {
        public frm_View_All_Student_List()
        {
            InitializeComponent();
        }

        private void frm_View_Student_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_Details_TabledbDataSet4.Student_App_Details' table. You can move, or remove it, as needed.
            this.student_App_DetailsTableAdapter1.Fill(this.student_Details_TabledbDataSet4.Student_App_Details);
           
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Student_Login obj = new frm_Student_Login();
            obj.Show();
            this.Hide();
        }

        
       
        

        

        
    }
}
