using HomeManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeManager.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_register_Click(object sender, EventArgs e)
        {
            UserRepo model = new UserRepo();
            User user = createUser(); 
        }

        private User createUser()
        {
            User user = new User();
            user.IsActive = true;
            user.Username = txt_username.Text;
            if (txt_password.Text == txt_passwordagain.Text)
            {
                user.Password = txt_password.Text;
            }

            return user;
        }
    }
}