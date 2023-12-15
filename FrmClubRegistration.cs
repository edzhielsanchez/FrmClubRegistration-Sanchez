using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmClubRegistration_Sanchez
{
    public partial class FrmClubRegistration : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery;
        private int ID, Age, Count;
        private string FirstName, MiddleName, LastName, Gender, Program;
        private long StudentId;

        private void FrmClubRegistration_Load(object sender, EventArgs e)
        {
            List<string> programs = new List<string>
            {
                "BS in Information Technology",
                "BS in Computer Science",
                "BS in Information Systems",
                "BS in Computer Engineering",
                "BS in Hospitality Management",
                "BB in Tourism Management"
            };

            cbProgram.Items.AddRange(programs.ToArray());

            List<string> genders = new List<string>
            {
                "Female",
                "Male",
                "Others"
            };

            cbGender.Items.AddRange(genders.ToArray());

            clubRegistrationQuery = new ClubRegistrationQuery();
            RefreshListOfClubMembers();
        }

        void RefreshListOfClubMembers()
        {
            clubRegistrationQuery.DisplayList();
            dgvList.DataSource = clubRegistrationQuery.bindingSource;
        }

        int RegistrationID()
        {
            Count += 1;
            return Count;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            StudentId = long.Parse(tbStudentID.Text);
            FirstName = tbFirstName.Text;
            MiddleName = tbMiddleName.Text;
            LastName = tbLastName.Text;
            Age = Convert.ToInt32(tbAge.Text);
            Gender = cbGender.Text;
            Program = cbProgram.Text;
            clubRegistrationQuery.RegisterStudent(RegistrationID(), StudentId, FirstName, MiddleName, LastName, Age, Gender, Program);
            RefreshListOfClubMembers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmUpdateMember openform = new FrmUpdateMember();
            openform.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshListOfClubMembers();
        }

        public FrmClubRegistration()
        {
            InitializeComponent();
        }
    }
}
