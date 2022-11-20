using Biblioteca.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Interfaces
{
    public interface ILogin
    {
        string Nombre { get; set; }
        string Password { get; set; }
        string LabelError { get; set; }


    }
}
