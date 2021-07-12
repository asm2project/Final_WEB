using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using FPTModel.Models;
using FPTModel;
using System.Data.Entity;

namespace FPTModel.Controllers
{
    public class LoginController : Controller
    {
        private ASMWEBEntities3 db = new ASMWEBEntities3();
        public ActionResult Index()
        {
       
            return View();
        }
        
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Choose()
        {
            return View();
        }
         
        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var isValidUser = IsValidUser(model);

                //If user is valid & present in database, we are redirecting it to Welcome page.
                if (isValidUser != null)
                {
                    FormsAuthentication.SetAuthCookie(model.Username, false);
                              
                    return RedirectToAction("Choose");
             
                }
                else
                {
                    //If the username and password combination is not present in DB then error message is shown.
                    ModelState.AddModelError("Failure", "Wrong Username and password combination !");
                    return View();
                }
            }
            else
            {
                //If model state is not valid, the model with error message is returned to the View.
                return View(model);
            }

        }
        public User IsValidUser(LoginViewModel model)
        {
            using (var dataContext = new ASMWEBEntities3())
            {
                //Retireving the user details from DB based on username and password enetered by user.
                User user = dataContext.Users.Where(query => query.Username.Equals(model.Username) && query.password.Equals(model.Password)).SingleOrDefault();
                //If user is present, then true is returned.
                if (user == null)
                    return null;
                //If user is not present false is returned.
                else
                    return user;
            }

        }
   
    }
}
