using CrystalDecisions.CrystalReports.Engine;
using StudentManagement.API.Models;
using StudentManagement.API.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentManagement.API.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }


        public ActionResult ExportCustomers()
        {
            var _dbContext = new StudentDBEntities();
            var allCustomer = _dbContext.GetStudentList(0, 0).ToList();
            StudentService _st = new StudentService();

            ReportDocument rd = new ReportDocument();
            Console.Write("test");
            rd.Load(Path.Combine(Server.MapPath("~/Reports/"), "Reports.rpt"));
            rd.SetDataSource(_st.GetStudentList());
            Response.Buffer = false;
            Response.ClearContent();
            Response.ClearHeaders();

            Stream stream = rd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
            stream.Seek(0, SeekOrigin.Begin);
            return File(stream, "application/pdf", "CustomerList.pdf");
        }

    }
}
