using Service.Iservice;
using Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using Model;

namespace SalesTrackingSystems.Controllers
{
    public class RetailerController : Controller
    {
        private IRetailerService RetailerService;
        public RetailerController()
        {
            RetailerService = new RetailerService();
        }
        // GET: Retailer
        public ActionResult Index()
        {
            var model = RetailerService.listData();
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(RetailerModel model)
        {
            RetailerService.Save(model);
            var data = RetailerService.listData();
            return View("Index", data);
        }
        public ActionResult Delete(int Id)

        {
            RetailerService.Delete(Id);
            var data = RetailerService.listData();
            return View("index", data);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = RetailerService.GetRetailerModelById(id);
            return View("Edit", data);
        }
        [HttpPost]
        public ActionResult Edit(RetailerModel model)
        {

            RetailerService.Update(model);
            var data = RetailerService.listData();
            return View("index", data);
        }
    }
}