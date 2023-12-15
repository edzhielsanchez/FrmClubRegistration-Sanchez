using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmClubRegistration_Sanchez
{
    public partial class FrmUpdateMember : Form
    {
        public FrmUpdateMember()
        {
            InitializeComponent();
        }

        private int Age, Count;
        private long StudentId;
        private string FirstName, MiddleName, LastName, Gender, Program;

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE ClubMembers SET FirstName = @firstName, MiddleName = @middleName, LastName = @lastName, Age = @age, Gender = @gender, Program = @program WHERE StudentId = @ID";

            con.ConnectionString = sqlCon;
            using (con)
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@id", StudentId);
                    cmd.Parameters.AddWithValue("@firstName", tbFirstName_.Text);
                    cmd.Parameters.AddWithValue("@middleName", tbMiddleName_.Text);
                    cmd.Parameters.AddWithValue("@lastName", tbLastName_.Text);
                    cmd.Parameters.AddWithValue("@age", Convert.ToInt32(tbAge_.Text));
                    cmd.Parameters.AddWithValue("@gender", cbGender_.Text);
                    cmd.Parameters.AddWithValue("@program", cbProgram_.Text);

                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }

            MessageBox.Show("Success");
        }

        private void cbStudentID__SelectedIndexChanged(object sender, EventArgs e)
        {
            String query = "SELECT * FROM ClubMembers WHERE StudentID = @id";
            con.ConnectionString = sqlCon;
            using (con)
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", cbStudentID_.Text);

                    SqlDataReader get = cmd.ExecuteReader();
                    if (get.Read())
                    {
                        StudentId = get.GetInt64(1);
                        FirstName = get.GetString(2);
                        MiddleName = get.GetString(3);
                        LastName = get.GetString(4);
                        Age = get.GetInt32(5);
                        Gender = get.GetString(6);
                        Program = get.GetString(7);

                        fillData();
                        get.Close();
                    }
                }
                con.Close();
            }
        }


        SqlConnection con;

        String sqlCon;
      
        void fillData()
        {
            cbStudentID_.Text = StudentId.ToString();
            tbFirstName_.Text = FirstName;
            tbLastName_.Text = LastName;
            tbMiddleName_.Text = MiddleName;
            cbProgram_.Text = Program;
            tbAge_.Text = Age.ToString();
            cbGender_.Text = Gender;
        }

        private void FrmUpdateMember_Load(object sender, EventArgs e)
        {
            sqlCon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\MINER01\\source\\repos\\FrmClubRegistration-Sanchez\\ClubDB.mdf;Integrated Security=True";
            con = new SqlConnection(sqlCon);

            String query = "SELECT * FROM ClubMembers";

            con.ConnectionString = sqlCon;
            using (con)
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", cbStudentID_.Text);

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cbStudentID_.Items.Add(dr.GetInt64(1));
                    }
                    dr.Close();
                }
                con.Close();
            }

            List<string> programs = new List<string>
            {
                "BS in Information Technology",
                "BS in Computer Science",
                "BS in Information Systems",
                "BS in Computer Engineering",
                "BS in Hospitality Management",
                "BB in Tourism Management"
            };

            cbProgram_.Items.AddRange(programs.ToArray());

            List<string> genders = new List<string>
            {
                "Female",
                "Male",
                "Others"
            };

            cbGender_.Items.AddRange(genders.ToArray());
        }
    }
}