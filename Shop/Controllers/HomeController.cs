﻿using Microsoft.AspNetCore.Mvc;
using Shop.Interfaces.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class HomeController:Controller
    {
        private readonly IAllCars _allCars;

        public HomeController(IAllCars allCars)
        {
            this._allCars = allCars;
            
        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModel()
            {
                FavCars = _allCars.GetFavCars
            };
            return View(homeCars);
        }
    }
}
