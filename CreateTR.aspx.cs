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
    public partial class CreateTR : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonBackToTRAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("treatmentsDentist.aspx");
        }

        protected void ButtonCreateTR_Click(object sender, EventArgs e)
        {
            //Create conn
            SqlConnection conn = new SqlConnection(@"data source = .\sqlexpress; integrated security = true; database = Patient_dentist;");
            SqlDataAdapter da = null;
            DataSet ds = null;
            DataTable dt = null;
            SqlCommand cmd = null;

            //Retrieve data
            string sqlsel = "SELECT * from Treatment";
            //INSERT INTO 
            string sqlins = "INSERT into Treatment values (@Number, @Name, @Price, @Image)"; //in correct order

            try
            {
                da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(sqlsel, conn);

                ds = new DataSet();
                da.Fill(ds, "MyTreatments");

                dt = ds.Tables["MyTreatments"];

                DataRow newrow = dt.NewRow(); //we get an empty row for our table here so we can use it after to insert
                newrow["Name"] = TextBoxCreateTRName.Text;
                newrow["Price"] = TextBoxCreateTRPrice.Text;
                newrow["Number"] = TextBoxCreateTRNumber.Text;
                newrow["Image"] = TextBoxCreateTRImage.Text;


                dt.Rows.Add(newrow); //attach this new row to the existing table

                cmd = new SqlCommand(sqlins, conn);
                cmd.Parameters.Add("@Name", SqlDbType.Text, 50, "Name"); //@Name -param case sensitive, Name - db colomn
                cmd.Parameters.Add("@Price", SqlDbType.Decimal, 50, "Price");
                cmd.Parameters.Add("@Number", SqlDbType.Int, 50, "Number");
                cmd.Parameters.Add("@Image", SqlDbType.Text, 50, "Image");

                da.InsertCommand = cmd;
                da.Update(ds, "MyTreatments");

                LabelMessageCreateTR.Text = "Treatment added";

            }
            catch (Exception ex)
            {
                LabelMessageCreateTR.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}