using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPorject
{

        public class GetStudent
        {
            public int StudentId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Birthland { get; set; }
            public string Nation { get; set; }
            public int Age { get; set; }
            public string Gender { get; set; }
            public string Faculty { get; set; }
            public string Language { get; set; }
            public string Specialization { get; set; }
            public string Group { get; set; }
            public int GroupNumber { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public double Rating { get; set; }
        }

    public class StudentDataAccess
    {
        private string connectionString = "datasource=localhost;port=3306;username=root;password=;database=univer";

        public GetStudent GetStudentById(int studentId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT student_id, student_firstName, student_lastName, student_birthland, student_nation, student_age, student_gender, student_faculty, student_language, student_spec, student_group, student_groupNumber, student_phonenumber, student_email, student_password, student_rating FROM Students WHERE student_id = @studentId";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@studentId", studentId);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        GetStudent student = new GetStudent
                        {
                            StudentId = Convert.ToInt32(reader["student_id"]),
                            FirstName = reader["student_firstName"].ToString(),
                            LastName = reader["student_lastName"].ToString(),
                            Birthland = reader["student_birthland"].ToString(),
                            Nation = reader["student_nation"].ToString(),
                            Age = Convert.ToInt32(reader["student_age"]),
                            Gender = reader["student_gender"].ToString(),
                            Faculty = reader["student_faculty"].ToString(),
                            Language = reader["student_language"].ToString(),
                            Specialization = reader["student_spec"].ToString(),
                            Group = reader["student_group"].ToString(),
                            GroupNumber = Convert.ToInt32(reader["student_groupNumber"]),
                            PhoneNumber = reader["student_phonenumber"].ToString(),
                            Email = reader["student_email"].ToString(),
                            Password = reader["student_password"].ToString(),
                            Rating = Convert.ToDouble(reader["student_rating"])
                        };

                        reader.Close();
                        return student;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error while fetching student: " + ex.Message);
                }
            }

            return null;
        }

        public int GetStudentIdByEmail(string email)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT student_id FROM Students WHERE student_email = @email";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@email", email);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error while fetching student id: " + ex.Message);
                }
            }

            return -1; 
        }
        
    }

    
    // конец
}
