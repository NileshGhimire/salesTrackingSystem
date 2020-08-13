using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Service.Iservice
{
    public interface IProductCategoryService
    {
        int GetId();
        bool Save(ProductCategoryModel model);
        bool Update(ProductCategoryModel model);
        bool Delete(int Id);
        List<ProductCategoryModel> listData();
        ProductCategoryModel GetProductCategoryById(int Id);
    }
}
