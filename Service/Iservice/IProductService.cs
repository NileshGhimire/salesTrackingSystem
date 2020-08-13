using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Service.Iservice
{
   public interface IProductService
    {
        int GetId();
        bool Save(ProductModel model);
        bool Update(ProductModel model);
        bool Delete(int Id);
        List<ProductModel> listData();
        ProductModel GetProductModelById(int Id);
    }
}
