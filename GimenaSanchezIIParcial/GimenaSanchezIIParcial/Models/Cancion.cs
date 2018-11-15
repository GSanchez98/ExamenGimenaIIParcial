using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Agregar los namespaces necesarios
using System.Data;
using System.Data.SqlClient;

namespace GimenaSanchezIIParcial.Models
{
    class Cancion
    {
        // Propiedades
        public string id { get; set; }
        public string Nombre { get; set; }
        public string Artista { get; set; }
        public string Album { get; set; }
        public string Genero { get; set; }
        public string AñoCreacion { get; set; }

        /// <summary>
        /// Método para la inserción de datos
        /// </summary>
        public static bool AgregarCancion(Cancion nuevaCancion)
        {
            Conexion conexion = new Conexion(@"(local)\SQLEXPRESS01", "BulletProofRecords");
            SqlCommand cmd = conexion.EjecutarComando("sp_AgregarCancion");

            // Establecer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;


            // Parámetros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.NVarChar, 200));
            cmd.Parameters["@nombre"].Value = nuevaCancion.Nombre;
            cmd.Parameters.Add(new SqlParameter("@Artista", SqlDbType.Int));
            cmd.Parameters["@Artista"].Value = nuevaCancion.Artista;
            cmd.Parameters.Add(new SqlParameter("@Album", SqlDbType.Int));
            cmd.Parameters["@Album"].Value = nuevaCancion.Album;
            cmd.Parameters.Add(new SqlParameter("@Genero", SqlDbType.NVarChar, 100));
            cmd.Parameters["@Genero"].Value = nuevaCancion.Genero;
            cmd.Parameters.Add(new SqlParameter("@AñoCreacion", SqlDbType.NVarChar, 100));
            cmd.Parameters["@AñoCreacion"].Value = nuevaCancion.AñoCreacion;


            // intentamos ejecutar el procedimiento
            try
            {
                conexion.EstablecerConexion();

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                // MessageBox.Show(ex.StackTrace);

                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }

        }

        /// <summary>
        /// Método para la eliminacion de datos
        /// </summary>
        public static bool EliminarCancion(Cancion EliminarCancion)
        {
            Conexion conexion = new Conexion(@"(local)\SQLEXPRESS01", "BulletProofRecords");
            SqlCommand cmd = conexion.EjecutarComando("sp_EliminarCancion");

            // Establecer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;


            // Parámetros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
            cmd.Parameters["@Id"].Value = EliminarCancion.id;

            // intentamos ejecutar el procedimiento
            try
            {
                conexion.EstablecerConexion();

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                // MessageBox.Show(ex.StackTrace);

                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        // método que se encarga de listar todos los elementos de 
        // la tabla cancion

        public static List<Cancion> ListarCanciones()
        {
            // declarmos la lista de tipo cliente
            List<Cancion> lascanciones = new List<Cancion>();

            // Establecemos la conexión
            Conexion conn = new Conexion(@"(local)\SQLEXPRESS01", "BulletProofRecords");

            // especificamos el query de consulta.
            string sql = "SELECT * FROM Music.Cancion";

            //Especificamos el comando y el tipo de comando
            SqlCommand cmd = conn.EjecutarComando(sql);

            try
            {
                // establecemos la conexión
                conn.EstablecerConexion();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Cancion laCancion = new Cancion();
                    laCancion.Nombre = rdr.GetString(0);
                    laCancion.Artista = rdr.GetString(1);
                    laCancion.Album = rdr.GetString(2);
                    laCancion.Genero = rdr.GetString(3);
                    laCancion.AñoCreacion = rdr.GetString(4);


                    // agregamos los datos a la lista
                    lascanciones.Add(laCancion);
                }
                return lascanciones;

            }
            catch (Exception)
            {

                return lascanciones;
            }
            finally
            {
                conn.CerrarConexion();
            }


        }
    }
}
