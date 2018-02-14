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
    public partial class loginPatient : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"data source = .\sqlexpress; integrated security = true; database = Patient_dentist;");
        SqlCommand cmd = null;
        SqlDataReader rdr = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonLoginP_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MyPatientLogin";

                SqlParameter in1 = cmd.Parameters.Add("@Email", SqlDbType.Text);
                in1.Direction = ParameterDirection.Input;
                in1.Value = TextBoxPEmailLogIn.Text;

                SqlParameter in2 = cmd.Parameters.Add("@Pass", SqlDbType.Int);
                in2.Direction = ParameterDirection.Input;
                in2.Value = Convert.ToUInt32(TextBoxLoginPpass.Text);

                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {

                    Session["Email"] = in1.Value.ToString();
                    HttpContext.Current.Session["id"] = rdr.GetValue(0).ToString();
                    string userlogged = HttpContext.Current.Session["Email"].ToString();


                    PatientLoginErrorMessage.Text = "Login Success.." + Session["id"] + "...!!";
                    PatientLoginMessage.Text = "Currently Logged User is " + (userlogged ?? "Unknown user");
                    Response.Redirect("reservationsPatient.aspx");
                }
                else
                {
                    PatientLoginErrorMessage.Text = "Patient Email or Password is not correct, Please try again...";

                }

                //cmd.ExecuteNonQuery();

                LabelMessage.Text = "You have successfully logged in as our patient. Please, proceed to the log in page.";
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
