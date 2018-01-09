using System.Web.Mvc;
using BlockchainHashing.ViewModels;
using BlockchainHashing.Models;
using System.Linq;

namespace BlockchainHashing.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();

        }
        //[HttpPost]
        //public ActionResult Index(string value)
        //{
        //    value = HashData.GetHashString(value);
        //    return Json(value, JsonRequestBehavior.AllowGet);

        //}

        [HttpPost]
        public ActionResult Index(BlockchainViewmodel data)
        {
            AllDummyTablesEntities db = new AllDummyTablesEntities();
            var getdata = (from aa in db.Blockchains  select aa).SingleOrDefault();
            if (getdata == null)
            {
                Blockchain addData = new Blockchain()
                {
                    Data=data.Data,
                    Hash= HashData.GetHashString(data.Hash),
                    PatientId=1
                };
                db.Blockchains.Add(addData);
                db.SaveChanges();
            }
            else
            {

            }
            return View();
        }
    }
}