﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace Data
{
    public class DInvoice
    {
        public List<invoices> Get()
        {
            string connectionString = "Data Source=LAB1504-27\\SQLEXPRESS;Initial Catalog=db;User ID=userTecsup;Password=123456";

            List<invoices> Lista_invoices = new List<invoices>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();
                string query = "usp_ListarInvoice";

                using (SqlCommand command = new SqlCommand(query, connection))
                {


                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Verificar si hay filas
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                // Leer los datos de cada fila
                                Lista_invoices.Add(new invoices
                                {
                                    invoice_id = (int)reader["idproducto"],
                                    customer_id = reader["nombreProducto"].ToString(),
                                    date = (int)reader["idProveedor"],
                                    total = (int)reader["idCategoria"],
                                });

                            }
                        }
                    }
                }

                // Cerrar la conexión
                connection.Close();
            }
            return Lista_invoices;
        }
    }
}
