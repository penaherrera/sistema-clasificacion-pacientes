using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_clasificacion_pacientes
{
    class Nodo
    {
        public string Valor { get; set; }
        public List<Nodo> Hijos { get; set; } = new List<Nodo>();

        public Nodo(string valor)
        {
            Valor = valor;
        }
    }
}
