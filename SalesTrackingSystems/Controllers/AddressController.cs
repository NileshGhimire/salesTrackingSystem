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
    public class AddressController : Controller
    {
        private IAdressService adressService;
        public AddressController()
        {
            adressService = new AdressService();
        }
        // GET: Address
        public ActionResult Index()
        {
            var model = adressService.listData();
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(AddressModel model)
        {
            adressService.Save(model);
            var data = adressService.listData();
            return View("Index", data);
        }
        public ActionResult Delete(int Id)

        {
            adressService.Delete(Id);
            var data = adressService.listData();
            return View("index", data);
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var data = adressService.GetAdressModelById(Id);
            return View("Edit", data);

        }
        [HttpPost]
        public ActionResult Edit(AddressModel model)
        {
            adressService.Update(model);
            var data = adressService.listData();
            return View("index", data);

        }
    }
}