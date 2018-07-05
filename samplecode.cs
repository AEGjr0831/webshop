using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class paypal : System.Web.UI.Page
{

    public static double total = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        string s = "SELECT * FROM tbltrans";
        SqlCommand scmd = new SqlCommand(s, Class1.con);
        SqlDataAdapter da = new SqlDataAdapter(scmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        //dt.Columns.Add("prodid", typeof(string));
        //dt.Columns.Add("ProdName", typeof(string));
        //dt.Columns.Add("TotalPrice", typeof(string));


        for (int i = 1; i <= Variable.ctr; i++)
        {
            dt.Rows.Add(Session["RcptID"], "User", Session["TotalPrice"]);
            total = Convert.ToDouble(Session["TotalPrice"].ToString());
        }

        //DataList1.DataSource = dt;
        //DataList1.DataBind();

        Class1.con.Open();
        int USER = 1;
        string del2 = "Delete FROM tblcart WHERE [User] = '" + USER + "'";
        SqlCommand cmdd2 = new SqlCommand(del2, Class1.con);
        //SqlDataAdapter da = new SqlDataAdapter(cmdd2);
        //DataTable dt = new DataTable();
        //da.Fill(dt);
        cmdd2.ExecuteNonQuery();
        Class1.con.Close();

    }
    protected void Searchbox_TextChanged(object sender, EventArgs e)
    {

    }
    protected void BtnSearch_Click(object sender, EventArgs e)
    {

    }
    protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {

    }
    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {

    }
}
