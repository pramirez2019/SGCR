using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsAddUser
{
    class imp_data
    {
        private static string connection = "Data Source=PATRICIO-PC; Initial Catalog=AdmConsorcios;User ID=sa;Password=;MultipleActiveResultSets=true";  //M.A.R.S.: Allows multiple activities to the DB at the same time. Private for security purposes any class outside this one can invoke it. Integrated Security =true for Windows Authentication
        public static SqlConnection con = new SqlConnection(connection);  //it's a class to open a sql connection. We need to invoke using system.data.sqlclient to use it 


        public void AddConsorcio(string cName, string cDomicilio, Int32 cCp, string cCuit,
            string cConsorCateg, string cSuthern, string cstatus)
        {
            try  //to avoid application crashin for logical errors. The application will continue running a showing a message only
            {
                SqlCommand cmd = new SqlCommand("st_insertConsorcio", con);  //we create a command, the store procedure and the connection here
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cname", cName);
                cmd.Parameters.AddWithValue("@cdomicilio", cDomicilio);
                cmd.Parameters.AddWithValue("@cp", cCp);
                cmd.Parameters.AddWithValue("@c_cuit", cCuit);
                cmd.Parameters.AddWithValue("@c_consorcio_categ", cConsorCateg);
                cmd.Parameters.AddWithValue("@c_suthern", cSuthern);
                cmd.Parameters.AddWithValue("@c_status", cstatus);
                con.Open();
                int x = cmd.ExecuteNonQuery();  //here we execute our query, we can use only create, update and delete queries. The value is assigned to x
                if (x > 0)
                {
                    MessageBox.Show(cName + " added succesfully into system");

                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        //Array with 6 dimensions to store the data
        string[] data = new string[6]; 
        public string[] GetConsorcio(string cCuit1)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_searchConsorcio", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(@"c_cuit", cCuit1);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                //HasRows is boolean method to validate if we have rows on DB
                if (dr.HasRows)  
                {
                    while (dr.Read())
                    {
                        data[0] = dr["Name"].ToString();
                        data[1] = dr["Domicilio"].ToString();
                        data[2] = dr["CP"].ToString();
                        data[3] = dr["Categoría"].ToString();
                        data[4] = dr["Suthern"].ToString();
                        data[5] = dr["status"].ToString();
                    }
                }
                else
                {

                    MessageBox.Show("Data not found");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }
        public void UpdateConsorcio(string cName, string cDomicilio, Int32 cCp, string cCuit, string cConsorCateg, string cSuthern, string cstatus)
        {
            try  //to avoid application crashing for logical errors. The application will continue running a showing a message only
            {
                SqlCommand cmd = new SqlCommand("st_updateConsorcio", con);  //we create a command, the store procedure and the connection here
                cmd.Parameters.AddWithValue("@c_cuit", cCuit);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cname", cName);
                cmd.Parameters.AddWithValue("@cdomicilio", cDomicilio);
                cmd.Parameters.AddWithValue("@cp", cCp);
                cmd.Parameters.AddWithValue("@c_consorcio_categ", cConsorCateg);
                cmd.Parameters.AddWithValue("@c_suthern", cSuthern);
                cmd.Parameters.AddWithValue("@c_status", cstatus);
                con.Open();
                int x = cmd.ExecuteNonQuery();  //here we execute our query, we can use only create, update and delete queries. The value is assigned to x
                if (x > 0)
                {
                    MessageBox.Show(cName + " Consorcio updated succesfully!");

                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteConsorcio(string cCuit)
        {
            try  //to avoid application crashing for logical errors. The application will continue running a showing a message only
            {
                SqlCommand cmd = new SqlCommand("st_deleteConsorcio", con);  //we create a command, the store procedure and the connection here
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@c_cuit", cCuit);
                con.Open();
                int x = cmd.ExecuteNonQuery();  //here we execute our query, we can use only create, update and delete queries. The value is assigned to x
                if (x > 0)
                {
                    MessageBox.Show(" Consorcio deleted succesfully from system");

                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        
        public void AddConsorcista(string cCuit, string cName, string cConsName, string cDomicilio, string cPhone, string cEmail,
            Int32 cCp, Int32 cUf, string cFd, Decimal cPorEx)
        {
            try  //to avoid application crashing for logical errors. The application will continue running a showing a message only
            {
                SqlCommand cmd = new SqlCommand("st_insertConsorcista", con);  //we create a command, the store procedure and the connection here
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pcuit", cCuit);
                cmd.Parameters.AddWithValue("@pname", cName);
                cmd.Parameters.AddWithValue("@pname_consorcio", cConsName);
                cmd.Parameters.AddWithValue("@pdomicilio", cDomicilio);
                cmd.Parameters.AddWithValue("@pphone", cPhone);
                cmd.Parameters.AddWithValue("@pemail", cEmail);
                cmd.Parameters.AddWithValue("@Pcp", cCp);
                cmd.Parameters.AddWithValue("@puf", cUf);
                cmd.Parameters.AddWithValue("@pfd", cFd);
                cmd.Parameters.AddWithValue("@pporexp", cPorEx);
                con.Open();
                int x = cmd.ExecuteNonQuery();  //here we execute our query, we can use only create, update and delete queries. The value is assigned to x
                if (x > 0)
                {
                    MessageBox.Show(cName + " added succesfully into system");

                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        string[] data2 = new string[10];
        public string[] GetConsorcista(string nameConsorcista)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_SearchConsorcista", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_name_consorcista", nameConsorcista);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                //HasRows is boolean method to validate if we have rows on DB
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        data2[0] = dr["CUIT"].ToString();
                        data2[1] = dr["NameConsorcista"].ToString();
                        data2[2] = dr["NameConsorcio"].ToString();
                        data2[3] = dr["Address"].ToString();
                        data2[4] = dr["Phone"].ToString();
                        data2[5] = dr["Email"].ToString();
                        data2[6] = dr["CP"].ToString();
                        data2[7] = dr["UF"].ToString();
                        data2[8] = dr["FD"].ToString();
                        data2[9] = dr["%Exp"].ToString();
                    }
                }
                else
                {

                    MessageBox.Show("Data not found");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data2;
        }


        /* string[] data1 = new string[3]; //I create an array with 6 dimensions to store the data
        public string[] GetUser(string uName, string uPass)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_validateuser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@uname", uName);
                cmd.Parameters.AddWithValue("@upassword", uPass);
                con.Open();
                SqlDataReader dr1 = cmd.ExecuteReader();
                if (dr1.HasRows)  //this is boolean method to validate if we have rows on DB
                {
                    while (dr1.Read())
                    {
                        data1[1] = dr1["Name"].ToString();
                        data1[2] = dr1["Password"].ToString();
                    }
                }
                else
                {

                    MessageBox.Show("user not found");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data1;
          
         }*/
        //Bool method to get user with user and password on database. This is for login button on login form  
        public bool GetUser(string uName, string uPass)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand cmd = new SqlCommand("st_validateuser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@uname", uName);
                cmd.Parameters.AddWithValue("@upassword", uPass);
                con.Open();
                SqlDataReader dr1 = cmd.ExecuteReader();
                if (dr1.HasRows)  //this is boolean method to validate if we have rows on DB
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                    //MessageBox.Show("user not found");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return isSuccess;
        }
        //Method to add a new category on database. This is for Add button on ABMCategoria form
        public void AddCategRubro(Int32 idCateg, string categName, string categDescrip)
        {
            try  //to avoid application crashin for logical errors. The application will continue running a showing a message only
            {
                SqlCommand cmd = new SqlCommand("st_InsertCategRubro", con);  //we create a command, the store procedure and the connection here
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_categ", idCateg);
                cmd.Parameters.AddWithValue("@cname_categ", categName);
                cmd.Parameters.AddWithValue("@cdescrip_categ", categDescrip);
                con.Open();
                int x = cmd.ExecuteNonQuery();  //here we execute our query, we can use only create, update and delete queries. The value is assigned to x
                if (x > 0)
                {
                    MessageBox.Show(categName + " added succesfully into system");

                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        string[] data1 = new string[3]; //I create an array with 6 dimensions to store the data

        //Method to find a category base on idcateg. This is for search button on ABMCategoria form
        public string[] GetCategoria(Int32 idCateg)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_searchCategRubro", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(@"id_categ", idCateg);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)  //this is boolean method to validate if we have rows on DB
                {
                    while (dr.Read())
                    {
                        data1[0] = dr["id_categ"].ToString();
                        data1[1] = dr["name categ"].ToString();
                        data1[2] = dr["descrip categ"].ToString();                    
                    }
                }
                else
                {

                    MessageBox.Show("Data not found");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data1;
        }
        // Method to update a service category. This is for update button on ABMCategoria form
        public void UpdateCategoria (Int32 idCateg, string categName, string categDescrip)
        {
            try  //to avoid application crashing for logical errors. The application will continue running a showing a message only
            {
                SqlCommand cmd = new SqlCommand("st_updateCategRubros", con);  //we create a command, the store procedure and the connection here
                cmd.Parameters.AddWithValue("@id_categ", idCateg);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cname_categ", categName);
                cmd.Parameters.AddWithValue("@cdescrip_categ", categDescrip);
                con.Open();
                int x = cmd.ExecuteNonQuery();  //here we execute our query, we can use only create, update and delete queries. The value is assigned to x
                if (x > 0)
                {
                    MessageBox.Show("Categoria " + categName + "updated succesfully!");

                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteCategoria(string categName)
        {
            try  //to avoid application crashing for logical errors. The application will continue running a showing a message only
            {
                SqlCommand cmd = new SqlCommand("st_deleteCategRubros", con);  //we create a command, the store procedure and the connection here
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cname", categName);
                con.Open();
                int x = cmd.ExecuteNonQuery(); 
                if (x > 0)
                {
                    MessageBox.Show(" Categoría deleted succesfully from system");

                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

    }
}
