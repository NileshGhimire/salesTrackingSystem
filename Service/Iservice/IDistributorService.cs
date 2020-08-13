using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Service.Iservice
{
    public interface IDistributorService
    {
       int GetId();
       bool Save(DistributorModel model);
        bool Update(DistributorModel model);
        bool Delete(int Id);
        List<DistributorModel> listData();
        DistributorModel GetDistributorModelById(int Id);

    }
}
