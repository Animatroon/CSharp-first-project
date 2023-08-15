using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPorject
{
    public class Teacher
    {
        public string teacher_firstname { get; set; }
        public string teacher_lastname { get; set; }
        public string teacher_birthland { get; set; }
        public string teacher_nation { get; set; }
        public int teacher_age { get; set; }
        public string teacher_gender { get; set; }
        public string teacher_faculty { get; set; }
        public string teacher_language { get; set; }
        public string teacher_spec { get; set; }
        public string teacher_group { get; set; }
        public int teacher_groupNumber { get; set; }
        public string teacher_number { get; set; }
        public string teacher_email { get; set; }
        public string teacher_password { get; set; }
        public string teacher_education { get; set; }
        public int teacher_experience { get; set; }

        public Teacher(string firstName, string lastName, string birthland, string nation, int age, string gender, string faculty, string language, string spec, string group, int groupNumber, string number, string email, string password, string education, int experience)
        {
            teacher_firstname = firstName;
            teacher_lastname = lastName;
            teacher_birthland = birthland;
            teacher_nation = nation;
            teacher_age = age;
            teacher_gender = gender;
            teacher_faculty = faculty;
            teacher_language = language;
            teacher_spec = spec;
            teacher_group = group;
            teacher_groupNumber = groupNumber;
            teacher_number = number;
            teacher_email = email;
            teacher_password = password;
            teacher_education = education;
            teacher_experience = experience;
        }
    }

    internal class DBTeacher
    {
        public static MySqlConnection GetConnection()
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=univer";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySqlConnection Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return connection;
        }

        public static void InsertTeacherData(Teacher teacher)
        {
            string query = "INSERT INTO teacher (teacher_firstname, teacher_lastname, teacher_birthland, teacher_nation, teacher_age, teacher_gender, teacher_faculty, teacher_language, teacher_spec, teacher_group, teacher_groupNumber, teacher_number, teacher_email, teacher_password, teacher_education, teacher_experience) VALUES (@FirstName, @LastName, @Birthland, @Nation, @Age, @Gender, @Faculty, @Language, @Spec, @Group, @GroupNumber, @Number, @Email, @Password, @Education, @Experience)";

            using (MySqlConnection connection = GetConnection())
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@FirstName", teacher.teacher_firstname);
                command.Parameters.AddWithValue("@LastName", teacher.teacher_lastname);
                command.Parameters.AddWithValue("@Birthland", teacher.teacher_birthland);
                command.Parameters.AddWithValue("@Nation", teacher.teacher_nation);
                command.Parameters.AddWithValue("@Age", teacher.teacher_age);
                command.Parameters.AddWithValue("@Gender", teacher.teacher_gender);
                command.Parameters.AddWithValue("@Faculty", teacher.teacher_faculty);
                command.Parameters.AddWithValue("@Language", teacher.teacher_language);
                command.Parameters.AddWithValue("@Spec", teacher.teacher_spec);
                command.Parameters.AddWithValue("@Group", teacher.teacher_group);
                command.Parameters.AddWithValue("@GroupNumber", teacher.teacher_groupNumber);
                command.Parameters.AddWithValue("@Number", teacher.teacher_number);
                command.Parameters.AddWithValue("@Email", teacher.teacher_email);
                command.Parameters.AddWithValue("@Password", teacher.teacher_password);
                command.Parameters.AddWithValue("@Education", teacher.teacher_education);
                command.Parameters.AddWithValue("@Experience", teacher.teacher_experience);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error while inserting teacher data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            connection.Close();
            }
        }

        public static bool AutorizationTeacherValid(string email, string password)
        {
            string query = "SELECT COUNT(*) FROM teacher WHERE teacher_email = @Email AND teacher_password = @Password";

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error while fetching teacher data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
            }

            return false;
        }
    }
}