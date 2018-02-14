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
    public partial class UpdateTR : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                ButtonUpdateTR.Enabled = false;
            }
            UpdateGridview();
        }

        public void UpdateGridview()  
        {
            SqlConnection conn = new SqlConnection(@"data source = .\sqlexpress; integrated security = true; database = Patient_dentist;");
            SqlDataAdapter da = null;
            DataSet ds = null;
            DataTable dt = null;

            //string sqlsel = "SELECT tr_name, tr_price, tr_date from all_treatments";
            string sqlsel = "SELECT * from Treatment";

            try
            {
                // conn.Open(); //SqlDataAdapter will open the connection by itself

                da = new SqlDataAdapter(); // da = data adapter
                da.SelectCommand = new SqlCommand(sqlsel, conn);

                ds = new DataSet();
                da.Fill(ds, "MyTreatments");

                dt = ds.Tables["MyTreatments"];

                GridViewUpdateTR.DataSource = dt;
                GridViewUpdateTR.DataBind();

            }
            catch (Exception ex)
            {
                LabelMessageUpdateTR.Text = ex.Message;
            }
            finally
            {
                conn.Close(); //SqlDataAdapter will close the connection by itself, but it can fail in case of errors
            }
        }

        protected void ButtonUpdateTR_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source = .\sqlexpress; integrated security = true; database = Patient_dentist;");
            SqlDataAdapter da = null;
            DataSet ds = null;
            DataTable dt = null;
            SqlCommand cmd = null;

            //Retrieve data
            string sqlsel = "select * from Treatment";
            //UPDATE
            string sqlupd = "UPDATE Treatment SET Name = @Name, Price = @Price, Number = @Number, Image = @Image WHERE ID_treatment =  @ID_treatment"; //Name-colomn in db, @Name is the parameter


            try
            {
                //conn.Open();

                da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(sqlsel, conn);

                ds = new DataSet();
                da.Fill(ds, "MyTreatments");

                dt = ds.Tables["MyTreatments"];
                //here we update the local version
                dt.Rows[GridViewUpdateTR.SelectedIndex]["Name"] = TextBoxUpdateTRName.Text;
                dt.Rows[GridViewUpdateTR.SelectedIndex]["Price"] = TextBoxUpdateTRPrice.Text;
                dt.Rows[GridViewUpdateTR.SelectedIndex]["Number"] = TextBoxUpdateTRNumber.Text;
                dt.Rows[GridViewUpdateTR.SelectedIndex]["Image"] = TextBoxUpdateTRImage.Text;


                cmd = new SqlCommand(sqlupd, conn);
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name");
                cmd.Parameters.Add("@Price", SqlDbType.Decimal, 50, "Price"); 
                cmd.Parameters.Add("@Number", SqlDbType.Int, 50, "Number");  
                cmd.Parameters.Add("@Image", SqlDbType.Text, 50, "Image");  
                SqlParameter parm = cmd.Parameters.Add("@ID_treatment", SqlDbType.Int, 4, "ID_treatment");
                parm.SourceVersion = DataRowVersion.Original; //for safety against updating the primary key

                da.UpdateCommand = cmd; // here we update the actual db on the server
                da.Update(ds, "MyTreatments");

                LabelMessageUpdateTR.Text = "Treatment has been updated";

            }
            catch (Exception ex)
            {
                LabelMessageUpdateTR.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            UpdateGridview();
        }

        protected void GridViewUpdateTR_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBoxUpdateTRName.Text = GridViewUpdateTR.SelectedRow.Cells[3].Text; //columN 0-is select it self, 1-id
            TextBoxUpdateTRPrice.Text = GridViewUpdateTR.SelectedRow.Cells[4].Text;
            TextBoxUpdateTRNumber.Text = GridViewUpdateTR.SelectedRow.Cells[2].Text;
            TextBoxUpdateTRImage.Text = GridViewUpdateTR.SelectedRow.Cells[5].Text;

            LabelMessageUpdateTR.Text = "You chose treatment ID " + GridViewUpdateTR.SelectedRow.Cells[1].Text;
            ButtonUpdateTR.Enabled = true;
        }

        protected void ButtonBackToTRAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("treatmentsDentist.aspx");
        }

        protected void TextBoxUpdateTRName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}