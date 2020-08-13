using Service.Iservice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Service.Service;
using Model;

namespace SalesTrackingSystems.Controllers
{
    public class ProductCategoryController : Controller
    {
        private IProductCategoryService productCategoryService;
        public ProductCategoryController()
        {
            productCategoryService = new ProductCategoryService();
          
        }

        // GET: ProductCategory
        public ActionResult Index()
        {
            var model = productCategoryService.listData();
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ProductCategoryModel model)
        {
            productCategoryService.Save(model);
            var data = productCategoryService.listData();
            return View("Index", data);
        }
        public ActionResult Delete(int Id)

        {
            productCategoryService.Delete(Id);
            var data = productCategoryService.listData();
            return View("index", data);
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var data = productCategoryService.GetProductCategoryById(Id);
            return View("Edit", data);

        }
        [HttpPost]
        public ActionResult Edit(ProductCategoryModel model)
        {
            productCategoryService.Update(model);
            var data = productCategoryService.listData();
            return View("index", data);


        }
    }
}