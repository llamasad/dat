﻿using CRUID.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUID.Controllers
{
    public class ProductsController : Controller
    {
        // GET: ProductController
        public ActionResult Index()
        {
            return View(ProductRepository.Products);
        }
        [HttpPost]
        public ActionResult Search(string keywords)
        {
            return View("Index",ProductRepository.Products.Where(p=>p.Name.Contains(keywords)));
        }
        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View(ProductRepository.product(id));
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product )
        {
            try
            {
                ProductRepository.AddNew(product);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product)
        {
            try
            {
                ProductRepository.EditProduct(product);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
