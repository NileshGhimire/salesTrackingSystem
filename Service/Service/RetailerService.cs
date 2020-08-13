using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using Service.Iservice;
namespace Service.Service
{
    public class RetailerService : IRetailerService
    {
        public bool Delete(RetailerModel model)
        {
           
            throw new NotImplementedException();
        }

        public bool Delete(int Id)
        {
            try
            {
                using (var _Context = new SalesTrackingSystemsEntities())
                {
                    var data = _Context.Retailers.FirstOrDefault(a => a.Retailer_ID == Id);
                    _Context.Retailers.Remove(data);
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

        public RetailerModel GetRetailerModelById(int Id)
        {
            try
            {
                using (var _Context = new SalesTrackingSystemsEntities())
                {
                    var data = _Context.Retailers.Where(a => a.Retailer_ID == Id).Select(a => new RetailerModel()
                    {
                        Retailer_ID = a.Retailer_ID,
                        RetailerName = a.RetailerName,
                        Distributor_ID = a.Distributor_ID,
                        Adress_ID = a.Adress_ID,
                        Email = a.Email,
                        PhoneNumber = a.PhoneNumber,
                        MobileNumber = a.MobileNumber
                    }).FirstOrDefault();
                    return data;

                }
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }


        public List<RetailerModel> listData()
        {
            try
            {
                using (var _Context = new SalesTrackingSystemsEntities())
                {
                    var Data = _Context.Retailers.Select(a => new RetailerModel()
                    {
                       Retailer_ID=a.Retailer_ID,
                       RetailerName=a.RetailerName,
                       Distributor_ID=a.Distributor_ID,
                       Adress_ID=a.Adress_ID,
                       Email=a.Email,
                       PhoneNumber=a.PhoneNumber,
                       MobileNumber=a.MobileNumber

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

        public bool Save(RetailerModel model)
        {
            try
            {
                using (var _Context = new SalesTrackingSystemsEntities())
                {
                    var SaveModel = new Retailer()
                    {
                        Retailer_ID = model.Retailer_ID,
                        RetailerName=model.RetailerName,
                        Distributor_ID=model.Distributor_ID,
                        Adress_ID=model.Adress_ID,
                        Email=model.Email,
                        PhoneNumber=model.PhoneNumber,
                        MobileNumber=model.MobileNumber
                    };
                    _Context.Retailers.Add(SaveModel);
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

        public bool Update(RetailerModel model)
        {
            try
            {
                using (var _Context = new SalesTrackingSystemsEntities())
                {
                    var data = _Context.Retailers.FirstOrDefault(a => a.Retailer_ID == model.Retailer_ID);
                    if (data == null) return false;
                    data.Retailer_ID = model.Retailer_ID;
                    data.RetailerName = model.RetailerName;
                    data.Distributor_ID = model.Distributor_ID;
                    data.Adress_ID = model.Adress_ID;
                    data.Email = model.Email;
                    data.PhoneNumber = model.PhoneNumber;
                    data.MobileNumber = model.MobileNumber;


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
