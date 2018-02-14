using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient; //data provider for sql

namespace DBHandIn3
{
    public partial class treatmentsDentist : System.Web.UI.Page
    {
        //create connection: new object
        SqlConnection conn = new SqlConnection(@"data source = .\sqlexpress; integrated security = true; database = Patient_dentist;");
        SqlCommand cmd = null;
        SqlDataReader rdr = null;
        //query
        string sqlsel = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            RepeaterTreatment.DataBind();
        }

        public void ShowMyData()
        {
            try
            {
                //Open connection
                conn.Open();

                //command
                cmd = new SqlCommand(sqlsel, conn);

                //ExecuteReader() returns a data reader (read rows)
                rdr = cmd.ExecuteReader();
                RepeaterTreatment.DataSource = rdr;
                RepeaterTreatment.DataBind();
            }
            catch (Exception ex)
            {
                //error handling 
                LabelMessage.Text = ex.Message;
            }
            finally
            {
                //Close conn
                conn.Close();
            }
        }

        protected void ButtonShowAllTr_Click(object sender, EventArgs e)
        {
            //SELECT
            sqlsel = "select * from Treatment";
            ShowMyData();
        }

        protected void ButtonCreateTr_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateTR.aspx");
        }

        protected void RepeaterTreatment_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void ButtonUpdateTr_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateTR.aspx");
        }

        protected void ButtonDeleteTr_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteTR.aspx");
        }

        protected void ButtonShowResAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("reservationsDentist.aspx");
        }

        protected void RepeaterTreatment_ItemCommand1(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}