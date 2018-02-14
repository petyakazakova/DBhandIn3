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
    public partial class reservationsDentist : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            //LabelMessageResDentist.Text = Session["D_name"].ToString();
            LabelMessage.Text = "Everything looks good. No errors to worry about.. :)";
            //RepeaterReservations.DataBind();


            if (!Page.IsPostBack)
            {
                UpdateGridView();
            }
        }

        public void UpdateGridView()
        {
            SqlConnection conn = new SqlConnection(@"data source = .\sqlexpress; integrated security = true; database = Patient_dentist;");
            SqlDataAdapter da = null;
            DataSet ds = null; //collection of tables (Used instead of a datareader)
            DataTable dt = null; // data tables inside the data set

            string sqlsel = "SELECT * from Reservation";

            try
            {
                //conn.Open(); SqlDataAdapter opens the connection itself

                da = new SqlDataAdapter(); // the new makes a new object
                da.SelectCommand = new SqlCommand(sqlsel, conn);

                ds = new DataSet();
                da.Fill(ds, "MyReservations"); // fills the dataset

                dt = ds.Tables["MyReservations"]; // we take the information from the dataset and inputs in the table

                GridViewReservations.DataSource = dt;
                GridViewReservations.DataBind();

                DropDownListPatient.DataSource = dt;
                DropDownListPatient.DataTextField = "ID_patient";
                DropDownListPatient.DataValueField = "ID_patient";
                DropDownListPatient.DataBind();
                DropDownListPatient.Items.Insert(0, "Select a patient");

                DropDownDate.DataSource = dt;
                DropDownDate.DataTextField = "Date";
                DropDownDate.DataValueField = "Date";
                DropDownDate.DataBind();
                DropDownDate.Items.Insert(0, "Select a date");

            }
            catch (Exception ex)
            {
                LabelMessage.Text = ex.Message;
            }
            finally
            {
                conn.Close(); //The SqlDataAdaptor closes connection by itself; but if something goes wrong, the DataAdaptor can not close the connection
            }
        } 

        protected void ButtonAllRes_Click(object sender, EventArgs e)
        {
            UpdateGridView();
        }

        protected void DropDownListPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownListPatient.SelectedIndex != 0)
            {
                SqlConnection conn = new SqlConnection(@"data source = .\sqlexpress; integrated security = true; database = Patient_dentist;");
                SqlDataAdapter da = null;
                SqlCommandBuilder cb = null;
                DataSet ds = null;
                DataTable dt = null;
                string sqlsel = "SELECT Patient.ID_patient, Treatment.Name, Reservation.Date, Reservation.Date FROM Patient, Treatment, Reservation WHERE Reservation.ID_treatment = Treatment.ID_treatment AND Reservation.ID_patient = Patient.ID_patient AND Patient.ID_patient = " + DropDownListPatient.SelectedValue;

                GridViewReservations.DataSource = dt;
                GridViewReservations.DataBind();

                //TextBox1.Text = DropDownList1.SelectedItem.Value;

                try
                {
                    //conn.Open(); SqlDataAdapter opens the connection itself

                    da = new SqlDataAdapter(); // the new makes a new object
                    da.SelectCommand = new SqlCommand(sqlsel, conn);

                    ds = new DataSet();
                    da.Fill(ds, "MyReservations"); // fills the dataset

                    dt = ds.Tables["MyReservations"]; // we take the information from the dataset and inputs in the table

                    GridViewReservations.DataSource = dt;
                    GridViewReservations.DataBind();


                }
                catch (Exception ex)
                {
                    LabelMessage.Text = ex.Message;
                }
                finally
                {
                    conn.Close();
                }
                //LabelMessage.Text = "You choose PatientID" + DropDownListPatient.SelectedValue; 
            }
            else
            {
                LabelMessage.Text = "You Choose none";
            }
        }

        protected void DropDownDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownListPatient.SelectedIndex != 0)
            {
                SqlConnection conn = new SqlConnection(@"data source = .\sqlexpress; integrated security = true; database = Patient_dentist");
                SqlDataAdapter da = null;
                SqlCommandBuilder cb = null;
                DataSet ds = null;
                DataTable dt = null;
                string sqlsel = "SELECT Reservation.Date, Treatment.Name, Patient.F_name, Patient.L_name FROM Reservation, Treatment, Patient WHERE Reservation.ID_treatment = Treatment.ID_treatment AND Reservation.ID_patient = Patient.ID_patient AND Reservation.Date = '" + DropDownDate.SelectedValue + "'";

                GridViewReservations.DataSource = dt;
                GridViewReservations.DataBind();

                //TextBox1.Text = DropDownList1.SelectedItem.Value;




                try
                {
                    //conn.Open(); SqlDataAdapter opens the connection itself

                    da = new SqlDataAdapter(); // the new makes a new object
                    da.SelectCommand = new SqlCommand(sqlsel, conn);

                    ds = new DataSet();
                    da.Fill(ds, "MyReservations"); // fills the dataset

                    dt = ds.Tables["MyReservations"]; // we take the information from the dataset and inputs in the table

                    GridViewReservations.DataSource = dt;
                    GridViewReservations.DataBind();


                }
                catch (Exception ex)
                {
                    LabelMessage.Text = ex.Message;
                }
                finally
                {
                    conn.Close();
                }
                //LabelMessage.Text = "You choose PatientID" + DropDownListPatient.SelectedValue; 
            }
            else
            {
                LabelMessage.Text = "You Choose none";
            }
        }
    }
}