using Farmacia.Modelos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Farmacia.Pages.Shared
{
    public class Acceso : Controller
    {

        static string cadena = "Data Source-(local);Initial Catalog-AppNet7SisFarma;Integrated Security=true";

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Registrar()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Registrar(Usario Ousuario)
        //{
        //    bool registrado;
        //    string mensaje;

        //    if (Ousuario.Clave == Ousuario.ConfirmarClave)
        //    {
        //        Ousuario.Clave = ConvertirSha256(Ousuario.Clave);
        //    }

        //    else
        //    {
        //        ViewData["Mensaje"] = "Las contraseñas no coinciden";
        //        return View();
        //    }

        //    using (SqlConnection cn = new SqlConnection(cadena))
        //    {
        //        SqlCommand cmd = new SqlCommand("sp_RegistrarUsuario", cn);
        //        cmd.Parameters.AddWithValue("Correo", Ousuario.Email);
        //        cmd.Parameters.AddWithValue("Clave", Ousuario.Clave);
        //        cmd.Parameters.Add("Registrado", SqlDbType.Bit).Direction = ParameterDirection.Output;
        //        cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cn.Open();
        //        cmd.ExecuteNonQuery();

        //        registrado = Convert.ToBoolean(cmd.Parameters["Registrado"].Value);
        //        mensaje = cmd.Parameters("Mensaje").Value.ToString();
        //    }
        //    ViewData["Mensaje"] = mensaje;
        //    if (registrado)
        //    {
        //        return RedirectToAction("Login", "Acceso");
        //    }
        //    else
        //    {
        //        return View();
        //    }
        //}
        //[HttpPost]
        //public IActionResult Login(Usario Ousuario)
        //{
        //    Ousuario.Clave = ConvertirSha256(Ousuario.Clave);
        //    using (SqlConnection cn = new SqlConnection(cadena))
        //    {
        //        SqlCommand cmd = new SqlCommand("sp_ValidarUsuario", cn);
        //        cmd.Parameters.AddWithValue("Correo", Ousuario.Email);
        //        cmd.Parameters.AddWithValue("Clave", Ousuario.Clave);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cn.Open();
        //        Ousuario.Id = Convert.ToInt32(cmd.ExecuteScalar().ToString());
        //    }

        //    if (Ousuario.Id != 0)
        //    {
        //        Session["usuario"] = Ousuario;
        //        return RedirectToAction("Index", "Home");
        //    }
        //    else
        //    {
        //        ViewData["Mensaje"] = "usuario no encontrado";
        //        return View();
        //    }
         
        //}

        public static string ConvertirSha256(string texto)
        {
            // using System.Text;
            // USAR LA REFERENCIA DE"System.Security.Cryptography"
            StringBuilder Sb = new StringBuilder();
            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(enc.GetBytes(texto));

                foreach (byte b in result)
                    Sb.Append(b.ToString("x2"));
            }
            return Sb.ToString();
        }
    }
}
