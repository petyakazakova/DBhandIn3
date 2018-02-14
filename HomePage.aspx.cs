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
    public partial class HomePage : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"data source = .\sqlexpress; integrated security = true; database = Patient_dentist;");
        SqlCommand cmd = null;
        SqlDataReader rdr = null;
        string sqlsel = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            RepeaterTreatment.DataBind();
            //LabelMessage.Text = Session["email"].ToString();
            LabelMessage.Text = "Everything looks good. No errors to worry about.. :)";
        }

        protected void ButtonCreatePatient_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateNewPatient.aspx");
        }

        public void ShowMyData()
        {
            try
            {
                conn.Open();

                cmd = new SqlCommand(sqlsel, conn);

                rdr = cmd.ExecuteReader();
                RepeaterTreatment.DataSource = rdr;
                RepeaterTreatment.DataBind();
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

        protected void ButtonShowAllTr_Click(object sender, EventArgs e)
        {
            sqlsel = "select * from Treatment";
            ShowMyData();
        }
    }
}