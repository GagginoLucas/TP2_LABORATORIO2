using Biblioteca.Modelos;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;

namespace Modelos.Deberia
{
    [TestClass]
    public class PartidaDeberia
    {

        public static List<Jugador>? UserTest = Conexiones.ObtenerJugadores();
        public static Partida partidaTest = new Partida(UserTest[0], UserTest[1], "false");

        [TestMethod]
        public void IniciarPartidaTest()
        {
            partidaTest.IniciarPartida();
            Assert.IsTrue(partidaTest.Jugador1.EsMano == true);
            Assert.IsTrue(partidaTest.Jugador2.EstaEnPartida == true);
            Assert.IsTrue(partidaTest.Jugador1.EstaEnPartida == true);
            Assert.IsNotNull(partidaTest.MazoDeCartas);

        }

        [TestMethod]
        public void RepartirManoTest()
        {
            Assert.IsTrue(partidaTest.Jugador1.CartasEnMano.Count > 0);
            Assert.IsTrue(partidaTest.Jugador2.CartasEnMano.Count > 0);

        }

        [TestMethod]
        public void RepartirCartasTest()
        {
            Assert.IsTrue(partidaTest.MazoDeCartas.Count == 34);
            Assert.AreEqual(partidaTest.Jugador1.CartasEnMano.Count, partidaTest.Jugador2.CartasEnMano.Count);
            Assert.AreNotEqual(partidaTest.Jugador1.CartasEnMano[0], partidaTest.Jugador2.CartasEnMano[0]);

        }

        [TestMethod]
        public void AsignarTurnoYSumarManosGanadasTest()
        {
            partidaTest.RepartirMano();
            partidaTest.Jugador1.UltimaCartaJugada = partidaTest.Jugador1.CartasEnMano[1];
            partidaTest.Jugador2.UltimaCartaJugada = partidaTest.Jugador2.CartasEnMano[1];
            partidaTest.AsignarTurnoYSumarManosGanadas(false);
            Assert.IsFalse(partidaTest.Jugador1.EsMano == true && partidaTest.Jugador2.EsMano == true);
            Assert.IsFalse(partidaTest.Jugador1.EsMano == false && partidaTest.Jugador2.EsMano == false);
            Assert.IsTrue(partidaTest.Jugador1.ManosGanadas != 0 || partidaTest.Jugador2.ManosGanadas != 0);
        }

        [TestMethod]

        public void SumarPuntosDelTrucoTest()
        {
            partidaTest.Jugador1.ManosGanadas = 2;
            partidaTest.Jugador1.CantóTruco = true;
            partidaTest.Jugador2.CantóTruco = true;
            partidaTest.SumarPuntosDelTruco();
            Assert.IsTrue(partidaTest.Jugador1.Puntaje == 2);
            Assert.IsFalse(partidaTest.Jugador2.Puntaje == 2);
        }

        [TestMethod]
        public void VerificarSiHayGanadorTest()
        {
            partidaTest.Jugador1.Puntaje = 15;
            partidaTest.Jugador2.Puntaje = 14;
            partidaTest.VerificarSiHayGanador();
            Assert.IsTrue(partidaTest.GanadorDeLaPartida == partidaTest.Jugador1.Usuario);
            Assert.IsFalse(partidaTest.GanadorDeLaPartida == partidaTest.Jugador2.Usuario);
            Assert.IsTrue(partidaTest.PerdedorDeLaPartida == partidaTest.Jugador2.Usuario);
            Assert.IsFalse(partidaTest.PerdedorDeLaPartida == partidaTest.Jugador1.Usuario);

        }

        [TestMethod]
        public void JugarTrucoTest()
        {
            
            partidaTest.JugarTruco(partidaTest.Jugador1, partidaTest.Jugador2);
            Assert.IsNotNull(partidaTest.Jugador1);
            Assert.IsNotNull(partidaTest.Jugador2);


        }

        [TestMethod]
        public void JugarTrucoTest1()
        {
            partidaTest.JugarTruco(partidaTest.Jugador1, partidaTest.Jugador2);
            Assert.IsNotNull(partidaTest.Jugador1);
            Assert.IsNotNull(partidaTest.Jugador2);


        }

    }
}