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
        Problem1();
        Problem2();
        Problem3();
    }

    // 1. Reverse your name
    private void Problem1()
    {
        string name = "Johnny Olson";
        string output = new string(name.ToCharArray().Reverse().ToArray());

        ResultLabel1.Text = output;
    }

    // 2. Reverse this seqeunce
    private void Problem2()
    {
        string names = "Luke,Leia,Han,Chewbacca";

        string[] splitNames = names.Split(',');
        string output = "";

        for (var i = 0; i < splitNames.Length; i++)
        {
            output += splitNames[splitNames.Length - 1 - i];
            if (!(i == splitNames.Length - 1)) output += ",";
        }
        ResultLabel2.Text = output;
    }


    // 3. Use the sequence to create ASCII art
    // 14 chars with *****s on either side
    private void Problem3()
    {
        string names = "Luke,Leia,Han,Chewbacca";
        string[] splitNames = names.Split(',');
        string output = "";
        const int artLength = 14;

        // Count number of chars
        // 14 minus number of chars
        // divide result by 2 
        // add divided result plus length of string
        // pad left with that total
        // pad the new string to the right with 14

        for (var i = 0; i < splitNames.Length; i++)
        {
            splitNames[i] = splitNames[i].PadLeft(((artLength - splitNames[i].Length) / 2) + splitNames[i].Length, '*');
            splitNames[i] = splitNames[i].PadRight(artLength, '*');
            output += splitNames[i] + "<br />";
        }

        ResultLabel3.Text = output;
    }

    private void Problem4()
    {

    }
}