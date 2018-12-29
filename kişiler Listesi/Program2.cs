using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kişiler_Listesi
{
    class Program2
    {
        string sql = "Data Source=.;Initial Catalog=test;Integrated Security=True";
        SqlConnection connect;
        SqlCommand con;

        
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        private string surname;
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        private string tel;

        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string adress;

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public Program2()
        {
            Name = "";
            Surname = "";
            Tel = "";
            Email = "";
            Adress = "";
            City = "";

        }
        public int ekle()
        {

            int sonuç = 0;
            try
            {
                connect = new SqlConnection(sql);
                con = new SqlCommand();
                con.Connection = connect;
                con.CommandType = CommandType.StoredProcedure;
                con.CommandText = "kisileriGetir";
                con.Parameters.AddWithValue("@name", Name);
                con.Parameters.AddWithValue("@surname", Surname);
                con.Parameters.AddWithValue("@tel", Tel);
                con.Parameters.AddWithValue("@email", Email);
                con.Parameters.AddWithValue("@adress", Adress);
                con.Parameters.AddWithValue("@city", City);
                connect.Open();
                sonuç = con.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ex.ToString();

            }

            finally { connect.Close(); }
            return sonuç;

        }

        public List<Program2> ekranaBas()
        {
            List<Program2> kisilistesi = new List<Program2>();
            connect = new SqlConnection(sql);
            con = new SqlCommand();
            con.Connection = connect;
            con.CommandType = CommandType.Text;
            con.CommandText = "select * from kişiler";

            connect.Open();
           

            SqlDataReader sr = con.ExecuteReader();

            while (sr.Read())
            {
                Program2 p = new Program2();
                p.Name = sr["Name"].ToString();
                p.Surname = sr["Surname"].ToString();
                p.Tel = sr["tel"].ToString();
                p.Email = sr["email"].ToString();
                p.Adress = sr["adress"].ToString();
                p.City = sr["city"].ToString();


                kisilistesi.Add(p);
            }
            connect.Close();

            return kisilistesi;
        }



    }
}

