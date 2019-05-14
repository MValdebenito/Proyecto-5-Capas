using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Cliente
    {
        private string rut;
        private string nombre;

        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
