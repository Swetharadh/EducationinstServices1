using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientProject
{
    public partial class Searchpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client reference = new ServiceReference1.Service1Client();
            string region = txtregion.Text;
            ServiceReference1.EducationalInfo result = reference.GetEducationalDetails(region);
            lnlbtech.Text = string.Format("Total Btech College in {0} is {1}", region, result.BtechCollege);
            lnlmedical.Text = string.Format("Total Medical College in {0} is {1}", region, result.MedicalCollege);
            lblmba.Text = string.Format("Total MBA College in {0} is {1}", region, result.MbaCollege);

        }
    }
}