using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using Model;
using Service.Iservice;


namespace Service.Service
{
    public class DistributorService : IDistributorService
    {
        public bool Delete(DistributorModel model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int Id)
        {
            try
            {
                using (var _context=new SalesTrackingSystemsEntities())
                {
                    var Data = _context.Distributors.FirstOrDefault(a => a.Distributor_ID == Id);
                    _context.Distributors.Remove(Data);
                    _context.SaveChanges();

                    return true;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public DistributorModel GetDistributorModelById(int Id)
        {
            try
            {
                using (var _Context=new SalesTrackingSystemsEntities())
                {
                    var Data = _Context.Distributors.Where(a => a.Distributor_ID == Id).Select(a => new DistributorModel()
                    {
                        Distributor_ID = a.Distributor_ID,
                        DistributorName = a.DistributorName,
                        Adress_ID = a.Adress_ID,
                        Email = a.Email,
                        PhoneNumber = a.PhoneNumber,
                        MobileNumber = a.MobileNumber
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

        public List<DistributorModel> listData()
        {
            try
            {
                using (var _Context = new SalesTrackingSystemsEntities())
                {
                    var Data = _Context.Distributors.Select(a => new DistributorModel()
                    {
                        Distributor_ID = a.Distributor_ID,
                        DistributorName = a.DistributorName,
                        Adress_ID = a.Adress_ID,
                        Email = a.Email,
                        PhoneNumber = a.PhoneNumber,
                        MobileNumber = a.MobileNumber

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

        public bool Save(DistributorModel model)
        {
            try
            {
                using (var _Context = new SalesTrackingSystemsEntities())
                {
                    var SaveModel = new Distributor()
                    {
                        Distributor_ID = model.Distributor_ID,
                        DistributorName = model.DistributorName,
                        Adress_ID = model.Adress_ID,
                        Email = model.Email,
                        PhoneNumber = model.PhoneNumber,
                        MobileNumber = model.MobileNumber
                    };
                    _Context.Distributors.Add(SaveModel);
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

        public bool Update(DistributorModel model)
        {
            try
            {
                using (var _Context = new SalesTrackingSystemsEntities())
                {
                    var data = _Context.Distributors.FirstOrDefault(a => a.Distributor_ID == model.Distributor_ID);
                    if (data == null) return false;
                    data.Distributor_ID = model.Distributor_ID;
                    data.DistributorName = model.DistributorName;
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

    
   
