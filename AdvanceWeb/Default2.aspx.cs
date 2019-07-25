using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void submit_num_Click(object sender, EventArgs e)
    {
        int a = int.Parse(numFeild.Text);
        int b = a, pal = 0, main = 0;
        while (b > 0)
        {
            pal = b % 10;
            main = (main * 10)+pal;
            b = b / 10;
        }
        if (main == a)
        {
            show.Text = a+" number is a palandrom"+main;
        }
        else
        {
            show.Text = a + " number is not a palandrom" + main;
        }
    }
}