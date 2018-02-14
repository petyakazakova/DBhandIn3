using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

namespace DBHandIn3
{
    public partial class loginDentist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonLoginD_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source = .\sqlexpress; integrated security = true; database = Patient_dentist;");
            SqlCommand cmd = null;
            SqlDataReader rdr = null;

            try
            {
                conn.Open();

                // stored procedure             
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MyDentistLogin";

                SqlParameter in1 = cmd.Parameters.Add("@D_name", SqlDbType.Text);
                in1.Direction = ParameterDirection.Input;
                in1.Value = TextBoxDNameLogin.Text;

                SqlParameter in2 = cmd.Parameters.Add("@D_password", SqlDbType.Text);
                in2.Direction = ParameterDirection.Input;
                in2.Value = TextBoxLoginDpass.Text;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {

                    Session["D_name"] = in1.Value.ToString();
                    Session["id"] = rdr.GetValue(0).ToString();
                    string userlogged = HttpContext.Current.Session["D_name"].ToString();


                    AdminLoginErrorMessage.Text = "Login Sucess.." + Session["id"] + ".";
                    AdminLoginMessage.Text = "Currently Logged Admin is " + (userlogged != null ? userlogged : "Unknown user");
                    Response.Redirect("treatmentsDentist.aspx");
                }
                else
                {
                    AdminLoginErrorMessage.Text = "Admin User name & Password are not correct. Please, try again..";

                }

                //cmd.ExecuteNonQuery();

                //LabelMessage.Text = "You have successfully logged in.";
            }
            catch (Exception ex)
            {
                LabelMessage.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}