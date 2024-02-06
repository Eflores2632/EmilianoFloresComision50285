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
            //    Usuario usuarioObtenido = UsuarioData.ObtenerUsuario(2);
            //    ;
            //}
            //catch (Exception ex) { Console.WriteLine(ex.Message); }

            //try
            //{
            //    List<Usuario> usuariosObtenidos = UsuarioData.ListarUsuarios();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Usuario user = new("Emiliano", "Flores", "Emi", "Contraseña", "emiflores@mail.ocm");

            //try
            //{
            //    if (UsuarioData.ModificarUsuario(2, user))
            //    {
            //        Console.WriteLine("Se actualizo un usuario");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No se pudo actualizo un usuario");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //try
            //{
            //    if (UsuarioData.EliminarUsuario(3))
            //    {
            //        Console.WriteLine("Se borro un usuario");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No se pudo borrar un usuario");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //
            // Prueba Productos
            //
            //try
            //{
            //    Producto productoObtenido = ProductoData.ObtenerProducto(2);
            //    ;
            //}
            //catch (Exception ex) { Console.WriteLine(ex.Message); }
            //try
            //{
            //    List<Producto> productos = ProductoData.ListarPrductos();
            //    ;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Producto producto = new("Remera", 17500, 19000, 15, 2);

            //try
            //{
            //    ProductoData.CrearProducto(producto);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //try
            //{
            //    ProductoData.EliminarProducto(7);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //try
            //{
            //    ProductoData.ModificarProducto(4, producto);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //
            // Prueba ProductosVendido
            //
            //try
            //{
            //    ProductoVendido productovendidoObtenido = ProductoVendidoData.ObtenerProductoVendido(2);
            //    ;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //try
            //{
            //    List<ProductoVendido> productos = ProductoVendidoData.ListarPrductosVendidos();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //ProductoVendido producto = new(1, 1, 1);
            //try
            //{
            //    ProductoVendidoData.CrearProductoVendido(producto);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //try
            //{
            //    ProductoVendidoData.EliminarProducto(1);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //try
            //{
            //    ProductoVendidoData.ModificarProducto(4, producto);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //
            // Prueba Venta
            //
            try
            {
                Venta ventaObtenida = VentaData.ObtenerVenta(2);
                ;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                List<Venta> ventalista = VentaData.ListarVentas();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Venta venta = new("venta", 1);

            try
            {
                VentaData.CrearVenta(venta);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                VentaData.EliminarVenta(4);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                VentaData.ModificarVenta(4, venta);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
