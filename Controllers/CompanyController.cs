using ContosoUniversity.DAL;
using ContosoUniversity.Models;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ContosoUniversity.Controllers
{
    public class CompanyController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: Company
        public ActionResult Index()
        {
            return View(db.Companies);
        }

        public ActionResult Create()
        {            
            return View();
        }

        // POST: Company/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "CompanyId,RUT,Name,Address,Email,Website,Phone")] Company company)
        {
            if (ModelState.IsValid)
            {
                db.Companies.Add(company);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }            
            return View(company);
        }
    }
}