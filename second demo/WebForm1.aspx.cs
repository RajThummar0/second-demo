﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace second_demo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {


  

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int a = Convert.ToInt32(TextBox1.Text);
            int b = int.Parse(TextBox2.Text);
            int sum = a + b;
            Response.Write("the sum is:" + sum);

        }
    }
}