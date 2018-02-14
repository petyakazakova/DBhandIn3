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
    public partial class CreateNewPatient : System.Web.UI.Page
    {
        private string varToStore; //gender radiobuttons

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCreatePatient_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source = .\sqlexpress; integrated security = true; database = Patient_dentist;");
            SqlCommand cmd = null;

            try
            {
                conn.Open();

                //stored procedure
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MyNewPatient";

                SqlParameter in1 = cmd.Parameters.Add("@F_name", SqlDbType.Text);
                in1.Direction = ParameterDirection.Input;
                in1.Value = TextBoxPatientFName.Text;

                SqlParameter in2 = cmd.Parameters.Add("@L_name", SqlDbType.Text);
                in2.Direction = ParameterDirection.Input;
                in2.Value = TextBoxPatientLName.Text;

                SqlParameter in3 = cmd.Parameters.Add("@Age", SqlDbType.Int);
                in3.Direction = ParameterDirection.Input;
                in3.Value = Convert.ToUInt32(TextBoxPAge.Text);

                SqlParameter in4 = cmd.Parameters.Add("@CPR", SqlDbType.Int);
                in4.Direction = ParameterDirection.Input;
                in4.Value = Convert.ToUInt32(TextBoxCpr.Text);

                SqlParameter in5 = cmd.Parameters.Add("@Password", SqlDbType.Int);
                in5.Direction = ParameterDirection.Input;
                in5.Value = Convert.ToUInt32(TextBoxPatientPass.Text);

                SqlParameter in6 = cmd.Parameters.Add("@Confirm_p", SqlDbType.Int);
                in6.Direction = ParameterDirection.Input;
                in6.Value = Convert.ToUInt32(TextBoxPatientConfirm.Text);

                SqlParameter in7 = cmd.Parameters.Add("@Email", SqlDbType.Text);
                in7.Direction = ParameterDirection.Input;
                in7.Value = TextBoxPEmailCreate.Text;

                SqlParameter in8 = cmd.Parameters.Add("@Gender", SqlDbType.Text);
                in8.Direction = ParameterDirection.Input;
                in8.Value = varToStore;

                cmd.ExecuteNonQuery();

                LabelMessage.Text = "Patient added. Please login.";
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

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedValue == "Female")
            {
                varToStore = "Female";
            }
            else
            {
                varToStore = "Male";
            }
        }
    }
}