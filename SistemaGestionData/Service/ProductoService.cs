using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SistemaGestionData.Database;
using SistemaGestionData.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SistemaGestionData.Service
{
    public static class ProductoService
    {
         public static List<Producto> GetProductos()
        {
            List<Producto> productos = new List<Producto>;
        
            string connectionstring = @"Server=localhost\SQLEXPRESS; Database= coderhouse; Trusted_Connection=True"; 

            string query = "Select Id, Descripciones from producto";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionstring))
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader dr = comando.ExcuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read)
					            {
                                    var producto = new Producto();
                                    producto.Id = Convert.ToInt32(dr["Id"]);
                                    producto.Descripciones = dr["Descripciones"].ToString();

                                    producto.Add(producto);
                                }
                            }
                        }
                    }

                    conexion.Close();

                }
                return productos;
            }

            catch (Exception ex)
            {
                return productos;
            }
        }


        public static bool EliminarProductoPorId(int id)
        {
            using (CoderContext context = new CoderContext())
            {
                Producto ProductoAEliminar = context.Productos.Include(p => p.ProductoVendidos).Where(p => p.Id == id).FirstOrDefault();

                if (ProductoAEliminar is not null)
                {
                    context.Productos.Remove(ProductoAEliminar);
                    context.SaveChanges();
                    return true;
                }



            }

            return false;

        }




    }




   

}

