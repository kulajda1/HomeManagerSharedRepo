using HomeManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeManager.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_register_Click(object sender, EventArgs e)
        {
            UserRepo model = new UserRepo();
            User user = model.GetUserByUsername(txt_username.Text);
            if (user != null)
            {
                if (user.Password == txt_password.Text)
                {
                    User newuser = new User();
                    newuser.LoggedIn = true;

                    model.UpdateUser(user.ID, newuser);
                    Response.Redirect(@"~/View/Pages/HomePage.aspx");
                }
            }
            else if (txt_password.Text == "" || txt_username.Text == "")
            {
                lbl_login_errortext.Text = "A mezők kitöltése kötelező!";
            }
            else
            {
                lbl_login_errortext.Text = "A felhasználónév vagy jelszó nem megfelelő!";
            }
        }
    }
}