using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Test.Filters;
using Test.Models;
using Test.ViewModels;

namespace Test.Controllers
{
    public class BulkUploadController : AsyncController
    {
        // GET: BulkUpload
        [AdminFilter]
        [HeaderFooterFilter]
        public ActionResult Index()
        {
            FileUploadViewModel fuvm = new FileUploadViewModel();
            return View(fuvm);
        }

        [AdminFilter]
        [HeaderFooterFilter]
        public async Task<ActionResult> Upload(FileUploadViewModel model)
        {
            int t1 = Thread.CurrentThread.ManagedThreadId;
            EmployeeBusinessLayer ebl = new EmployeeBusinessLayer();
            List<Employee> employees = await Task.Factory.StartNew<List<Employee>>(() => ebl.GetEmployees(model));
            int t2 = Thread.CurrentThread.ManagedThreadId;
            EmployeeBusinessLayer bal = new EmployeeBusinessLayer();
            ebl.UploadEmployees(employees);
            return RedirectToAction("Index", "Employee");
        }
    }
}