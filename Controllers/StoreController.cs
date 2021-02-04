﻿using FlowersStore.Data;
using FlowersStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FlowersStore.Controllers
{
    public class StoreController : Controller
    {
       
        public IActionResult Index()
        {
            var model = new StoreViewModel();
            using (StoreDBContext db = new StoreDBContext())
            {
                model.Products = db.Products.Include(f => f.Category).ToArray();
            }
            return View(model);
        }
    }
}
