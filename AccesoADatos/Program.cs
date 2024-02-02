using AccesoADatos.database;
using AccesoADatos.Models;

namespace AccesoADatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            // Prueba Usuarios
            //
            //try
            //{
            //    Producto usuarioObtenido = db.ObtenerProducto(2);
            //    ;
            //}
            //catch (Exception ex) { Console.WriteLine(ex.Message);}
            //List<Usuario> usuariosObtenidos = db.ListarUsuarios();
            //Usuario user = new("Emiliano", "Flores", "Emi", "Contraseña", "emiflores@mail.ocm");
            //if (db.ModificarUsuario(2, user))
            //{
            //    Console.WriteLine("Se actualizo un usuario");
            //}
            //else
            //{
            //    Console.WriteLine("No se pudo actualizo un usuario");
            //}
            //if (db.BorrarUsuarioPorId(3))
            //{
            //    Console.WriteLine("Se borro un usuario");
            //}
            //else
            //{
            //    Console.WriteLine("No se pudo borrar un usuario");
            //}

            //
            // Prueba Productos
            //
            //try
            //{
            //Producto productoObtenido = ProductoData.ObtenerProducto(2);
            //    ;
            //}
            //catch (Exception ex) { Console.WriteLine(ex.Message); }
            //List<Producto> productos = ProductoData.ListarPrductos();
            //;
            //Producto producto = new("Remera", 17500, 19000, 15, 2);
            //ProductoData.CrearProducto(producto);
            //ProductoData.EliminarProducto(7);
            //ProductoData.ModificarProducto(4, producto);

            //
            // Prueba ProductosVendido
            //
            //try
            //{
            //    ProductoVendido productovendidoObtenido = ProductoVendidoData.ObtenerProductoVendido(2);
            //    ;
            //}
            //catch (Exception ex) { Console.WriteLine(ex.Message); }
            //List<ProductoVendido> productos = ProductoVendidoData.ListarPrductosVendidos();
            //ProductoVendido producto = new(1, 1, 1);
            //ProductoVendidoData.CrearProductoVendido(producto);
            //ProductoVendidoData.EliminarProducto(7);
            //ProductoVendidoData.ModificarProducto(4, producto);

            //
            // Prueba Venta
            //
            //try
            //{
            //    Venta ventaObtenida = VentaData.ObtenerVenta(2);
            //    ;
            //}
            //catch (Exception ex) { Console.WriteLine(ex.Message); }
            List<Venta> venta = VentaData.ListarVentas();
            //ProductoVendido Venta = new( "venta", 1);
            //ProductoVendidoData.CrearProductoVendido(venta);
            //ProductoVendidoData.EliminarProducto(7);
            //ProductoVendidoData.ModificarProducto(4, venta);
        }
    }
}
