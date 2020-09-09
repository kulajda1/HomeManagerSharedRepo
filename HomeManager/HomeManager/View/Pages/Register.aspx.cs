using HomeManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeManager.View
{
    public partial class Register : System.Web.UI.Page
    {
        bool usernamematched = false;
        bool passwordmatched = false;
        bool lastnamematched = false;
        bool firstnamematched = false;
        bool birthdatematched = false;
        bool emailmatched = false;

        string passwordpattern = @"^(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9])[a-zA-Z\dáíűőüöúóéÁÍŰŐÖÜÚÓÉ]{8,20}$";
        string usernamepattern = @"^[a-zA-Z]{7,20}$";
        string namespatterntrue = @"^(?=.*?[A-Z])[a-zA-Z]{0,20}$";
        string namespatternfalse = @"\d";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_register_Click(object sender, EventArgs e)
        {
            UserRepo model = new UserRepo();
            User user = createUser();

            if (user != null)
            {
                lbl_result.Text = model.InsertUser(user);
                if (lbl_result.Text.Contains("sikeresen felvéve a felhasználók közé!"))
                {
                    Response.Redirect(@"~/View/Pages/HomePage.aspx");
                }
            }
        }

        private User createUser()
        {
            User user = new User();

            //USERNAME VALIDÁCIÓ

            if (Regex.IsMatch(txt_username.Text, usernamepattern))
            {
                usernamematched = true;
                user.Username = txt_username.Text;
                lbl_username_errortext.Text = "";
            }
            else if (txt_username.Text == "")
            {
                usernamematched = false;
                lbl_username_errortext.Text = "Kötelező kitölteni a mezőt!";
            }
            else
            {
                usernamematched = false;
                lbl_username_errortext.Text = "Hibás felhasználónév formátum!";
            }

            //PASSWORD VALIDÁCIÓ

            if (txt_password.Text == "")
            {
                passwordmatched = false;
                lbl_password_errortext.Text = "Kötelező kitölteni a mezőt!";
            }
            else if (txt_passwordagain.Text == "")
            {
                passwordmatched = false;
                lbl_passwordagain_errortext.Text = "Kötelező kitölteni a mezőt!";
            }
            else if (!Regex.IsMatch(txt_password.Text, passwordpattern))
            {
                passwordmatched = false;
                lbl_password_errortext.Text = "Nem megfelelő jelszóformátum!";
            }
            
            else if (txt_password.Text != txt_passwordagain.Text)
            {
                passwordmatched = false;
                lbl_passwordagain_errortext.Text = "Hibás jelszó, vagy a jelszavak nem egyeznek!";
            }
            else
            {
                user.Password = txt_password.Text;
                passwordmatched = true;
                lbl_password_errortext.Text = "";
                lbl_passwordagain_errortext.Text = "";
            }

            //LASTNAME VALIDÁCIÓ

            if (Regex.IsMatch(txt_lastname.Text, namespatterntrue) && !(Regex.IsMatch(txt_lastname.Text, namespatternfalse)))
            {
                lastnamematched = true;
                user.LastName = txt_lastname.Text;
                lbl_lastname_errortext.Text = "";
            }
            else if (txt_lastname.Text == "")
            {
                lastnamematched = false;
                lbl_lastname_errortext.Text = "Kötelező kitölteni a mezőt!";
            }
            else
            {
                lastnamematched = false;
                lbl_lastname_errortext.Text = "Hibás vezetéknévformátum!";
            }

            //FIRSTNAME VALIDÁCIÓ

            if (Regex.IsMatch(txt_firstname.Text, namespatterntrue) && !(Regex.IsMatch(txt_firstname.Text, namespatternfalse)))
            {
                firstnamematched = true;
                user.FirstName = txt_firstname.Text;
                lbl_firstname_errortext.Text = "";
            }
            else if (txt_firstname.Text == "")
            {
                firstnamematched = false;
                lbl_firstname_errortext.Text = "Kötelező kitölteni a mezőt!";
            }
            else
            {
                firstnamematched = false;
                lbl_firstname_errortext.Text = "Hibás keresztnévformátum!";
            }

            //EMAIL VALIDÁCIÓ

            if (Regex.IsMatch(txt_email.Text, @"\w"))
            {
                emailmatched = true;
                user.Email = txt_email.Text;
                lbl_email_errortext.Text = "";
            }
            else if (txt_email.Text == "")
            {
                emailmatched = false;
                lbl_email_errortext.Text = "Kötelező kitölteni a mezőt!";
            }
            else
            {
                emailmatched = false;
                lbl_email_errortext.Text = "Hibás e-mail cím formátum!";
            }

            //BIRTHDATE VALIDÁCIÓ

            if (txt_birthdate.Text == "")
            {
                lbl_birthdate_errortext.Text = "Kötelező kitölteni a mezőt!";
                birthdatematched = false;
            }
            else
            {
                try
                {
                    user.Birthdate = Convert.ToDateTime(txt_birthdate.Text);
                    lbl_birthdate_errortext.Text = "";
                    birthdatematched = true;
                }
                catch (Exception)
                {
                    lbl_birthdate_errortext.Text = "Hibás formátum!";
                }
            }
            
            if (usernamematched && passwordmatched && firstnamematched && lastnamematched && emailmatched && birthdatematched)
            {
                user.IsActive = true;
                return user;
            }
            else
            {
                return null;
            }
        }
    }
}