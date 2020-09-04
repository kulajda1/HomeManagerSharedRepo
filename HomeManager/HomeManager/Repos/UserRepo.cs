using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Web;

namespace HomeManager.Model
{
    public class UserRepo
    {
        public string InsertUser(User user)
        {
            try
            {
                HomeManagerEntities db = new HomeManagerEntities();
                db.User.Add(user);
                db.SaveChanges();

                return user.Username + " sikeresen felvéve a felhasználók közé!";
            }
            catch (Exception e)
            {

                return "A felhasználó hozzáadása sikertelen. \nHibaüzenet: " + e;
            }
        }

        public string UpdateUser(int id, User newuser)
        {
            try
            {
                HomeManagerEntities db = new HomeManagerEntities();
                User user = db.User.Find(id);
                user.Name = newuser.Name;
                user.IsActive = newuser.IsActive;
                user.Password = newuser.Password;
                user.Username = newuser.Username;
                db.SaveChanges();

                return user.Username + " adatai sikeresen megváltoztatva!";
            }
            catch (Exception e)
            {

                return "A felhasználó módosítása sikertelen. \nHibaüzenet: " + e;
            }
        }
        
        public string DeleteUser(int id)
        {
            try
            {
                HomeManagerEntities db = new HomeManagerEntities();
                User user = db.User.Find(id);

                db.User.Attach(user);
                db.User.Remove(user);
                db.SaveChanges();

                return user.Username + " sikeresen törölve a felhasználók közül!";
            }
            catch (Exception e)
            {

                return "A felhasználó törlése sikertelen. \nHibaüzenet: " + e;
            }
        }

        public User GetUser(int id)
        {
            try
            {
                using (HomeManagerEntities db = new HomeManagerEntities())
                {
                    User user = db.User.Find(id);
                    return user;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<User> GetAllUsers()
        {
            try
            {
                using (HomeManagerEntities db = new HomeManagerEntities())
                {
                    List<User> users = (from x in db.User
                                        select x).ToList();
                    return users;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}