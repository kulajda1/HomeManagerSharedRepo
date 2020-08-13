using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeManager.Model
{
    public class AreaModel
    {
        public string InsertArea(Area area)
        {
            try
            {
                HomeManagerEntities db = new HomeManagerEntities();
                db.Area.Add(area);
                db.SaveChanges();

                return area.Name + " sikeresen felvéve a területek közé!";
            }
            catch (Exception e)
            {

                return "A terület hozzáadása sikertelen. \nHibaüzenet: " + e;
            }
        }

        public string UpdateArea(int id, Area newarea)
        {
            try
            {
                HomeManagerEntities db = new HomeManagerEntities();
                Area area = db.Area.Find(id);
                area.Name = newarea.Name;
                db.SaveChanges();

                return area.Name + " terület adatai sikeresen megváltoztatva!";
            }
            catch (Exception e)
            {

                return "A terület módosítása sikertelen. \nHibaüzenet: " + e;
            }
        }

        public string DeleteArea(int id)
        {
            try
            {
                HomeManagerEntities db = new HomeManagerEntities();
                Area area = db.Area.Find(id);

                db.Area.Attach(area);
                db.Area.Remove(area);
                db.SaveChanges();

                return area.Name + " sikeresen törölve a területek közül!";
            }
            catch (Exception e)
            {
                return "A terület törlése sikertelen. \nHibaüzenet: " + e;
            }
        }

        public Area GetArea(int id)
        {
            try
            {
                using (HomeManagerEntities db = new HomeManagerEntities())
                {
                    Area area = db.Area.Find(id);
                    return area;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Area> GetAllAreas()
        {
            try
            {
                using (HomeManagerEntities db = new HomeManagerEntities())
                {
                    List<Area> areas = (from x in db.Area
                                                      select x).ToList();
                    return areas;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}