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
    public partial class createResPatient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //SESSION
            if (Session["Email"] != null)
            {
                LabelMessageCRR.Text = Session["Email"].ToString();
                UpdateGridview();
            }

            if (!Page.IsPostBack)
            {
                ButtonUpdateRes.Enabled = false;
            }
        }

        //CREATE
        protected void ButtonCreateRes_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source = .\sqlexpress; integrated security = true; database = Patient_dentist;");
            //sql command object
            SqlCommand cmd = null;

            try
            {
                conn.Open();

                //EXECUTE NON-QUERY METHOD create

                cmd = conn.CreateCommand();
                //specify that the command object is for executing a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MyCreateRes";

                //prepare params for SP execution 
                SqlParameter in1 = cmd.Parameters.Add("@ID_patient", SqlDbType.Int); // passing data to SP
                in1.Direction = ParameterDirection.Input;
                in1.Value = Convert.ToInt32(TextBoxPatID.Text);

                SqlParameter in2 = cmd.Parameters.Add("@ID_treatment", SqlDbType.Int);
                in2.Direction = ParameterDirection.Input;
                in2.Value = Convert.ToInt32(TextBoxTrID.Text);

                SqlParameter in3 = cmd.Parameters.Add("@Date", SqlDbType.DateTime);
                in3.Direction = ParameterDirection.Input;
                in3.Value = Convert.ToDateTime(TextBoxResDate.Text);

                cmd.ExecuteNonQuery();

                LabelMessageCRR.Text = "Reservation added.";
            }
            catch (Exception ex)
            {
                LabelMessageCRR.Text = ex.Message + ex.StackTrace;
            }
            finally
            {
                conn.Close();
            }
        }

        //SELECT
        public void UpdateGridview()
        {
            SqlConnection conn = new SqlConnection(@"data source = .\sqlexpress; integrated security = true; database = Patient_dentist;");
            SqlCommand cmd = null;
            //data reader
            SqlDataReader rdr = null;

            try
            {
                conn.Open();

                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MySelectAllRes";


                SqlParameter in1 = cmd.Parameters.Add("@ID_patient", SqlDbType.Int);
                in1.Direction = ParameterDirection.Input;
                in1.Value = Convert.ToInt32(Session["id"].ToString());

                //ExecuteReader -> access results
                rdr = cmd.ExecuteReader();

                GridViewUpdateRes.DataSource = rdr;
                GridViewUpdateRes.DataBind(); //withought databind wont display anything
            }
            catch (Exception ex)
            {
                LabelMessageCRR.Text = ex.Message + ex.StackTrace;
            }
            finally
            {
                conn.Close();
            }
        }

        //UPDATE
        protected void ButtonUpdateRes_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source = .\sqlexpress; integrated security = true; database = Patient_dentist;");
            SqlCommand cmd = null;

            try
            {
                conn.Open();

                //NON-QUERY METHOD update

                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MyUpdateRes";

                SqlParameter in1 = cmd.Parameters.Add("@ID_res", SqlDbType.Int);
                in1.Direction = ParameterDirection.Input;
                in1.Value = Convert.ToInt32(GridViewUpdateRes.SelectedRow.Cells[2].Text);

                SqlParameter in2 = cmd.Parameters.Add("@ID_patient", SqlDbType.Int);
                in2.Direction = ParameterDirection.Input;
                in2.Value = Convert.ToInt32(TextBoxPatID.Text);

                SqlParameter in3 = cmd.Parameters.Add("@ID_treatment", SqlDbType.Int);
                in3.Direction = ParameterDirection.Input;
                in3.Value = Convert.ToInt32(TextBoxTrID.Text);

                SqlParameter in4 = cmd.Parameters.Add("@Date", SqlDbType.DateTime);
                in4.Direction = ParameterDirection.Input;
                in4.Value = Convert.ToDateTime(TextBoxResDate.Text);


                cmd.ExecuteNonQuery();

                LabelMessageCRR.Text = "Reservation has been updated";
            }
            catch (Exception ex)
            {
                LabelMessageCRR.Text = ex.Message + ex.StackTrace;
            }
            finally
            {
                conn.Close();
            }

            UpdateGridview();
        }

        protected void ButtonDeleteRes_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteRes.aspx");
        }

        //UPDATE GRID VIEW
        protected void GridViewUpdateRes_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source = .\sqlexpress; integrated security = true; database = Patient_dentist;");
            SqlCommand cmd = null;
            SqlDataReader rdr = null;

            try
            {
                conn.Open();

                //NON-QUERY METHOD select

                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MySelectRes";

                SqlParameter in1 = cmd.Parameters.Add("@ID_patient", SqlDbType.Int);
                in1.Direction = ParameterDirection.Input;
                in1.Value = Convert.ToInt32(GridViewUpdateRes.SelectedRow.Cells[2].Text);
                

                rdr = cmd.ExecuteReader();

                rdr.Read();
                TextBoxPatID.Text = rdr.GetValue(1).ToString();

                rdr.Close();  // close before getting output parameter

                LabelMessageCRR.Text = "You have chosen Reservation ID: " + GridViewUpdateRes.SelectedRow.Cells[1].Text;
                ButtonUpdateRes.Enabled = true;
            }
            catch (Exception ex)
            {
                LabelMessageCRR.Text = ex.Message + ex.StackTrace;
            }
            finally
            {
                conn.Close();
            }
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}