﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using itb.Shared;

namespace AspNetCoreMvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _prodRepo;

        public ProductController(IProductRepository prodRepo)
        {
            _prodRepo = prodRepo;
        }

        public IActionResult Index()

        {
            var products = _prodRepo.GetProducts();
            return View(products);
        }
    }
}