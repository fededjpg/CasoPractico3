using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebServiceLibros.DataLibrosTableAdapters;

namespace WebServiceLibros
{
    /// <summary>
    /// Descripción breve de Libros
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Libros : System.Web.Services.WebService
    {
        //public string data = "jola\mundo";
        // LibrosTableAdapters DataLibros = new LibrosTableAdapters();
        //DataLibros dsDatos = new DataLibros(); 


        // [WebMethod]
        // public DataSet MostrarLibros() 
        // {
        //    this.DataLibros.Fill(this.dsDatos.Libros);
        //    return dsDatos;
        //}

        [WebMethod]
        public DataSet Lista()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=DEVS\\SQLEXPRESS; Initial Catalog=Libros; Integrated Security=True;";
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM LIBRERIA", conexion);
            DataSet ds = new DataSet();
            data.Fill(ds);
            return ds;
        }

        [WebMethod]
        public DataSet Eliminar(int id)
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=DEVS\\SQLEXPRESS; Initial Catalog=Libros; Integrated Security=True;";
            SqlDataAdapter data = new SqlDataAdapter("DELETE FROM LIBRERIA WHERE id="+id, conexion);
            DataSet ds = new DataSet();
            data.Fill(ds);
            return ds;
        }

        [WebMethod]
        public DataSet addBook(String Titulo, String Autor, Double Precio, String Fecha )
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=DEVS\\SQLEXPRESS; Initial Catalog=Libros; Integrated Security=True;";
            SqlDataAdapter data = new SqlDataAdapter("INSERT INTO LIBRERIA VALUES('" + Titulo + "', '" + Autor + "', "+ Precio +", '"+ Fecha +"')", conexion);
            DataSet ds = new DataSet();
            data.Fill(ds);
            return ds;
        }

        [WebMethod]
        public DataSet getOneBook(Int32 Id)
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=DEVS\\SQLEXPRESS; Initial Catalog=Libros; Integrated Security=True;";
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM LIBRERIA WHERE Id=" + Id, conexion);
            DataSet ds = new DataSet();
            data.Fill(ds);
            return ds;
        }

        [WebMethod]
        public DataSet updateBook(Int32 Id, String Titulo, String Autor, Double Precio, String Fecha)
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=DEVS\\SQLEXPRESS; Initial Catalog=Libros; Integrated Security=True;";
            SqlDataAdapter data = new SqlDataAdapter("Update LIBRERIA SET Titulo='" + Titulo + "', Autor='" + Autor + "', Precio= " + Precio + ", AñoPublicacion='" + Fecha + "' WHERE Id="+Id, conexion);
            DataSet ds = new DataSet();
            data.Fill(ds);
            return ds;
        }
    }
}
