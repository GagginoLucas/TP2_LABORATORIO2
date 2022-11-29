using System.Data.SqlClient;

namespace Biblioteca.Modelos
{
    public class Conexiones
    {
        private const string connectionString = @"Server=localhost;Database=TP2_DB;Trusted_Connection=True;";

        public static List<Administrador> ObtenerAdministradores()
        {
            try
            {
                List<Administrador> admin = new List<Administrador>();
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.Connection = connection;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM Administradores";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    admin.Add(new Administrador(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4)));
                }
                connection.Close();
                return admin;
            }
            catch(Exception)
            {
                throw;
            }

        }

        public static List<Jugador> ObtenerTopCincoPerdedores()
        {
            try
            {
                List<Jugador> jugadores = new List<Jugador>();
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.Connection = connection;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT TOP(5) * FROM Jugadores ORDER BY PartidasPerdidas DESC";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    jugadores.Add(new Jugador(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetInt32(7), reader.GetInt32(8)));
                }
                connection.Close();
                return jugadores;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public static List<Jugador> ObtenerTopCincoPartidasJugadas()
        {
            try
            {
                List<Jugador> jugadores = new List<Jugador>();
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.Connection = connection;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT TOP(5) * FROM Jugadores ORDER BY PartidasJugadas DESC";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    jugadores.Add(new Jugador(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetInt32(7), reader.GetInt32(8)));
                }
                connection.Close();
                return jugadores;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public static List<Jugador> ObtenerTopCincoMejoresJugadores()
        {
            try
            {
                List<Jugador> jugadores = new List<Jugador>();
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.Connection = connection;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT TOP(5) * FROM Jugadores ORDER BY PartidasGanadas DESC";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    jugadores.Add(new Jugador(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetInt32(7), reader.GetInt32(8)));
                }
                connection.Close();
                return jugadores;
            }
            catch(Exception)
            {
                throw;
            }
 
        }


        public static List<Jugador> ObtenerJugadores()
        {
            try
            {
                List<Jugador> jugadores = new List<Jugador>();
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.Connection = connection;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM Jugadores";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    jugadores.Add(new Jugador(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetInt32(7), reader.GetInt32(8)));
                }
                connection.Close();
                return jugadores;
            }
            catch (Exception)
            {
                throw;
            }

        }


        public static List<Partida> ObtenerPartidas()
        {
            try
            {
                List<Partida> partidas = new List<Partida>();
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.Connection = connection;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM Partidas ORDER BY Fecha DESC";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    partidas.Add(new Partida(reader.GetString(0), reader.GetString(1), reader.GetDateTime(2)));
                }
                connection.Close();
                return partidas;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public static void GuardarPartida(string ganador, string perdedor, DateTime fecha)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.Connection = connection;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO Partidas (Ganador, Perdedor, Fecha)  values (@Ganador , @Perdedor, @Fecha)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Ganador", ganador);
                cmd.Parameters.AddWithValue("@Perdedor", perdedor);
                cmd.Parameters.AddWithValue("@Fecha", fecha);

                cmd.ExecuteNonQuery();
                connection.Close();


            }
            catch (Exception)
            {
                throw;
            }

        }

        public static void AgregarJugador(string nombre, string apellido, string usuario)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.Connection = connection;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO Jugadores (Nombre, Apellido, Usuario, PartidasGanadas, PartidasJugadas, PartidasPerdidas, CantidadDeAnchosDeEspada, CantidadDeAnchosDeBasto)  values (@Nombre, @Apellido, @Usuario, @PartidasGanadas, @PartidasJugadas, @PartidasPerdidas, @CantidadDeAnchosDeEspada, @CantidadDeAnchosDeBasto)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@PartidasGanadas", 0);
                cmd.Parameters.AddWithValue("@PartidasJugadas", 0);
                cmd.Parameters.AddWithValue("@PartidasPerdidas", 0);
                cmd.Parameters.AddWithValue("@CantidadDeAnchosDeEspada", 0);
                cmd.Parameters.AddWithValue("@CantidadDeAnchosDeBasto", 0);
                cmd.ExecuteNonQuery();
                connection.Close();


            }
            catch (Exception)
            {
                throw;
            }

        }

        public static void ActualizarEstadisticas(Jugador jugador)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.Connection = connection;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE Jugadores SET PartidasGanadas=@ganadas , PartidasJugadas=@jugadas , PartidasPerdidas=@perdidas, CantidadDeAnchosDeEspada=@espadas, CantidadDeAnchosDeBasto=@bastos WHERE ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", jugador.Id);
                cmd.Parameters.AddWithValue("@ganadas", jugador.CantidadDePartidasGanadas);
                cmd.Parameters.AddWithValue("@jugadas", jugador.CantidadDePartidasJugadas);
                cmd.Parameters.AddWithValue("@perdidas", jugador.CantidadDePartidasPerdidas);
                cmd.Parameters.AddWithValue("@espadas", jugador.CantidadDeAnchosDeEspada);
                cmd.Parameters.AddWithValue("@bastos", jugador.CantidadDeAnchosDeBasto);
                cmd.ExecuteNonQuery();
                connection.Close();


            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}