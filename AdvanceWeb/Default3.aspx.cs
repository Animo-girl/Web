using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button_submit_Click(object sender, EventArgs e)
    {
        if (cb1.Checked == true)
        {
            show_now.Text = nameEntry.Text;
            show_now.Font.Bold = true;
        }
        else {
            show_now.Text = nameEntry.Text;
            show_now.Font.Bold = false;
        }

        if (cb2.Checked == true)
        {
            show_now.Text = nameEntry.Text;
            show_now.Font.Italic = true;
        }
        else
        {
            show_now.Text = nameEntry.Text;
            show_now.Font.Italic = false;
        }

        if (cb3.Checked == true)
        {
            show_now.Text = nameEntry.Text;
            show_now.Font.Underline = true;
        }
        else
        {
            show_now.Text = nameEntry.Text;
            show_now.Font.Underline = false;
        }
    
    }
}