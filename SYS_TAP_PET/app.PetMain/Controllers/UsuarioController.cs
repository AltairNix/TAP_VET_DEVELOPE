using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidad;
using Negocio;

namespace app.PetMain.Controllers
{
    public class UsuarioController : Controller
    {
        private AdmUsuario objUsuario;

        public UsuarioController()
        {
            objUsuario = new AdmUsuario();
        }

        // GET: Usuario
        public ActionResult Index()
        {
            //List<Usuario> listAlumno = objUsuario.
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}