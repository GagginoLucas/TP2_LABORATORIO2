using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Modelos
{
    public class Administrador : Persona
    {
        private string contraseña;


        public Administrador(int id, string nombre, string apellido, string usuario, string contraseña) : base(id, nombre, apellido, usuario)
        {
            this.contraseña = contraseña;
        }

        public string Contraseña { get => contraseña; }
    }
}

