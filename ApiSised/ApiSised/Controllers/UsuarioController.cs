using ApiSised.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft;
using System.Web.Helpers;
using System.Web.Security;
namespace ApiSised.Controllers
{
    [RoutePrefix("api/usuario")]
    public class UsuarioController : ApiController
    {
        [AcceptVerbs("POST")]
        [Route("AutenticarUsuario")]
        public UsuarioModel AutenticarUsuario(string user, string pass)
        {

            UsuarioModel u = new UsuarioModel();
            string usuario = user.ToUpper();
            string senha = FormsAuthentication.HashPasswordForStoringInConfigFile(pass.ToUpper(), "md5");

            if (usuario.Equals("ADMIN") && pass.ToUpper().Equals("SISED2018"))
            {
                u.Autenticado = true;
                u.Id = 0;
                u.Msg = "Usuario Autenticado.";
                u.Nome = "Administrador Sised";
                u.Perfil = 1;
                u.Senha = null;
                u.Usuario = "ADMIN";
            }


            return u;
        }
    }
}
