using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Service.Iservice;
using DAL;

namespace Service.Service
{
    public class ProductCategoryService : IProductCategoryService
    {
        public bool Delete(ProductCategoryModel model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int Id)
        {
            try
            {
                using (var _Context = new SalesTrackingSystemsEntities())
                {
                    var Data = _Context.ProductCategories.FirstOrDefault(a => a.ProductCategory_ID == Id);
                    _Context.ProductCategories.Remove(Data);
                    _Context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }


        public int GetId()
        {
            throw new NotImplementedException();
        }

        public ProductCategoryModel GetProductCategoryById(int Id)
        {
            try
            {
                using (var _Context = new SalesTrackingSystemsEntities())
                {
                    var Data = _Context.ProductCategories.Where(a => a.ProductCategory_ID == Id).Select(a => new ProductCategoryModel()
                    {
                        ProductCategory_ID = a.ProductCategory_ID,
                        ProductCategoryName = a.ProductCategoryName
                    }).FirstOrDefault();
                    return Data;

                }
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public List<ProductCategoryModel> listData()
        {
            try
            {
                using (var _Context = new SalesTrackingSystemsEntities())
                {
                    var Data = _Context.ProductCategories.Select(a => new ProductCategoryModel()
                    {
                        ProductCategory_ID = a.ProductCategory_ID,
                        ProductCategoryName = a.ProductCategoryName

                    }).ToList();
                    return Data;

                }
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public bool Save(ProductCategoryModel model)
        {
            try
            {
                using (var _Context = new SalesTrackingSystemsEntities())
                {
                    var SaveModel = new ProductCategory()
                    {
                        ProductCategory_ID = model.ProductCategory_ID,
                        ProductCategoryName = model.ProductCategoryName
                    };
                    _Context.ProductCategories.Add(SaveModel);
                    _Context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool Update(ProductCategoryModel model)
        {
            try
            {
                using (var _Context = new SalesTrackingSystemsEntities())
                {
                    var data = _Context.ProductCategories.FirstOrDefault(a => a.ProductCategory_ID == model.ProductCategory_ID);
                    if (data == null) return false;
                    data.ProductCategory_ID = model.ProductCategory_ID;
                    data.ProductCategoryName = model.ProductCategoryName;
                    _Context.SaveChanges();
                    return true;

                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}