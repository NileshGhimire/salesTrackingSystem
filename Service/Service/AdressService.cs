using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Iservice;
using Model;
using DAL;
using Service.Service;

namespace Service.Service
{
    public class AdressService : IAdressService
    {
        public bool Delete(AddressModel model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int Id)
        {
            try
            {
                using (var _Context = new SalesTrackingSystemsEntities())
                {
                    var data = _Context.Adresses.FirstOrDefault(a => a.Adress_ID == Id);
                    _Context.Adresses.Remove(data);
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

        public AdressModel GetAdressModelById(int id)
        {
            try
            {
                using (var _Context= new SalesTrackingSystemsEntities())
                {
                    var Data = _Context.Adresses.Where(a => a.Adress_ID == id).Select(a => new AdressModel()
                    {
                        Adress_ID = a.Adress_ID,
                        AdressName = a.AdressName,
                        StatesName = a.StatesName,
                        DistrictName = a.DistrictName

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

        public int GetId()
        {
            throw new NotImplementedException();
        }

        public List<AddressModel> listData()
        {
            try
            {
                using (var _Context = new SalesTrackingSystemsEntities())
                {
                    var Data = _Context.Adresses.Select(a => new AddressModel()
                    {
                        Adress_ID = a.Adress_ID,
                        AdressName = a.AdressName,
                        StatesName = a.StatesName,
                        DistrictName = a.DistrictName

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

        public bool Save(AddressModel model)
        {
            try
            {
                using (var _Context = new SalesTrackingSystemsEntities())
                {
                    var SaveModel = new Adress()
                    {
                        Adress_ID = model.Adress_ID,
                        AdressName = model.AdressName,
                        StatesName = model.StatesName,
                        DistrictName = model.DistrictName
                    };
                    _Context.Adresses.Add(SaveModel);
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

        public bool Update(AddressModel model)
        {
            try
            {
                using (var _Context = new SalesTrackingSystemsEntities())
                {
                    var data = _Context.Adresses.FirstOrDefault(a => a.Adress_ID == model.Adress_ID);
                    if (data == null) return false;
                    data.Adress_ID = model.Adress_ID;
                    data.AdressName = model.AdressName;
                    data.StatesName = model.StatesName;
                    data.DistrictName = model.DistrictName;
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

        AddressModel IAdressService.GetAdressModelById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
