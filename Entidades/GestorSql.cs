using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Xml.Linq;

namespace Entidades
{
    public static class GestorSql
    {
        private static string conexion;
        private static SqlConnection conexSql;

        /// <summary>
        /// asgina un string en el atributo conexion 
        /// nombre del server + nombre de la base de datos + trustedConnection true
        /// </summary>
        static GestorSql()
        {
            GestorSql.conexion = $"Server=.\\MSSQLSERVER01 ;Database=BD;Trusted_Connection =true";
        }//FDC

        /// <summary>
        /// Muestra por consola toda la tabla.
        /// En modo de "informe".
        /// </summary>
        /// <param name="TABLA"> Nombre de la tabla</param>
        /// <returns>Tabla en formato informe</returns>

        public static string LeerTablaCompleta(string TABLA)
        {
            try
            {
                StringBuilder sbaux = new StringBuilder();
                using (GestorSql.conexSql = new SqlConnection(GestorSql.conexion))
                {
                    GestorSql.conexSql.Open();
                    string QWERY = $"SELECT * FROM {TABLA}";
                    SqlCommand comando = new SqlCommand(QWERY, GestorSql.conexSql);
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("INFORME");
                        while (reader.Read())
                        {
                            sb.AppendLine("/////////////////////");
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                sb.AppendLine($"{reader.GetName(i)}: {reader[reader.GetName(i)]}");
                            }
                            sbaux.Append(sb);
                            sb.Clear();
                        }
                    }
                }
                GestorSql.conexSql.Close();
                return sbaux.ToString();
            }
            catch (SqlException sqlEx)
            {
                return $"Error en la base de datos. Verifique el nombre de la tabla.\n" +
                    $"{sqlEx.Message}\n" +
                    $"Codigo: {sqlEx.ErrorCode}";
            }
            catch (Exception ex)
            {
                return $"Error ->{ex.Message}. /n" +
                    $"Codigo de error{ex.HResult}";
            }
        }//FDM

        /// <summary>
        /// Funciona con 4 datos. 2 para buscar la fila y 2 para insertar el dato nuevo.
        /// columnaMod y dato son los datos nuevos y columnabus y datoBus son los datos que se usan en 
        /// la busqueda de la fila a modificar.
        /// </summary>
        /// <param name="columnaMod"> Nombre de la columna en la que se inserta el dato.</param>
        ///<param name="dato"> El dato nuevo.</param>
        ///<param name="columnaBus">Columna para buscar la fila.</param>
        ///<param name="datoBus">Dato para identificar la fila. Debe ser de la columna buscada.</param>
        ///<param name="tabla">El nombre de la tabla en la que se desea buscar e inyectar.</param>
        /// <returns>Tabla en formato informe</returns>
        public static string modificarDatoDeTabla(string columnaMod, string dato, string columnaBus
            , string datoBus, string tabla)
        {
            try 
            {
                using (GestorSql.conexSql = new SqlConnection(GestorSql.conexion))
                {
                    GestorSql.conexSql.Open();
                    string QWERY = consultarDatos(columnaMod, columnaBus, tabla);
                    using (SqlCommand comando = new SqlCommand(QWERY, GestorSql.conexSql))
                    {
                        comando.Parameters.AddWithValue("@newName", dato);
                        comando.Parameters.AddWithValue("@idselection", datoBus);
                        int modificaciones = comando.ExecuteNonQuery();
                        return ($"Se modificaron {modificaciones}");
                    }
                }
            }
            catch (SqlException SqlExc)
            {
                return $"Error en la base de datos. Verifique el nombre de la tabla.\n" +
                    $"{SqlExc.Message}\n" +
                    $"Codigo: {SqlExc.ErrorCode}";
            }
            catch (Exception ex)
            {
                return $"Error ->{ex.Message}. /n" +
                  $"Codigo de error{ex.HResult}";
            }
            
        }//FDM


        /// <summary>
        /// Edita el QWERY. 
        /// Se llama en modificarDatos.
        /// </summary>
        /// <returns>Un stringBuilder.tostring()</returns>
        public static string consultarDatos(string CM, string CB, string tabla)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"UPDATE {tabla} set {CM} = @newName where" +
                $" {CB} = @idselection");
            return sb.ToString();
        }//FDM

        /// <summary>
        /// Busca un dato en la tabla.
        /// </summary>
        /// <param name="tabla"> Nombre de la tabla</param>
        /// <param name="columna"> El tipo de dato a buscar</param>
        /// <param name="dato">El dato buscado</param>
        public static string BuscarDato(string tabla, string columna, string dato)
        {
            try 
            {
                StringBuilder sb = new StringBuilder();
                using (GestorSql.conexSql = new SqlConnection(GestorSql.conexion))
                {
                    GestorSql.conexSql.Open();
                    string QWERY = $"SELECT * FROM {tabla} where ({columna}='{dato}')";
                    SqlCommand comando = new SqlCommand(QWERY, GestorSql.conexSql);
                    using (SqlDataReader read = comando.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            for (int i = 0; i < read.FieldCount; i++)
                            {
                                sb.AppendLine($"{read.GetName(i)} : {read[i]}");
                            }
                        }
                    }
                }
                return sb.ToString();
            }
            catch (SqlException SqlExc)
            {
                return $"Error en la base de datos. Verifique el nombre de la tabla.\n" +
                    $"{SqlExc.Message}\n" +
                    $"Codigo: {SqlExc.ErrorCode}";
            }
            catch (Exception ex)
            {
                return $"Error ->{ex.Message}. /n" +
                  $"Codigo de error{ex.HResult}";
            }

        }//FDM

        /// <summary>
        /// Envia las instrucciones de como esta compuesta la tabla
        /// al formulario de carga
        /// </summary>
        /// <param name="tabla">El nombre de la tabla que se quiere usar.</param>
        /// <param name="lista">Una lista de string con los datos nuevos.</param>
        public static string Instrucciones(string tabla)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                Dictionary<string, string> dict = new Dictionary<string, string>();
                using (GestorSql.conexSql = new SqlConnection(GestorSql.conexion))
                {
                    GestorSql.conexSql.Open();
                    string QUERY = $"SELECT * FROM {tabla}";
                    SqlCommand comando = new SqlCommand(QUERY, GestorSql.conexSql);
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        for (int i = 0; i < reader.GetColumnSchema().Count; i++)
                        {
                            sb.AppendLine($"Columna : {reader.GetName(i)} --> TIPO :{reader.GetDataTypeName(i)}");
                        }
                    }
                    GestorSql.conexSql.Close();
                }
                return sb.ToString();
            }
            catch (SqlException sqlEx)
            {

                return $"Error en la base de datos. Verifique el nombre de la tabla.\n{sqlEx.Message}\\n  Codigo: {sqlEx.ErrorCode}";

            }
            catch (Exception ex)
            {
                return $"Error ->{ex.Message}. /n" +
                    $"Codigo de error{ex.HResult}";
            }
        }///FDM

        /// <summary>
        /// Carga datos a la base,
        /// se lo llama desde el formulariode carga.
        /// </summary>
        /// <param name="QUERY">Es un QUERY de carga.</param>
        public static void Carga(string QUERY)
        {
            try 
            {
                using (GestorSql.conexSql = new SqlConnection(GestorSql.conexion))
                {
                    GestorSql.conexSql.Open();
                    using (SqlCommand comando = new SqlCommand(QUERY, GestorSql.conexSql))
                    {
                        comando.ExecuteNonQuery();
                    }
                    GestorSql.conexSql.Close();
                }
            }
            catch (SqlException Sqlex)
            {
                throw new Exception(Sqlex.InnerException.Message);
            }
            catch (Exception ex)
            {
                File.WriteAllText(Directory.GetCurrentDirectory()+"ArchivoExcepcion.txt",ex.Message);
            }
           
        }///FDM

        /// <summary>
        /// Se utiliza para crear una tabla.
        /// </summary>
        /// <param name="Query">Un query (string) que crea una tabla con columnas asignadas a la cadena desde el formulario.</param>     
        public static void CrearTabla(string Query)
        {
            try 
            {
                using (GestorSql.conexSql = new SqlConnection(GestorSql.conexion))
                {
                    GestorSql.conexSql.Open();
                    using (SqlCommand comando = new SqlCommand(Query, GestorSql.conexSql))
                    {
                        comando.ExecuteNonQuery();
                    }
                    GestorSql.conexSql.Close();
                }
            }
            catch (SqlException Sqlex)
            {
                throw new Exception(Sqlex.InnerException.Message);
            }
            catch (Exception ex)
            {
                File.WriteAllText(Directory.GetCurrentDirectory() + "ArchivoExcepcion.txt", ex.Message);
            }
        }///FDM
    }
}