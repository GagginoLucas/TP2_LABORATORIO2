using System.Data.SqlClient;

namespace Biblioteca.Modelos
{
    public class Conexiones
    {
        public static List<Administrador> ObtenerAdministradores()
        {
            List<Administrador> admin = new List<Administrador>();
            string connectionString = @"Server=localhost;Database=TP2_DB;Trusted_Connection=True;";
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

        public static List<Jugador> ObtenerJugadores()
        {
            List<Jugador> jugadores = new List<Jugador>();
            string connectionString = @"Server=localhost;Database=TP2_DB;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.Connection = connection;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT * FROM Jugadores";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                jugadores.Add(new Jugador(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6)));
            }
            connection.Close();
            return jugadores;
        }


        public static List<Partida> ObtenerPartidas()
        {
            List<Partida> partidas = new List<Partida>();
            string connectionString = @"Server=localhost;Database=TP2_DB;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.Connection = connection;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT * FROM Partidas";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                partidas.Add(new Partida(reader.GetString(0), reader.GetString(1), reader.GetDateTime(2)));
            }
            connection.Close();
            return partidas;
        }

        public static void GuardarPartida(string ganador, string perdedor, DateTime fecha)
        {
            try
            {
                string connectionString = @"Server=localhost;Database=TP2_DB;Trusted_Connection=True;";
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

        public static void ActualizarEstadisticas(Jugador jugador)
        {
            try
            {
                string connectionString = @"Server=localhost;Database=TP2_DB;Trusted_Connection=True;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.Connection = connection;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE Jugadores SET PartidasGanadas=@ganadas , PartidasJugadas=@jugadas , PartidasPerdidas=@perdidas WHERE ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ganadas", jugador.CantidadDePartidasGanadas);
                cmd.Parameters.AddWithValue("@jugadas", jugador.CantidadDePartidasJugadas);
                cmd.Parameters.AddWithValue("@perdidas", jugador.CantidadDePartidasPerdidas);
                cmd.Parameters.AddWithValue("@id", jugador.Id);

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