using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Service.Iservice
{
    public interface IRetailerService
    {
        int GetId();
        bool Save(RetailerModel model);
        bool Update(RetailerModel model);
        bool Delete(int Id);
        List<RetailerModel> listData();
        RetailerModel GetRetailerModelById(int Id);
    }
}

