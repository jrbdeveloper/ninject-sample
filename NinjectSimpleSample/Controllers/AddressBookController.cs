using App.Core.Contracts.Domain;
using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using NinjectSimpleSample.Models;

namespace NinjectSimpleSample.Controllers
{
    public class AddressBookController : Controller
    {
        #region Injection
        private readonly IPersonDO _personDomain;
        
        public AddressBookController(IPersonDO personDomain)
        {
            _personDomain = personDomain;
        }
        #endregion

        public ActionResult Index()
        {
            //var model = Mapper.Map<List<PersonModel>>(_personDomain.GetAddressBook());
            //return View(model);
            var model = Mapper.Map<List<PersonModel>>(_personDomain.GetFromRepo());
            return View(model);
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
