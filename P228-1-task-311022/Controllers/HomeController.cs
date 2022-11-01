using Microsoft.AspNetCore.Mvc;
using P228_1_task_311022.Models;
using P228_1_task_311022.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P228_1_task_311022.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Brand> _brands;
        private readonly List<Model> _models;
        private readonly List<Car> _cars;
        public HomeController()
        {
            _brands = new List<Brand>
            {
                new Brand
                {
                    Id= 1,
                    Name = "Bmw"
                },
                new Brand
                {
                    Id= 2,
                    Name = "Audi"
                },
                new Brand
                {
                    Id= 3,
                    Name = "Infiniti"
                },
                new Brand
                {
                    Id= 4,
                    Name = "Mercedes"
                }
            };
            _models = new List<Model>
            {
                new Model
                {
                    Id = 1,
                    Name = "R8",
                    Year = "2000"
                },
                new Model
                {
                    Id = 2,
                    Name = "HS9",
                    Year = "2001"
                },
                new Model
                {
                    Id = 3,
                    Name = "X6",
                    Year = "2006"
                },
                new Model
                {
                    Id = 4,
                    Name = "Hyundai",
                    Year = "2009"
                }
            };
            _cars = new List<Car>
            {
                new Car
                {
                    Id = 1,
                    Name = "My 1st Car",
                },
                new Car
                {
                    Id = 2,
                    Name = "My 2nd Car",
                },
                new Car
                {
                    Id = 3,
                    Name = "My 3th Car",
                },
                new Car
                {
                    Id = 4,
                    Name = "My 4th Car",
                }
            };
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Brands = _brands,
                Models = _models
            };
            return View(homeVM);
        }

        public IActionResult Models(int? id)
        {
            Model model = _models.Find(m => m.Id == id);
            return View(model);
        }

        public IActionResult Cars(int? id)
        {
            Car car = _cars.Find(c => c.Id == id);
            return View(car);
        }
    }
}