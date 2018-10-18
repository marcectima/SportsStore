using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore1.Domain.Abstract;
using SportsStore1.Domain.Entities;

namespace SportsStore1.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;

        public ProductController(IProductRepository productsRepository)
        {
            this.repository = productsRepository;
        }
        public ViewResult List()
        {
            return View(repository.Products);
        }
    }
}