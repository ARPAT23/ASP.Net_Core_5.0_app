using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using X.PagedList;

namespace WebApplication3.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index(int page = 1)
        {
            var values = cm.GetList().ToPagedList(page, 3);
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            CategoryValidator cv = new CategoryValidator();
            ValidationResult results = cv.Validate(category);
            if (results.IsValid)
            {

                category.CategoryStatus = true;
                cm.TAdd(category);
                return RedirectToAction("AddCategory", "Category");

            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,
                        item.ErrorMessage);
                }
            }
            return View();

        }
        public IActionResult ChangeStatusCategory(int id)
        {
            var value = cm.TGetById(id);
            if (value.CategoryStatus)
            {
                value.CategoryStatus = false;
            }
            else
            {
                value.CategoryStatus = true;
            }
            cm.TUpdate(value);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var value = cm.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            category.CategoryStatus = true;
            cm.TUpdate(category);
            return RedirectToAction("Index");
        }

    }



}