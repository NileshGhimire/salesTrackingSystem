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
    public class ProductController : Controller
    {
        private IProductService productService;
        public ProductController()
        {
            productService = new ProductService();
        }

        // GET: Product
        public ActionResult Index()
        {
            var model = productService.listData();
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ProductModel model)
        {
            productService.Save(model);
            var data = productService.listData();
            return View("Index", data);
        }
        public ActionResult Delete(int Id)

        {
            productService.Delete(Id);
            var data = productService.listData();
            return View("index", data);
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var data = productService.GetProductModelById(Id);
            return View("Edit", data);

        }
        [HttpPost]
        public ActionResult Edit(ProductModel model)
        {
            productService.Update(model);
            var data = productService.listData();
            return View("index", data);


        }
    }
}