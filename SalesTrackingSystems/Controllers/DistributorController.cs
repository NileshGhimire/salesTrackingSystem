using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Service.Service;
using Service.Iservice;
using Model;
namespace SalesTrackingSystems.Controllers
{
    public class DistributorController : Controller
    {
        private IDistributorService distributorService;
        public DistributorController()
        {
            distributorService = new DistributorService();
        }
        // GET: Distributor
        public ActionResult Index()
        {
            var model = distributorService.listData();
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
       [HttpPost]
        public ActionResult Create(DistributorModel model)
        {
            distributorService.Save(model);
            var data = distributorService.listData();
            return View("Index", data);
        }
        public ActionResult Delete(int Id)

        {
            distributorService.Delete(Id);
            var data = distributorService.listData();
            return View("index", data);
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var data = distributorService.GetDistributorModelById(Id);
            return View("Edit", data);
        
        }
       [HttpPost]
       public ActionResult Edit(DistributorModel model)
        {
            distributorService.Update(model);
            var data = distributorService.listData();
            return View("index", data);


        }

}
}
