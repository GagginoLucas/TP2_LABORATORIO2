using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Biblioteca.Modelos
{
    public enum Valor
    {
        AnchoDeEspada = 100,
        AnchoDeBasto = 95,
        SieteDeEspada = 90,
        SieteDeOro = 80,
        Tres = 70,
        Dos = 60,
        Unos = 50,
        Doces = 40,
        Onces = 35,
        Diez = 30,
        Sietes = 25,
        Seis = 20,
        Cincos = 15,
        Cuatros = 10,
    }
    public class Carta
    {

        private string palo;
        private int numero;
        private Valor valor;
        public Carta(string palo, int numero, Valor valor)
        {
            Palo = palo;
            Numero = numero;
            Valor = valor;
        }

        public string Palo { get => palo; set => palo = value; }
        public int Numero { get => numero; set => numero = value; }
        public Valor Valor { get => valor; set => valor = value; }

        public static List<Carta> CargarCartas()
        {
            SerializadorDeCartas mazo = new SerializadorDeCartas();
            mazo = Serializador<SerializadorDeCartas>.LeerJSon("MazoDeCartas");
            return mazo.Cartas;
            /*
              //copa
              mazoDeCartas.Add(new Carta("Copa", 12, Valor.Doces));
              mazoDeCartas.Add(new Carta("Copa", 11, Valor.Onces));
              mazoDeCartas.Add(new Carta("Copa", 10, Valor.Diez));
              mazoDeCartas.Add(new Carta("Copa", 7, Valor.Sietes));
              mazoDeCartas.Add(new Carta("Copa", 6, Valor.Seis));
              mazoDeCartas.Add(new Carta("Copa", 5, Valor.Cincos));
              mazoDeCartas.Add(new Carta("Copa", 4, Valor.Cuatros));
              mazoDeCartas.Add(new Carta("Copa", 3, Valor.Tres));
              mazoDeCartas.Add(new Carta("Copa", 2, Valor.Dos));
              mazoDeCartas.Add(new Carta("Copa", 1, Valor.Unos));

              //Basto
              mazoDeCartas.Add(new Carta("Basto", 12, Valor.Doces));
              mazoDeCartas.Add(new Carta("Basto", 11, Valor.Onces));
              mazoDeCartas.Add(new Carta("Basto", 10, Valor.Diez));
              mazoDeCartas.Add(new Carta("Basto", 7, Valor.Sietes));
              mazoDeCartas.Add(new Carta("Basto", 6, Valor.Seis));
              mazoDeCartas.Add(new Carta("Basto", 5, Valor.Cincos));
              mazoDeCartas.Add(new Carta("Basto", 4, Valor.Cuatros));
              mazoDeCartas.Add(new Carta("Basto", 3, Valor.Tres));
              mazoDeCartas.Add(new Carta("Basto", 2, Valor.Dos));
              mazoDeCartas.Add(new Carta("Basto", 1, Valor.AnchoDeBasto));

              //Oro
              mazoDeCartas.Add(new Carta("Oro", 12, Valor.Doces));
              mazoDeCartas.Add(new Carta("Oro", 11, Valor.Onces));
              mazoDeCartas.Add(new Carta("Oro", 10, Valor.Diez));
              mazoDeCartas.Add(new Carta("Oro", 7, Valor.SieteDeOro));
              mazoDeCartas.Add(new Carta("Oro", 6, Valor.Seis));
              mazoDeCartas.Add(new Carta("Oro", 5, Valor.Cincos));
              mazoDeCartas.Add(new Carta("Oro", 4, Valor.Cuatros));
              mazoDeCartas.Add(new Carta("Oro", 3, Valor.Tres));
              mazoDeCartas.Add(new Carta("Oro", 2, Valor.Dos));
              mazoDeCartas.Add(new Carta("Oro", 1, Valor.Unos));

              //Espada
              mazoDeCartas.Add(new Carta("Espada", 12, Valor.Doces));
              mazoDeCartas.Add(new Carta("Espada", 11, Valor.Onces));
              mazoDeCartas.Add(new Carta("Espada", 10, Valor.Diez));
              mazoDeCartas.Add(new Carta("Espada", 7, Valor.SieteDeEspada));
              mazoDeCartas.Add(new Carta("Espada", 6, Valor.Seis));
              mazoDeCartas.Add(new Carta("Espada", 5, Valor.Cincos));
              mazoDeCartas.Add(new Carta("Espada", 4, Valor.Cuatros));
              mazoDeCartas.Add(new Carta("Espada", 3, Valor.Tres));
              mazoDeCartas.Add(new Carta("Espada", 2, Valor.Dos));
              mazoDeCartas.Add(new Carta("Espada", 1, Valor.AnchoDeEspada));
          */

        }



        public override string ToString()
        {
            string carta;
            carta = numero.ToString();
            carta += "  de " + Palo;
            return carta;
        }

    }
}
