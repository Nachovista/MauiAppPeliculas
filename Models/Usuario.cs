namespace MauiAppPeliculas.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Imagen { get; set; } // Ruta local o nombre de archivo
        public string Contraseña { get; set; }
        public string Rol { get; set; }


    }
}