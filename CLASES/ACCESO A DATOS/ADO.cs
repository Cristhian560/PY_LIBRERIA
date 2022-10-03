using CLASES.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES.ACCESO_A_DATOS
{
    public static class ADO
    {
        public static string StringConexion = Properties.Resources.ConnectionString;

        public static SqlConnection Conexion = null;

        public static string Conectar()
        {
            try
            {
                // CREO LA CONEXION //
                Conexion = new SqlConnection(StringConexion);
            }
            catch (Exception)
            {
                throw new Exception("ERROR EN LA CONFIGURACION DE LA CONEXION A LA BASE DE DATOS..");
            }

            try
            {
                //ABRO LA CONEXION //

                Conexion.Open();
            }
            catch (Exception)
            {

                throw new Exception("ERROR EN LA CONEXION A LA BASE DE DATOS..");
            }
            try
            {
                //RETORNAR INFO DE LA CONEXION //

                return "CONECTADO A: " + Conexion.Database + "UTILIZANDO LA CADENA DE CONEXION: " + Conexion.ConnectionString;
            }
            catch (Exception)
            {

                throw new Exception("ERROR EN DEVOLVER EL NOMBRE DE LA CONEXION...!!");
            }

            finally
            {
                //CIERRO LA CONEXION DESPUES DE HABER REALIZADO LA OPERACION DESEADA // 

                if (Conexion.State == System.Data.ConnectionState.Open)
                {
                    Conexion.Close();
                }
            }
        }
        /// <summary>
        /// Hace una consulta a la base de datos , tabla Productos
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static DataTable Productos()
        {
            try
            {
                Conexion = new SqlConnection(StringConexion);
                SqlCommand cmd = new("SP_PRODUCTOS", Conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };

                Conexion.Open();

                DataTable tabla = new DataTable();
                tabla.Load(cmd.ExecuteReader());

                return tabla;
            }
            catch (Exception)
            {
                throw new Exception("ERROR EN LA CONEXION DE PRODUCTOS...");
            }
            finally
            {
                if (Conexion.State == System.Data.ConnectionState.Open)
                {
                    Conexion.Close();
                }
            }
        }
        /// <summary>
        /// Crea una lista de Objetos del tipo Producto
        /// </summary>
        /// <param name="tabla">una consulta a la tabla productos</param>
        /// <returns>lista de Productos</returns>
        public static List<Producto> ListaProductos(DataTable tabla)
        {
            List<Producto>productos = new();
            foreach (DataRow fila in tabla.Rows)
            {
                Producto p = new()
                {
                    IdProducto = Convert.ToInt32(fila.ItemArray[0]),
                    Nombre = fila.ItemArray[1].ToString(),
                    Descripcion = fila.ItemArray[2].ToString(),
                    Marca = fila.ItemArray[3].ToString(),
                    Precio = Convert.ToDouble(fila.ItemArray[4]),
                    Stock = Convert.ToInt32(fila.ItemArray[5]),
                    Borrado = ""
                };
                productos.Add(p);
            }
            return productos;
        }
        public static DataTable Credenciales()
        {
            try
            {
                Conexion = new SqlConnection(StringConexion);
                SqlCommand cmd = new("SP_CREDENCIALES", Conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };

                Conexion.Open();
                DataTable tabla = new DataTable();
                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (Exception)
            {
                throw new Exception("ERROR EN LA CONEXION...");
            }
            finally
            {
                if (Conexion.State == System.Data.ConnectionState.Open)
                {
                    Conexion.Close();
                }
            }
        }
        public static List<Credencial> ListaCredenciales(DataTable tabla)
        {
            List<Credencial> credenciales = new();
            foreach (DataRow fila in tabla.Rows)
            {
                Credencial c = new()
                {
                    Nombre = fila["nombre"].ToString(),
                    Usuario = fila["usuario"].ToString(),
                    Contrasenia = fila["contrasenia"].ToString()
                };
                credenciales.Add(c);
            }
            return credenciales;
        }
        




































        //public static int ContarProductos()
        //{
        //    try
        //    {
        //        Conexion = new SqlConnection(StringConexion);

        //        SqlCommand a = new SqlCommand("SELECT COUNT(*) FROM Products", Conexion);

        //        Conexion.Open();

        //        return Convert.ToInt32(a.ExecuteScalar());
        //    }
        //    catch (Exception c)
        //    {

        //        throw new Exception("ERROR EN LA CONEXION DE PRODUCTOS...");
        //    }

        //    finally
        //    {
        //        if (Conexion.State == System.Data.ConnectionState.Open)
        //        {
        //            Conexion.Close();
        //        }

        //    }
        //}

        //public static List<Empleados> listarEmpleados()
        //{

        //    try
        //    {
        //        Conexion = new SqlConnection(StringConexion);

        //        SqlCommand h = new SqlCommand("SELECT EmployeeID codigo, firstname nombre, lastname apellido from Employees", Conexion);

        //        Conexion.Open();

        //        SqlDataReader data_reader = null;

        //        List<Empleados> listaempleados = new List<Empleados>();

        //        data_reader = h.ExecuteReader();

        //        while (data_reader.Read() == true)
        //        {
        //            Empleados e1 = new Empleados(Convert.ToInt32(data_reader[0]), data_reader[1].ToString(), data_reader[2].ToString());

        //            listaempleados.Add(e1);
        //        }

        //        return listaempleados;

        //    }


        //    catch (Exception c)
        //    {

        //        throw new Exception("ERROR EN LA CONEXION DE PRODUCTOS...");
        //    }

        //    finally
        //    {
        //        if (Conexion.State == System.Data.ConnectionState.Open)
        //        {
        //            Conexion.Close();
        //        }

        //    }



        //}

        //public static List<string> TopTenProductosCaros()
        //{

        //    try
        //    {
        //        Conexion = new SqlConnection(StringConexion);

        //        SqlCommand p = new SqlCommand("Ten Most Expensive Products", Conexion);

        //        p.CommandType = System.Data.CommandType.StoredProcedure;

        //        Conexion.Open();

        //        SqlDataReader data_reader = null;

        //        List<string> productos = new List<string>();

        //        data_reader = p.ExecuteReader();

        //        while (data_reader.Read() == true)
        //        {
        //            productos.Add("Productos: " + data_reader["TenMostExpensiveProducts"] + " Precio: $" + data_reader["UnitPrice"]);
        //        }

        //        return productos;

        //    }


        //    catch (Exception c)
        //    {

        //        throw new Exception("ERROR EN LA CONEXION DE PRODUCTOS...");
        //    }

        //    finally
        //    {
        //        if (Conexion.State == System.Data.ConnectionState.Open)
        //        {
        //            Conexion.Close();
        //        }

        //    }



        //}

        //public static List<string> VentasPorPeriodos(DateTime DESDE, DateTime HASTA)
        //{

        //    try
        //    {
        //        Conexion = new SqlConnection(StringConexion);

        //        SqlCommand p = new SqlCommand("Sales by Year", Conexion);

        //        SqlParameter v_desde = new SqlParameter("@Beginning_Date", DESDE);

        //        SqlParameter v_hasta = new SqlParameter("@Ending_Date", HASTA);

        //        p.Parameters.Add(v_desde);
        //        p.Parameters.Add(v_hasta);

        //        p.CommandType = System.Data.CommandType.StoredProcedure;

        //        Conexion.Open();

        //        SqlDataReader data_reader = null;

        //        List<string> ventas = new List<string>();

        //        data_reader = p.ExecuteReader();

        //        while (data_reader.Read() == true)
        //        {
        //            ventas.Add("Productos: " + data_reader["TenMostExpensiveProducts"] + " Precio: $" + data_reader["UnitPrice"]);
        //        }

        //        return ventas;

        //    }


        //    catch (Exception c)
        //    {

        //        throw new Exception("ERROR EN LA CONEXION DE PRODUCTOS...");
        //    }

        //    finally
        //    {
        //        if (Conexion.State == System.Data.ConnectionState.Open)
        //        {
        //            Conexion.Close();
        //        }

        //    }



        //}

    }
}
