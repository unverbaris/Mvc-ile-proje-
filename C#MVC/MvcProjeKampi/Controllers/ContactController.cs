﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactDal());
        ContactValidator cv = new ContactValidator();

        public ActionResult Index()
        {
            var contactValues = cm.GetList();
            return View(contactValues) ;
        }

        public ActionResult GetContactDetails(int id)
        {
            var conctactValue = cm.GetByID(id);
            return View(conctactValue);
        }

        public PartialViewResult MessageListBox()
        {
            return PartialView();
        }
    }
}