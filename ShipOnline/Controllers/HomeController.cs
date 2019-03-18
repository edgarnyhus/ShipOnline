using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShipOnline.Core;
using ShipOnline.Core.Domain;
using ShipOnline.Persistence;
using ShipOnline.ViewModels;

namespace ShipOnline.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        //public HomeController()
        //{
        //    _unitOfWork = new UnitOfWork(new ShipBaseDbContext());
        //}

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActionResult Index()
        {
            CompanyViewModel _viewModel = new CompanyViewModel();
            var companies = _unitOfWork.Companies.GetAll().ToList();
            _viewModel.Companies = companies;
            return View(_viewModel);
            //return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}