using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.Infrastructure;
using NinjectSimpleSample.Models;
using App.Core.Contracts.Domain;
using AutoMapper;

namespace NinjectSimpleSample.Controllers
{
    public class FiltersController : Controller
    {
        private readonly IFilterDO _filterDomain;

        public FiltersController(IFilterDO filterDomain)
        {
            _filterDomain = filterDomain;
        }

        public ActionResult Index()
        {
            FilterModel model = Mapper.Map<FilterModel>(_filterDomain.GetByName("Test"));

            return View(model);
        }
	}
}