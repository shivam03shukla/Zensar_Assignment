using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] str = new string[] { "select", "jalebi", "samosa", "kachori", };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/pics/" + str + ".jpg";
        }
        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            TextBox1.Text = DropDownList1.SelectedIndex.ToString();
            if (DropDownList1.Text == "jalebi")
            {
                TextBox1.Text = "Rs 150";
            }
            else if (DropDownList1.Text == "kachori")
            {
                TextBox1.Text = "Rs 12";
            }

            else
            {
                TextBox1.Text = "Rs 12";
            }

        }

    }
}