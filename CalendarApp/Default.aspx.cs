using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalendarApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            lblResult1.Text = Calendar1.SelectedDate.ToShortDateString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lblResult1.Text = Calendar1.SelectedDate.ToLongDateString();


        }

        protected void btnSet_Click(object sender, EventArgs e)
        {
            Calendar1.SelectedDate = DateTime.Parse("6/4/2018");
            Calendar1.VisibleDate = Calendar1.SelectedDate;
        }

        protected void btnDiff_Click(object sender, EventArgs e)
        {
            if(Calendar1.SelectedDate > Calendar2.SelectedDate)
            {
                lblResult2.Text = Calendar1.SelectedDate.Subtract(Calendar2.SelectedDate).TotalDays.ToString();
            }
            else
            {
                lblResult2.Text = Calendar2.SelectedDate.Subtract(Calendar1.SelectedDate).TotalDays.ToString();
            }
        }
    }
}