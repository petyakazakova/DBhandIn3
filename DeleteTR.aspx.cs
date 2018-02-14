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
    public partial class DeleteTR : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["D_name"] != null && !Page.IsPostBack)
            {
                LabelMessageCRR.Text = Session["D_name"].ToString();
                UpdateGridview();
            }

            if (!Page.IsPostBack)
            {
                UpdateGridview();
                ButtonDeleteTR.Enabled = true;
            }

            DropDownListTR.AutoPostBack = true;
        }

        public void UpdateGridview()
        {

            SqlConnection conn = new SqlConnection(@"data source = .\sqlexpress; integrated security = true; database = Patient_dentist;");
            SqlCommand cmd = null;
            SqlDataReader rdr = null;

            try
            {
                conn.Open();

                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MySelectTR";

                SqlParameter in1 = cmd.Parameters.Add("@ID_treatment", SqlDbType.Int);
                in1.Direction = ParameterDirection.Input;
                in1.Value = Convert.ToInt32(Session["id"].ToString());

                rdr = cmd.ExecuteReader();

                GridViewUpdateTR.DataSource = rdr;
                GridViewUpdateTR.DataBind();

                rdr.Close();
                rdr = cmd.ExecuteReader();

                DropDownListTR.DataSource = rdr;
                DropDownListTR.DataTextField = "ID_treatment";
                DropDownListTR.DataValueField = "ID_treatment";
                DropDownListTR.DataBind();
                DropDownListTR.Items.Insert(0, "Select a treatment ID");
            }
            catch (Exception ex)
            {
                LabelMessageCRR.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        protected void ButtonDeleteTR_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source = .\sqlexpress; integrated security = true; database = Patient_dentist;");
            SqlCommand cmd = null;

            try
            {
                conn.Open();

                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MyDeleteTR";

                SqlParameter in1 = cmd.Parameters.Add("@ID_treatment", SqlDbType.Int);
                in1.Direction = ParameterDirection.Input;
                in1.Value = Convert.ToInt32(DropDownListTR.SelectedValue);

                cmd.ExecuteNonQuery();

                ButtonDeleteTR.Enabled = true;
                LabelMessageCRR.Text = "Treatment " + DropDownListTR.SelectedValue + " has been deleted";
            }
            catch (Exception ex)
            {
                LabelMessageCRR.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            UpdateGridview();
        }

        protected void DropDownListTR_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabelMessageCRR.Text = DropDownListTR.SelectedValue;
            if (DropDownListTR.SelectedIndex != 0)
            {
                LabelMessageCRR.Text = "You chose ID_treatment " + DropDownListTR.SelectedValue;
                ButtonDeleteTR.Enabled = true;
            }
            else
            {
                LabelMessageCRR.Text = "You chose none";
                ButtonDeleteTR.Enabled = false;
            }
        }

        protected void ButtonBackToTRAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("treatmentsDentist.aspx");
        }
    }
}