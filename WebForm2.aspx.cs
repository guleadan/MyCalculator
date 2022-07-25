using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyCalculator
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string fnum = Request["firstNum"];
            string snum = Request["secNum"];
            string ans = Request["answer"];
            string operation = Request["operation"];
            Response.Write("The " + operation + " of " + fnum + " and " + snum + " yields " + ans + ".");


        }
    }
}