using Biblioteca.Modelos;

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
        public void RepartirCartasTest()
        {
            Assert.IsTrue(partidaTest.Jugador1.CartasEnMano.Count > 0);
            Assert.IsTrue(partidaTest.Jugador2.CartasEnMano.Count > 0);

        }
    }
}