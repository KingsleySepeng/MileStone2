using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace MileStone2
{
    class DataHandler
    {
        //  DataHandler() { }
        string con = "Data Source=DESKTOP-C2RP5S6;Initial Catalog=Project_DB;Integrated Security=True";
        //
        public DataTable SearchStudent(int id)
        {
            using (SqlConnection connection = new SqlConnection(con))
            {
                string SearchQuery = "SELECT * FROM Student WHERE StudentID =" + id;
                SqlCommand cmd = new SqlCommand(SearchQuery, connection);
                cmd.Parameters.AddWithValue("StudentID", id);

                DataTable dt = new DataTable();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    return dt;
                }
                connection.Close();
            }



        }
        public DataTable SearchModule(string code)
        {
            using (SqlConnection connection = new SqlConnection(con))
            {
                string SearchQuery = "SELECT * FROM Module WHERE ModuleCode =" + code;
                SqlCommand cmd = new SqlCommand(SearchQuery, connection);
                cmd.Parameters.AddWithValue("ModuelCode", code);
                connection.Open();
                DataTable dt = new DataTable();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    return dt;
                }
                connection.Close();
            }

        }

        //===========================================================================================

        public void CreateStudent(int id, string name, string surname, string DOB, string gender, string phone, string address, string module)
        { //choose image option
            using (SqlConnection connection = new SqlConnection(con))
            {
                string CreateQuery1 = "INSERT INTO Student(StudentID,FirstName,LastName,DOB,Gender,Phone,Address,ModuleCode)  VALUES(" + id + name + surname + DOB + gender + phone + address + module + ")";
                SqlCommand cmd1 = new SqlCommand(CreateQuery1, connection);
                cmd1.Parameters.AddWithValue("StudentID", id);
                cmd1.Parameters.AddWithValue("FirstName", name);
                cmd1.Parameters.AddWithValue("LastName", surname);
                cmd1.Parameters.AddWithValue("DOB", DOB);
                cmd1.Parameters.AddWithValue("Gender", gender);
                cmd1.Parameters.AddWithValue("Phone", phone);
                cmd1.Parameters.AddWithValue("Address", address);
                cmd1.Parameters.AddWithValue("ModuleCode", module);
                connection.Open();
                cmd1.ExecuteNonQuery();
                connection.Close();
            }

        }

        public void CreateModule(string module, string ModuleName, string Description, string link)
        { //choose image option
            using (SqlConnection connection = new SqlConnection(con))
            {
                string CreateQuery2 = "INSERT INTO Module(ModuleCode,Name,Description,Link)  VALUES(" + module + ModuleName + Description + link + ")";
                SqlCommand cmd1 = new SqlCommand(CreateQuery2, connection);
                cmd1.Parameters.AddWithValue("moduleCode", module);
                cmd1.Parameters.AddWithValue("Name", ModuleName);
                cmd1.Parameters.AddWithValue("Description", Description);
                cmd1.Parameters.AddWithValue("Link", link);
                cmd1.ExecuteNonQuery();
                connection.Close();
            }
        }

        //=================================================================================================
        public DataTable ReadStudent()
        {
            //use datatable
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            string ReadQuery = "SELECT * FROM Student";
            SqlDataAdapter cmd = new SqlDataAdapter(ReadQuery, connection);
            // SqlCommand cmd = new SqlCommand(ReadQuery,connection);

            DataTable dt = new DataTable();
            cmd.Fill(dt);
            return dt;




        }
        public DataTable ReadModule()
        {
            //use datatable
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            string ReadQuery = "SELECT * FROM Module";
            SqlDataAdapter cmd = new SqlDataAdapter(ReadQuery, connection);
            // SqlCommand cmd = new SqlCommand(ReadQuery,connection);

            DataTable dt = new DataTable();
            cmd.Fill(dt);
            return dt;

        }

        //=======================================================================================================
        public void UpdateStudent(int id, string name, string surname, string gender, string phone, string address, string module)
        {
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            string UpdateQuery1 = "UPDATE student SET FirstName = , LastName = , Gender =, Phone = , Address = , ModuleCode = , WHERE StudentID = ";
            SqlCommand cmd1 = new SqlCommand(UpdateQuery1, connection);
            cmd1.Parameters.AddWithValue("StudentID", id);
            cmd1.Parameters.AddWithValue("FirstName", name);
            cmd1.Parameters.AddWithValue("LastName", surname);
            
            cmd1.Parameters.AddWithValue("Gender", gender);
            cmd1.Parameters.AddWithValue("Phone", phone);
            cmd1.Parameters.AddWithValue("Address", address);
            cmd1.Parameters.AddWithValue("ModuleCode", module);
            cmd1.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateModule(string module, string ModuleName, string Description, string link)
        {
            SqlConnection connection = new SqlConnection(con);
            connection.Open();

            string UpdateQuery2 = "UPDATE Module SET ModuleCode=, Name = , Description = , Link =   WHERE ModuleCode = ";
            SqlCommand cmd1 = new SqlCommand(UpdateQuery2, connection);
            cmd1.Parameters.AddWithValue("moduleCode", module);
            cmd1.Parameters.AddWithValue("Name", ModuleName);
            cmd1.Parameters.AddWithValue("Description", Description);
            cmd1.Parameters.AddWithValue("Link", link);
            cmd1.ExecuteNonQuery();
            connection.Close();
        }
        //=========================================================================================================
        public void DeleteStudent(int id)
        {
            using (SqlConnection connection = new SqlConnection(con))
            {
                string DeleteQuery = "DELTET FROM Student WHERE StudentID =" + id;
                SqlCommand cmd = new SqlCommand(DeleteQuery, connection);
                cmd.Parameters.AddWithValue("StudentID", id);
                cmd.ExecuteNonQuery();
                connection.Close();
            }


        }

        public void DeleteModule(string Code)
        {
            using (SqlConnection connection = new SqlConnection(con))
            {
                string DeleteQuery = "DELTE FROM Student WHERE StudentID =" + Code;
                SqlCommand cmd = new SqlCommand(DeleteQuery, connection);
                cmd.Parameters.AddWithValue("ModuleCode", Code);
                cmd.ExecuteNonQuery();
                connection.Close();
            }

        }
    }
}
