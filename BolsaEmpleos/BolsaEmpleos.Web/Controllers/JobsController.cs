using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RestSharp;

namespace BolsaEmpleos.Web.Controllers
{
    public class JobsController : Controller
    {
        private RestClient client = new RestClient("http://localhost:49712/");

        // GET: Jobs
        public ActionResult Index()
        {
            var request = new RestRequest("api/Jobs");
            var response = client.Get(request);

            return View();
        }
    }
}
