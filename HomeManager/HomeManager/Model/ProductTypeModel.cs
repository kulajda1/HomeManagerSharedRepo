using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeManager.Model
{
    public class ProductTypeModel
    {
        public string InsertProductType(ProductType productType)
        {
            try
            {
                HomeManagerEntities db = new HomeManagerEntities();
                db.ProductType.Add(productType);
                db.SaveChanges();

                return productType.Name + " sikeresen felvéve a termékkategóriák közé!";
            }
            catch (Exception e)
            {

                return "A termékkategória hozzáadása sikertelen. \nHibaüzenet: " + e;
            }
        }

        public string UpdateProductType(int id, ProductType newproductType)
        {
            try
            {
                HomeManagerEntities db = new HomeManagerEntities();
                ProductType productType = db.ProductType.Find(id);
                productType.Name = newproductType.Name;
                db.SaveChanges();

                return productType.Name + " termékkategória adatai sikeresen megváltoztatva!";
            }
            catch (Exception e)
            {

                return "A termékkategória módosítása sikertelen. \nHibaüzenet: " + e;
            }
        }

        public string DeleteProductType(int id)
        {
            try
            {
                HomeManagerEntities db = new HomeManagerEntities();
                ProductType productType = db.ProductType.Find(id);

                db.ProductType.Attach(productType);
                db.ProductType.Remove(productType);
                db.SaveChanges();

                return productType.Name + " sikeresen törölve a termékkategóriák közül!";
            }
            catch (Exception e)
            {
                return "A termékkategória törlése sikertelen. \nHibaüzenet: " + e;
            }
        }

        public ProductType GetProductType(int id)
        {
            try
            {
                using (HomeManagerEntities db = new HomeManagerEntities())
                {
                    ProductType productType = db.ProductType.Find(id);
                    return productType;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<ProductType> GetAllProductTypes()
        {
            try
            {
                using (HomeManagerEntities db = new HomeManagerEntities())
                {
                    List<ProductType> productTypes = (from x in db.ProductType
                                              select x).ToList();
                    return productTypes;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}