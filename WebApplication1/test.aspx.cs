using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["user2"] != null && Request.Form["passwd2"] != null) 
            {
                if (Request.Form["user2"] == "jack002816" && Request.Form["passwd2"] == "jack216")
                {
                    Response.Redirect("https://5278.cc/forum.php?mod=viewthread&tid=1129533&extra=page%3D1%26filter%3Dauthor%26orderby%3Ddateline%26typeid%3D34");
                }
                else
                {
                    Response.Redirect("https://www.youtube.com/watch?v=f0Aj4KZzXrQ");
                }
            }
            else
            {
                Response.Write("乾她媽錯啦");
            }

        }
    }
}   