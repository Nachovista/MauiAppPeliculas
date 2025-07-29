using MauiAppPeliculas.Models;

namespace MauiAppPeliculas.Services
{
    public class PeliculaService
    {
        private List<Pelicula> peliculas;

        public PeliculaService()
        {
            peliculas = new List<Pelicula>
            {
                new Pelicula { Id = 1, Titulo = "Avatar", Genero = "Ciencia Ficción", Año = 2009, Imagen = "avatar.png" },
                new Pelicula { Id = 2, Titulo = "Avengers: Endgame", Genero = "Acción", Año = 2019, Imagen = "endgame.png" },
                new Pelicula { Id = 3, Titulo = "Titanic", Genero = "Drama/Romance", Año = 1997, Imagen = "titanic.png" },
                new Pelicula { Id = 4, Titulo = "Star Wars: El despertar de la fuerza", Genero = "Ciencia Ficción", Año = 2015, Imagen = "starwars7.png" },
                new Pelicula { Id = 5, Titulo = "Jurassic World", Genero = "Aventura", Año = 2015, Imagen = "jurassicworld.png" },
                new Pelicula { Id = 6, Titulo = "El Rey León", Genero = "Animación", Año = 2019, Imagen = "lionking.png" },
                new Pelicula { Id = 7, Titulo = "The Fate of the Furious", Genero = "Acción", Año = 2017, Imagen = "fast8.png" },
                new Pelicula { Id = 8, Titulo = "Frozen II", Genero = "Animación", Año = 2019, Imagen = "frozen2.png" },
                new Pelicula { Id = 9, Titulo = "Iron Man 3", Genero = "Acción", Año = 2013, Imagen = "ironman3.png" },
                new Pelicula { Id = 10, Titulo = "Minions", Genero = "Animación", Año = 2015, Imagen = "minions.png" }
            };
        }

        public List<Pelicula> GetAll() => peliculas;

        public Pelicula? GetById(int id) => peliculas.FirstOrDefault(p => p.Id == id);

        public void Add(Pelicula pelicula)
        {
            pelicula.Id = peliculas.Count > 0 ? peliculas.Max(p => p.Id) + 1 : 1;
            peliculas.Add(pelicula);
        }

        public void Update(Pelicula pelicula)
        {
            var existente = GetById(pelicula.Id);
            if (existente != null)
            {
                existente.Titulo = pelicula.Titulo;
                existente.Genero = pelicula.Genero;
                existente.Año = pelicula.Año;
                existente.Imagen = pelicula.Imagen;
            }
        }

        public void Delete(int id)
        {
            var pelicula = GetById(id);
            if (pelicula != null)
                peliculas.Remove(pelicula);
        }
    }
}
