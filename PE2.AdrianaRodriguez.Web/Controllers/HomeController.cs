using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PE2.AdrianaRodriguez.Web.Models;
using Tamriel.Domain;

namespace PE2.AdrianaRodriguez.Web.Controllers

{
public class HomeController : Controller
    {
        public IActionResult Index()

        {
            //List<Province> provinceList = new List<Province>();
            var provinceRepository = new ProvinceRepository();
            var geographyRepository = new GeographyRepository();
            var raceRepository = new RaceRepository();

            ViewBag.ProvinceList = provinceRepository.GetProvinces().OrderBy(Province => Province.Name);
            ViewBag.GeographyList = geographyRepository.GetGeography().OrderBy(Geography => Geography.Name);
            ViewBag.RaceList = raceRepository.GetRaces().OrderBy(Race => Race.Name);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
