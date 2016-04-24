﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Local.Controllers
{
    public class InventarioController : Controller
    {
        private Activos_PrestamosOET.Models.PrestamosEntities db = new Activos_PrestamosOET.Models.PrestamosEntities();

        // GET: Inventario/Index
        // default
        public ActionResult Index()
        {
            List<String> solicitantes = new List<String>();
            List<String> ceds = new List<String>();
            foreach (Activos_PrestamosOET.Models.PRESTAMO p in db.PRESTAMOS)
            {
                foreach (Activos_PrestamosOET.Models.USUARIO u in db.USUARIOS)
                {
                    if (p.USUARIO != null)
                    {
                        if (p.USUARIO.Equals(u.IDUSUARIO))
                        {
                            solicitantes.Add(u.NOMBRE);
                            ceds.Add(u.IDUSUARIO);
                        }
                    }
                }
            }


            var courses = new List<List<String>>();
            var users = db.ACTIVOS;
            foreach (Activos_PrestamosOET.Models.ACTIVO x in users)
            {
                if (x.PRESTABLE == true)
                {
                    List<String> temp = new List<String>();

                    if (x.FABRICANTE != null) { temp.Add(x.FABRICANTE); } else { temp.Add(""); }
                    if (x.MODELO != null) { temp.Add(x.MODELO); } else { temp.Add(""); }
                    if (x.NUMERO_SERIE != null) { temp.Add(x.NUMERO_SERIE); } else { temp.Add(""); }

                    if (x.TIPO_ACTIVOID != 0) {
                        foreach (Activos_PrestamosOET.Models.TIPOS_ACTIVOS tipos in db.TIPOS_ACTIVOS)
                        {
                            if (x.TIPO_ACTIVOID.Equals(tipos.ID))
                            {
                                temp.Add(tipos.NOMBRE);

                            }
                        }
                    }
                    else { temp.Add(""); }

                    String prestado_a = "No prestado";

                    foreach (Activos_PrestamosOET.Models.PRESTAMO f in x.PRESTAMOes)

                    {
                        if (ceds.Contains(f.CED_SOLICITA) && f.CED_SOLICITA != null)
                        {
                            prestado_a = solicitantes[ceds.IndexOf(f.CED_SOLICITA)];
                        }

                    }
                    temp.Add(prestado_a);

                    courses.Add(temp);
                }
            }
            ViewBag.Courses = courses;

            return View();
        }

        // GET: Inventario/Buscar
        // default
        [HttpPost]
        public ActionResult Index(String dropdownCategoria)
        {
            var t = ViewBag.listItems;

            if (!dropdownCategoria.Equals("1"))
            {
                var viewModel = from o in db.PRESTAMOS.ToList()
                                join o2 in db.USUARIOS.ToList()
                                    on o.CED_SOLICITA equals o2.CLAVE
                                where o.CED_SOLICITA.Equals(o2.CLAVE)
                                select new Inventario.Models.ModeloInventario { Prestamos = o, Usuarios = o2 };


                var courses = new List<List<String>>();
                var users = db.ACTIVOS;
                foreach (Activos_PrestamosOET.Models.ACTIVO x in users)
                {
                    int cat = 0;
                    foreach (Activos_PrestamosOET.Models.TIPOS_ACTIVOS tipos in db.TIPOS_ACTIVOS)
                    {
                        if (dropdownCategoria.Equals(tipos.NOMBRE))
                        {
                            cat = tipos.ID;

                        }
                    }

                    if (x.PRESTABLE == true && x.TIPO_ACTIVOID.Equals(cat))
                    {
                        List<String> temp = new List<String>();

                        if (x.FABRICANTE != null) { temp.Add(x.FABRICANTE); } else { temp.Add(""); }
                        if (x.MODELO != null) { temp.Add(x.MODELO); } else { temp.Add(""); }
                        if (x.NUMERO_SERIE != null) { temp.Add(x.NUMERO_SERIE); } else { temp.Add(""); }
                        if (x.TIPO_ACTIVOID != 0)
                        {
                            foreach (Activos_PrestamosOET.Models.TIPOS_ACTIVOS tipos in db.TIPOS_ACTIVOS)
                            {
                                if (x.TIPO_ACTIVOID.Equals(tipos.ID))
                                {
                                    temp.Add(tipos.NOMBRE);

                                }
                            }
                        }
                        else { temp.Add(""); }

                        String prestado_a = "No prestado";
                        foreach (Activos_PrestamosOET.Models.PRESTAMO f in x.PRESTAMOes)

                        {

                            // whatever you want to do with the objects
                            foreach (Inventario.Models.ModeloInventario mi in viewModel)
                            {
                                if (f.CED_SOLICITA.Equals(mi.Usuarios.CLAVE)
                                    && f.CED_SOLICITA != null)
                                {
                                    prestado_a = mi.Usuarios.NOMBRE;
                                }
                            }

                        }
                        temp.Add(prestado_a);

                        //if viewModel tiene  hace match con alguno de los f's
                        courses.Add(temp);
                    }
                }
                ViewBag.Courses = courses;
                return View();
            }//---------------------------------------------------------------------------------------------------------------------
            else
            {
                List<String> solicitantes = new List<String>();
                List<String> ceds = new List<String>();
                foreach (Activos_PrestamosOET.Models.PRESTAMO p in db.PRESTAMOS)
                {
                    foreach (Activos_PrestamosOET.Models.USUARIO u in db.USUARIOS)
                    {
                        if (p.USUARIO != null)
                        {
                            if (p.USUARIO.Equals(u.IDUSUARIO))
                            {
                                solicitantes.Add(u.NOMBRE);
                                ceds.Add(u.IDUSUARIO);
                            }
                        }
                    }
                }


                var courses = new List<List<String>>();
                var users = db.ACTIVOS;
                foreach (Activos_PrestamosOET.Models.ACTIVO x in users)
                {
                    if (x.PRESTABLE == true)
                    {
                        List<String> temp = new List<String>();

                        if (x.FABRICANTE != null) { temp.Add(x.FABRICANTE); } else { temp.Add(""); }
                        if (x.MODELO != null) { temp.Add(x.MODELO); } else { temp.Add(""); }
                        if (x.NUMERO_SERIE != null) { temp.Add(x.NUMERO_SERIE); } else { temp.Add(""); }

                        if (x.TIPO_ACTIVOID != 0)
                        {
                            foreach (Activos_PrestamosOET.Models.TIPOS_ACTIVOS tipos in db.TIPOS_ACTIVOS)
                            {
                                if (x.TIPO_ACTIVOID.Equals(tipos.ID))
                                {
                                    temp.Add(tipos.NOMBRE);

                                }
                            }
                        }
                        else { temp.Add(""); }

                        String prestado_a = "No prestado";

                        foreach (Activos_PrestamosOET.Models.PRESTAMO f in x.PRESTAMOes)

                        {
                            if (ceds.Contains(f.CED_SOLICITA) && f.CED_SOLICITA != null)
                            {
                                prestado_a = solicitantes[ceds.IndexOf(f.CED_SOLICITA)];
                            }

                        }
                        temp.Add(prestado_a);

                        courses.Add(temp);
                    }
                }
                ViewBag.Courses = courses;
                return View();
            }
            
        }
    }
}