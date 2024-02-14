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

