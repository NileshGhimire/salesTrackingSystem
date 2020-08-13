using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Service.Iservice
{
    public interface IAdressService
    {
        int GetId();
        bool Save(AddressModel model);
        bool Update(AddressModel model);
        bool Delete(int Id);
        List<AddressModel> listData();
        AddressModel GetAdressModelById(int id);
    }
}
