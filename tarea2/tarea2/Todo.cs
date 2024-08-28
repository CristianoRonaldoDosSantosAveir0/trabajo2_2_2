using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2
{
    internal class Todo
    {
        class Carta
        {
            public string Contenido;
            public string Metodo;

            public Carta(string contenido, string metodo)
            {
                Contenido = contenido;
                Metodo = metodo;
            }
        }
        class destinatario
        {
            public string nombre;
            public destinatario(string nombre)
            {
                this.nombre = nombre;
            }
        }
    }
}
