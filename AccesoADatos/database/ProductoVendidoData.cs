using AccesoADatos.Models;
using System.Data.SqlClient;

namespace AccesoADatos.database
{
    public class ProductoVendidoData
    {
        private string stringConnection;
        public ProductoVendidoData()
        {
            //this.stringConnection = "Data Source=DESKTOP-TRA01FH;Database=coderhouse;Trusted_Connection=True;";
            this.stringConnection = "Data Source=DESKTOP-SJ6J45C;Database=coderhouse;Trusted_Connection=True;";
        }
        public ProductoVendido ObtenerProductoVendido(int id)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {
                string query = "SELECT * FROM ProductoVendido where id = @id";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("id", id);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int idObtenido = Convert.ToInt32(reader["id"]);
                    int idproducto = Convert.ToInt32(1);
                    int stock = Convert.ToInt32(3);
                    int idventa = Convert.ToInt32(3);
                    ProductoVendido productonuevo = new ProductoVendido(idObtenido, idproducto, stock, idventa);
                    return productonuevo;
                }
                else
                {
                    throw new Exception("Id no encontrado");
                }
            }
        }
    }
}
