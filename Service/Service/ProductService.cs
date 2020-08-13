using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Iservice;
using Model;
using DAL;

namespace Service.Service
{
    public class ProductService : IProductService
    {
        public bool Delete(ProductModel model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int Id)
        {
            try
            {
                using (var _Context=new SalesTrackingSystemsEntities())
                {
                    var Data = _Context.Products.FirstOrDefault(a => a.Product_ID == Id);
                    _Context.Products.Remove(Data);
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

        public ProductModel GetProductModelById(int Id)
        {
            try
            {
                using(var _Context=new SalesTrackingSystemsEntities())
                {
                    var Data = _Context.Products.Where(a => a.Product_ID == Id).Select(a => new ProductModel()
                    {
                        Product_ID = a.Product_ID,
                        ProductName = a.ProductName,
                        ProductDescription=a.ProductDescription,
                        Unit=a.Unit,
                        ProductCategory_ID=a.ProductCategory_ID,
                        UnitRate=a.UnitRate,
                        PackRate=a.PackRate,
                        PackSize=a.PackSize
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

        public List<ProductModel> listData()
        {
            try
            {
                using (var _Context = new SalesTrackingSystemsEntities())
                {
                    var Data = _Context.Products.Select(a => new ProductModel()
                    {
                        Product_ID = a.Product_ID,
                        ProductName = a.ProductName,
                        ProductDescription=a.ProductDescription,
                        Unit=a.Unit,
                        ProductCategory_ID = a.ProductCategory_ID,
                        UnitRate=a.UnitRate,
                        PackRate=a.PackRate,
                        PackSize=a.PackSize

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

        public bool Save(ProductModel model)
        {
            try
            {
                using (var _Context = new SalesTrackingSystemsEntities())
                {
                    var SaveModel = new Product()
                    {
                        Product_ID = model.Product_ID,
                        ProductName =model.ProductName,
                        ProductDescription=model.ProductDescription,
                        Unit=model.Unit,
                        ProductCategory_ID = model.ProductCategory_ID,
                        UnitRate=model.UnitRate,
                        PackRate=model.PackRate,
                        PackSize=model.PackSize
                    };
                    _Context.Products.Add(SaveModel);
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

        public bool Update(ProductModel model)
        {
        try
        {
            using (var _Context = new SalesTrackingSystemsEntities())
            {
                var data = _Context.Products.FirstOrDefault(a => a.Product_ID == model.Product_ID);
                if (data == null) return false;
                    data.Product_ID = model.Product_ID;
                    data.ProductName = model.ProductName;
                    data.ProductDescription = model.ProductDescription;
                    data.Unit = model.Unit;
                    data.ProductCategory_ID = model.ProductCategory_ID;
                    data.UnitRate = model.UnitRate;
                    data.PackRate = model.PackRate;
                    data.PackSize = model.PackSize;
                
               
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
