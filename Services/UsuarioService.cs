using MauiAppPeliculas.Models;

namespace MauiAppPeliculas.Services
{
    public class UsuarioService
    {
        private List<Usuario> usuarios = new List<Usuario>()
        {
            new Usuario { Id = 1, Nombre = "Administrador", Email = "admin@peliculas.com", Imagen = "user1.png", Rol = "admin", Contraseña = "admin123" },
            new Usuario { Id = 2, Nombre = "Usuario", Email = "usuario@peliculas.com", Imagen = "user2.png", Rol = "usuario", Contraseña = "usuario123" }
        };

        // Usuario actualmente logueado (en memoria)
        public Usuario? UsuarioLogueado { get; private set; }

        public List<Usuario> GetAll() => usuarios;

        public Usuario? GetById(int id) => usuarios.FirstOrDefault(u => u.Id == id);

        public Usuario? GetByEmailOrNombre(string usuario)
            => usuarios.FirstOrDefault(u => u.Email.Equals(usuario, StringComparison.OrdinalIgnoreCase)
                                         || u.Nombre.Equals(usuario, StringComparison.OrdinalIgnoreCase));

        public void Add(Usuario usuario)
        {
            usuario.Id = usuarios.Count > 0 ? usuarios.Max(u => u.Id) + 1 : 1;
            usuarios.Add(usuario);
        }

        public void Update(Usuario usuario)
        {
            var existente = GetById(usuario.Id);
            if (existente != null)
            {
                existente.Nombre = usuario.Nombre;
                existente.Email = usuario.Email;
                existente.Imagen = usuario.Imagen;
                existente.Rol = usuario.Rol;
                existente.Contraseña = usuario.Contraseña;
            }
        }

        public void Delete(int id)
        {
            var usuario = GetById(id);
            if (usuario != null)
                usuarios.Remove(usuario);
        }

        // ---- Lógica de login y logout ----
        public bool Login(string usuario, string contraseña)
        {
            var user = usuarios.FirstOrDefault(u =>
                (u.Email.Equals(usuario, StringComparison.OrdinalIgnoreCase)
                || u.Nombre.Equals(usuario, StringComparison.OrdinalIgnoreCase))
                && u.Contraseña == contraseña);

            if (user != null)
            {
                UsuarioLogueado = user;
                return true;
            }
            return false;
        }

        public void Logout()
        {
            UsuarioLogueado = null;
        }

        // Para registro (usuario común)
        public bool RegistrarUsuario(string nombre, string email, string contraseña, string imagen = "")
        {
            // Valida si ya existe
            if (usuarios.Any(u => u.Email == email || u.Nombre == nombre))
                return false;
            var nuevo = new Usuario
            {
                Nombre = nombre,
                Email = email,
                Contraseña = contraseña,
                Imagen = imagen,
                Rol = "usuario"
            };
            Add(nuevo);
            return true;
        }
    }
}
