using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class test2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (user.Text == "jack002816" && passwd.Text == "jack216")
            {
                Response.Redirect("https://5278.cc/forum.php?mod=viewthread&tid=1129533&extra=page%3D1%26filter%3Dauthor%26orderby%3Ddateline%26typeid%3D34");
            }
            else
            {
                Response.Redirect("https://www.youtube.com/watch?v=Wnm9hg6EFfE&t=13s");
            }
        }

        protected void passwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}   