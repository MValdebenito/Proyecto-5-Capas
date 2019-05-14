using CapaConexion;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDTO;

namespace CapaNegocio
{
    public class Negocio
    {
        private Conexion con;

        public Conexion Con { get => con; set => con = value; }

        public void conectConfig()
        {
            this.con = new Conexion();
            this.con.NombreBaseDeDatos = "P5Capas";
            this.con.NombreTabla = "Cliente";
            this.con.CadenaConexion = "";
        }

        public void insertarCli(Cliente cli)
        {
            this.conectConfig();
            this.con.CadenaSQL = "insert into cliente (rut,nombre)" +
                                 "values('"+cli.Rut+"','"+cli.Nombre+"');";
            this.con.EsSelect = false;
            this.con.conectar();
        }

        public DataSet ListarCli()
        {
            this.conectConfig();
            this.con.CadenaSQL = "select * from cliente;";
            this.con.EsSelect = true;
            this.con.conectar();
            return this.con.DbDataSet;
        }

        public string BuscarPorRut(string rut)
        {
            this.conectConfig();
            this.con.CadenaSQL = "select nombre from cliente where rut = '"+rut+"';";
            this.con.EsSelect = true;
            this.con.conectar();
            string nom = Convert.ToString(this.con.DbDataAdapter);
            return nom;
        }

        public void eliminarCli(string rut)
        {
            this.conectConfig();
            this.con.CadenaSQL = "delete from cliente where rut = '"+rut+"';";
            this.con.EsSelect = false;
            this.con.conectar();            
        }

        public void editarCli(Cliente cli)
        {
            this.conectConfig();
            this.con.CadenaSQL = "update from cliente" +
                                 "set nombre = '" + cli.Nombre + "'" +
                                 "where rut = '" + cli.Rut + "';";
            this.con.EsSelect = false;
            this.con.conectar();
        }
    }
}
