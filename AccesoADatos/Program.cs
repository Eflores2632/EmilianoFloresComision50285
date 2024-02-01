using AccesoaDatos.database;

namespace AccesoADatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            // Prueba Usuarios
            //
            //UsuarioData db = new UsuarioData();
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
            ProductoData db = new();
            //try
            //{
            //    Producto usuarioObtenido = db.ObtenerProducto(2);
            //    ;
            //}
            //catch (Exception ex) { Console.WriteLine(ex.Message); }
            List<Producto> productos = db
            ;
            //Producto producto = new("Remera", 17500, 19000, 15, 2);
            //db.CrearProducto(producto);
            //db.EliminarProducto(7);
            //db.ModificarProducto(4, producto);
        }
    }
}
