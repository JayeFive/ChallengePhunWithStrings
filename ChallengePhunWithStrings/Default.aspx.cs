using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // 1. Reverse your name
        string name = "Johnny Olson";

        string output = new string(name.ToCharArray().Reverse().ToArray());
        ResultLabel1.Text = output;

        // 2. Reverse this seqeunce
        string names = "Luke,Leia,Han,Chewbacca";

        string[] splitNames = names.Split(',');
        string output2 = "";

        for (var i = 0; i < splitNames.Length; i++)
        {
            output2 += splitNames[splitNames.Length - 1 - i];
            if (!(i == splitNames.Length - 1)) output2 += ","; 
        }
        ResultLabel2.Text = output2;


    }
}