using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CapaNegocio;
using CapaDTO;

namespace CapaServicios
{
    /// <summary>
    /// Descripción breve de WebServiceConsultas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceConsultas : System.Web.Services.WebService
    {

        [WebMethod]
        public string ComprobarExistencia(string rut)
        {
            Negocio nuevo = new Negocio();
            return nuevo.BuscarPorRut(rut);            
        }

        [WebMethod]
        public void insertarCl(Cliente c)
        {
            Negocio nuevo = new Negocio();
            nuevo.insertarCli(c);
        }

        [WebMethod]
        public void actualizarCli(Cliente c)
        {
            Negocio nuevo = new Negocio();
            nuevo.editarCli(c);
        }

        [WebMethod]
        public String buscarRut(String rut)
        {
            Negocio nuevo = new Negocio();
            return nuevo.BuscarPorRut(rut);
        }

        [WebMethod]
        public void eliminarCli(String rut)
        {
            Negocio nuevo = new Negocio();
            nuevo.eliminarCli(rut);
        }
    }
}
