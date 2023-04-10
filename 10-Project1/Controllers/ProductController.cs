﻿using _10_Project1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace _10_Project1Controllers
{
    public class ProductController : Controller
    {
        NorthwindContext context = new NorthwindContext();
        public IActionResult Index()
        {
            var products = context.Products.Include(p => p.Supplier)
                                   .Include(p => p.Category)
                                   .ToList();

            return View(products);
        }
        public IActionResult Create()
        {
            ViewBag.SupplierId = context.Suppliers
        .Select(s => new SelectListItem { Value = s.SupplierId.ToString(), Text = s.CompanyName }).ToList();

            ViewBag.CategoryId = context.Categories
        .Select(c => new SelectListItem { Value = c.CategoryId.ToString(), Text = c.CategoryName }).ToList();

            return View(new Product());
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }


            var newProduct = new Product
            {
                ProductName = product.ProductName,
                SupplierId = product.SupplierId,
                CategoryId = product.CategoryId,
                QuantityPerUnit = product.QuantityPerUnit,
                UnitPrice = product.UnitPrice,
                UnitsInStock = product.UnitsInStock,
                UnitsOnOrder = product.UnitsOnOrder,
                ReorderLevel = product.ReorderLevel,
                Discontinued = product.Discontinued
            };


            context.Products.Add(newProduct);
            context.SaveChanges();


            return RedirectToAction("Index");
        }


        public IActionResult Edit(int id)
        {
            var category = context.Products.Where(x => x.ProductId == id).FirstOrDefault();

            ViewBag.SupplierId = context.Suppliers
       .Select(s => new SelectListItem { Value = s.SupplierId.ToString(), Text = s.CompanyName }).ToList();

            ViewBag.CategoryId = context.Categories
        .Select(c => new SelectListItem { Value = c.CategoryId.ToString(), Text = c.CategoryName }).ToList();

            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                context.Products.Update(product);
                context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(product);
        }


        public IActionResult Delete(int id)
        {
            var delete = context.Products.Where(x => x.ProductId == id).FirstOrDefault();

            if (delete == null)
            {
                return NotFound();
            }

            context.Products.Remove(delete);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
