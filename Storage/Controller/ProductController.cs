using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage.Model;
using System.Data.Entity;
using System.ComponentModel;

namespace Storage.Controller
{
    public class ProductController
    {
        private List<Product> allProducts;
        private List<ProductType> productTypes;
        private List<Status> statuses;

        private StorageContext db;

        public ProductController()
        {
            db = new StorageContext();
            allProducts = db.Products.Include(x => x.ProductType).Include(x => x.Status).ToList();
            productTypes = db.ProductTypes.ToList();
            statuses = db.Statuses.ToList();
        }

        internal void AddProduct(string name, int productTypeId)
        {
            var productType = productTypes.Find(x => x.Id == productTypeId);
            var status = statuses.Find(x => x.Id == 1);
            var product = new Product(name, productType, status);
            db.Products.Add(product);
            db.SaveChanges();
            allProducts = db.Products.Include(x => x.ProductType).Include(x => x.Status).ToList();
        }

        internal void ChangeStatus(int productId, int statusId)
        {
            var status = statuses.Find(x => x.Id == statusId);
            var product = allProducts.Find(x => x.Id == productId);
            product.Status = status;
            product.StatusChangeTime = DateTime.Now;
            db.SaveChanges();
            allProducts = db.Products.Include(x => x.ProductType).Include(x => x.Status).ToList();
        }

        internal IBindingList GetProductsDataSource(int statusId = 0)
        {
            if (statusId == 0)
                return new BindingList<Product>(allProducts.ToList());
            return new BindingList<Product>(allProducts.Where(x => x.StatusId == statusId).ToList());
        }

        internal IBindingList FilterProductsDataSource(int statusId, DateTime begin, DateTime end)
        {
            if (statusId == 0)
                return new BindingList<Product>(allProducts.Where(x => x.StatusChangeTime.Date >= begin.Date && 
                                                                  x.StatusChangeTime.Date <= end.Date).ToList());
            return new BindingList<Product>(allProducts.Where(x => x.StatusId == statusId && 
                                                              x.StatusChangeTime >= begin && 
                                                              x.StatusChangeTime <= end.AddDays(1)).ToList());
        }

        internal IBindingList GetProductTypesDataSource()
        {
            return new BindingList<ProductType>(productTypes);
        }

        internal IBindingList GetStatusesDataSource()
        {
            var allStatus = new Status("Все");
            statuses.Insert(0, allStatus);
            return new BindingList<Status>(statuses);
        }

        internal void AddProductType(string text)
        {
            var productType = new ProductType(text);
            db.ProductTypes.Add(productType);
            db.SaveChanges();
            productTypes = db.ProductTypes.ToList();
        }

        
    }
}
