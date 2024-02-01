using AccesoaDatos.database;
using AccesoADatos.Models;

namespace AccesoADatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductoData db = new ProductoData();
            //try
            //{
            //    Producto usuarioObtenido = db.ObtenerProducto(2);
            //    Console.WriteLine("Hello, World!");
            //}
            //catch (Exception ex) { Console.WriteLine(ex.Message);}
            List<Producto> productos = db.ListarPrductos();
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
            //List<Usuario> usuariosObtenidos = db.ListarUsuarios();
            Console.WriteLine("Hello, World!");
        }
    }
}
