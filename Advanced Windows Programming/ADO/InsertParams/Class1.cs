using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Example from ADONETProgramming

namespace InsertParams
{
    class Class1
    {
        static void Main(string[] args)
        {
            // Create an instance of the class and call the method that actually does something
            Class1 oClass = new Class1();
            oClass.DoStuff();

            // Wait for user before closing application
            Console.WriteLine("\r\nPress enter to exit");
            Console.ReadLine();
        } // End Main

        /// <summary>Method that executes test code</summary>
        public void DoStuff()
        {
            // Build a connection string to connect to the ADONetSamples SQL Server database
            // string strConnect = "server=localhost;Initial Catalog=ADONetSamples;"
                // + "UID=sa;PWD=";
            string strConnect = "Data Source=localhost;Initial Catalog=IT215_Teachers;Integrated Security=True";
            SqlConnection conn = null;
            try
            {
                // Open the connection
                conn = new SqlConnection(strConnect);
                conn.Open();

                // Create a teacher with a null subject and insert
                Teacher teach1 = new Teacher("Mr. Sanchez", "H7", null);
                SaveTeachers(new Teacher[] { teach1 }, conn);

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Failed: {0}", ex.Message.ToString());
                Console.WriteLine("Failed: {0}", ex.ToString());
            }
            finally
            {
                // Must always close the connection when done
                if (conn != null)
                    conn.Close();
            }
        }

        /// <summary>Inserts teachers from array (handles nulls)</summary>
        /// <param name="aTeachers">Array of Teachers</param>
        /// <param name="conn">Connection to a SQL Server database</param>
        public void SaveTeachers(Teacher[] aTeachers, SqlConnection conn)
        {
            string strSQL = "INSERT INTO Teachers (TeacherName,Classroom,Subject) VALUES "
                + "(@TeacherName,@Classroom,@Subject)";
            SqlCommand comm = new SqlCommand(strSQL, conn);

            // Create parameters
            comm.Parameters.Add("@TeacherName", SqlDbType.Char, 30);
            comm.Parameters.Add("@Classroom", SqlDbType.Char, 10);
            comm.Parameters.Add("@Subject", SqlDbType.Char, 20);
            comm.Parameters["@Subject"].IsNullable = true;
            // Step through each teacher in turn
            comm.Prepare();
            foreach (Teacher t in aTeachers)
            {
                comm.Parameters["@TeacherName"].Value = t.TeacherName;
                comm.Parameters["@Classroom"].Value = t.Classroom;

                // Check for null subject
                if (t.Subject == null)
                    comm.Parameters["@Subject"].Value = DBNull.Value;
                else
                    comm.Parameters["@Subject"].Value = t.Subject;

                comm.ExecuteNonQuery();

                Console.Write("Inserted teacher {0}", t.TeacherName);
                if (t.Subject == null)
                    Console.Write(" (subject was null)");
                Console.WriteLine();
            }
        }
    }

    /// <summary>Simple class representing a teacher</summary>
    public class Teacher
    {
        private string m_strTeacherName = "";
        private string m_strClassroom = "";
        private string m_strSubject = "";

        /// <summary>Constructor that takes the details of the teacher as arguments</summary>
        /// <param name="strTeacherName">Name</param>
        /// <param name="strClassroom">Classroom</param>
        /// <param name="strSubject">Subject</param>
        public Teacher(string strTeacherName, string strClassroom, string strSubject)
        {
            m_strTeacherName = strTeacherName;
            m_strClassroom = strClassroom;
            m_strSubject = strSubject;
        }

        /// <summary>Name of the teacher</summary>
        public string TeacherName
        {
            get { return m_strTeacherName; }
            set { m_strTeacherName = value; }
        }

        /// <summary>Classroom</summary>
        public string Classroom
        {
            get { return m_strClassroom; }
            set { m_strSubject = value; }
        }

        /// <summary>Subject</summary>
        public string Subject
        {
            get { return m_strSubject; }
            set { m_strSubject = value; }
        }

    }
}
