using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_clasificacion_pacientes
{
    class ArbolPacientes
    {
        public Nodo Raiz { get; private set; }

        public ArbolPacientes()
        {
            Raiz = ConstruirArbol();
        }

        private Nodo ConstruirArbol()
        {
            // Lógica para construir el árbol
            var raiz = new Nodo("Género");

            var masculino = new Nodo("Masculino");
            var femenino = new Nodo("Femenino");
            raiz.Hijos.Add(masculino);
            raiz.Hijos.Add(femenino);

            var tiposSanguineos = new List<string> { "A", "B", "AB", "O" };
            foreach (var tipo in tiposSanguineos)
            {
                masculino.Hijos.Add(new Nodo(tipo));
                femenino.Hijos.Add(new Nodo(tipo));
            }

            var presiones = new List<string> { "Baja", "Normal", "Alta" };
            foreach (var nodoTipoSanguineo in masculino.Hijos.Concat(femenino.Hijos))
            {
                foreach (var presion in presiones)
                {
                    nodoTipoSanguineo.Hijos.Add(new Nodo(presion));
                }
            }

            return raiz;
        }
    }
}
