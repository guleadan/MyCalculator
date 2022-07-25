using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyCalculator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_Click(object sender, EventArgs e)
        {
            int fnum = Convert.ToInt32(firstNumber.Value);
            int snum = Convert.ToInt32(secondNumber.Value);
            if (ddl.SelectedValue=="Addition")
            {
                int ans = fnum + snum;
              //  answer.Text = Convert.ToString(ans);
            }
            else if (ddl.SelectedValue== "Subtraction")
            {
                int ans = fnum - snum;
               // answer.Text = Convert.ToString(ans);
            }
            else if (ddl.SelectedValue == "Multiplication")
            {
                int ans = fnum * snum;
               // answer.Text = Convert.ToString(ans);
            }
            else if (ddl.SelectedValue == "Division")
            {
                int ans = fnum / snum;
              //  answer.Text = Convert.ToString(ans);
            }
            Response.Redirect("WebForm2.aspx?firstNum=" + fnum + "&secNum=" + snum + "&ans=" + answer + "&operation="+ddl.SelectedValue);






        }
    }
}