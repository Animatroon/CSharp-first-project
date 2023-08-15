using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace FinalPorject
{

    public class Student
    {
        public string student_firstName { get; set; }
        public string student_lastName { get; set; }
        public string student_birthland { get; set; }
        public string student_nation { get; set; }
        public int student_age { get; set; }
        public string student_gender { get; set; }
        public string student_faculty { get; set; }
        public string student_language { get; set; }
        public string student_spec { get; set; }
        public string student_group { get; set; }
        public int student_groupNumber { get; set; }
        public string student_phonenumber { get; set; }
        public string student_email { get; set; }
        public string student_password { get; set; }
        public int student_rating { get; set; }

        public Student(string firstName, string lastName, string birthland, string nation, int age, string gender, string faculty, string language, string spec, string group, int groupNumber, string phoneNumber, string email, string password, int rating = 0)
        {
            student_firstName = firstName;
            student_lastName = lastName;
            student_birthland = birthland;
            student_nation = nation;
            student_age = age;
            student_gender = gender;
            student_faculty = faculty;
            student_language = language;
            student_spec = spec;
            student_group = group;
            student_groupNumber = groupNumber;
            student_phonenumber = phoneNumber;
            student_email = email;
            student_password = password;
            student_rating = rating; 
        }
    }



    internal class DBStudent
    {
        public static MySqlConnection GetConnecton()
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


        public static void InsertStudentData(Student student)
        {
            string query = "INSERT INTO student (student_firstName, student_lastName, student_birthland, student_nation, student_age, student_gender, student_faculty, student_language, student_spec, student_group, student_groupNumber, student_phonenumber, student_email, student_password, student_rating) VALUES (@FirstName, @LastName, @Birthland, @Nation, @Age, @Gender, @Faculty, @Language, @Spec, @Group, @GroupNumber, @PhoneNumber, @Email, @Password, @Rating)";

            using (MySqlConnection connection = GetConnecton())
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@FirstName", student.student_firstName);
                command.Parameters.AddWithValue("@LastName", student.student_lastName);
                command.Parameters.AddWithValue("@Birthland", student.student_birthland);
                command.Parameters.AddWithValue("@Nation", student.student_nation);
                command.Parameters.AddWithValue("@Age", student.student_age);
                command.Parameters.AddWithValue("@Gender", student.student_gender);
                command.Parameters.AddWithValue("@Faculty", student.student_faculty);
                command.Parameters.AddWithValue("@Language", student.student_language);
                command.Parameters.AddWithValue("@Spec", student.student_spec);
                command.Parameters.AddWithValue("@Group", student.student_group);
                command.Parameters.AddWithValue("@GroupNumber", student.student_groupNumber);
                command.Parameters.AddWithValue("@PhoneNumber", student.student_phonenumber);
                command.Parameters.AddWithValue("@Email", student.student_email);
                command.Parameters.AddWithValue("@Password", student.student_password);
                command.Parameters.AddWithValue("@Rating", student.student_rating);

                try
                {
                    
                    command.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error while inserting student data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            connection.Close();
            }
            
        }

        public static bool AutorizationStudentValid(string email, string password)
        {
            string query = "SELECT COUNT(*) FROM student WHERE student_email = @Email AND student_password = @Password";

            using (MySqlConnection connection = GetConnecton())
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
                    MessageBox.Show("Error while fetching student data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
            }
            
            return false;
        }
        
        public void PostDataStudent(string email)
        {
            string path = @"C:\Users\jaiky\Downloads\FinalPorject\FinalPorject\localStorage\SQLdata.txt";
            using (StreamWriter file = File.CreateText(path))
            using (MySqlConnection connection = GetConnecton())
            {

                string query = $"SELECT * FROM student WHERE student_email = @Email";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            file.WriteLine(reader.GetString(reader.GetOrdinal("student_firstName")));
                            file.WriteLine(reader.GetString(reader.GetOrdinal("student_lastName")));
                            file.WriteLine(reader.GetString(reader.GetOrdinal("student_birthland")));
                            file.WriteLine(reader.GetString(reader.GetOrdinal("student_nation")));
                            file.WriteLine(reader.GetInt32(reader.GetOrdinal("student_age")));
                            file.WriteLine(reader.GetString(reader.GetOrdinal("student_gender")));
                            file.WriteLine(reader.GetString(reader.GetOrdinal("student_faculty")));
                            file.WriteLine(reader.GetString(reader.GetOrdinal("student_language")));
                            file.WriteLine(reader.GetString(reader.GetOrdinal("student_spec")));
                            file.WriteLine(reader.GetString(reader.GetOrdinal("student_group")));
                            file.WriteLine(reader.GetString(reader.GetOrdinal("student_groupNumber")));
                            file.WriteLine(reader.GetString(reader.GetOrdinal("student_email")));
                            file.WriteLine(reader.GetString(reader.GetOrdinal("student_password")));
                            file.WriteLine(reader.GetString(reader.GetOrdinal("student_rating")));
                        }



                        
                    }
                }
            }


        }

    }
}
