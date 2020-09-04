using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeManager.Model
{
    public class ProductRepo
    {
        public string InsertProduct(Product product)
        {
            try
            {
                HomeManagerEntities db = new HomeManagerEntities();
                db.Product.Add(product);
                db.SaveChanges();

                return product.Name + " sikeresen felvéve a termékek közé!";
            }
            catch (Exception e)
            {

                return "A termék hozzáadása sikertelen. \nHibaüzenet: " + e;
            }
        }

        public string UpdateProduct(int id, Product newproduct)
        {
            try
            {
                HomeManagerEntities db = new HomeManagerEntities();
                Product product = db.Product.Find(id);
                product.Name = newproduct.Name;
                product.Image = newproduct.Image;
                product.Price = newproduct.Price;
                product.Description = newproduct.Description;
                product.AreaID = newproduct.AreaID;
                product.ProductTypeID = newproduct.ProductTypeID;
                product.Quantity = newproduct.Quantity;
                product.QuantityNeeded = newproduct.QuantityNeeded;
                db.SaveChanges();

                return product.Name + " termék adatai sikeresen megváltoztatva!";
            }
            catch (Exception e)
            {

                return "A termék módosítása sikertelen. \nHibaüzenet: " + e;
            }
        }

        public string DeleteProduct(int id)
        {
            try
            {
                HomeManagerEntities db = new HomeManagerEntities();
                Product product = db.Product.Find(id);

                db.Product.Attach(product);
                db.Product.Remove(product);
                db.SaveChanges();

                return product.Name + " sikeresen törölve a termékek közül!";
            }
            catch (Exception e)
            {
                return "A termék törlése sikertelen. \nHibaüzenet: " + e;
            }
        }

        public Product GetProduct(int id)
        {
            try
            {
                using (HomeManagerEntities db = new HomeManagerEntities())
                {
                    Product product = db.Product.Find(id);
                    return product;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Product> GetAllProducts()
        {
            try
            {
                using (HomeManagerEntities db = new HomeManagerEntities())
                {
                    List<Product> products = (from x in db.Product
                                        select x).ToList();
                    return products;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}