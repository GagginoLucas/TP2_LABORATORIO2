using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Modelos
{
    public static class ManejadorDeArchivos
    {
        static string ruta;
        
        static ManejadorDeArchivos()
        {
            ruta = Environment.CurrentDirectory;
            ruta += @"/LogsPartidas";
        }

        public static bool EscribirTxt(string mensaje, string nombreArchivo)
        {
            string completa = ruta + $@"/{nombreArchivo}" + ".txt";
            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                using (StreamWriter sw = new StreamWriter(completa))
                {
                    sw.WriteLine(mensaje);
                }
                return true;
            }
            catch(Exception e)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
            return false;
        }
    }
}
