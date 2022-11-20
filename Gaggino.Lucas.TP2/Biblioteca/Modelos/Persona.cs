using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Modelos
{
    public abstract class Persona
    {
        protected int id;
        protected string nombre;
        protected string apellido;
        protected string usuario;

        protected Persona(int id, string nombre, string apellido, string usuario)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.usuario = usuario;
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public string Apellido
        {
            get { return apellido; }
        }

        public string Usuario
        {
            get { return usuario; }
        }
    }
}
