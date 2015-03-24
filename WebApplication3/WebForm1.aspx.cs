using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Insertbtn_Click(object sender, EventArgs e)
        {
            SqlDataSource1.InsertParameters["Date"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("dateTxt")).Text;
            SqlDataSource1.InsertParameters["Word"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("wordTxt")).Text;

            SqlDataSource1.Insert();
        }
    }
}