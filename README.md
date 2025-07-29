# 🎬 MauiAppPeliculas

Aplicación móvil desarrollada en **.NET MAUI Blazor Hybrid** para gestión y visualización de películas y usuarios.

## 🚀 Características principales

- **ABM Maestro-Detalle** de Usuarios (con imágenes de perfil)
- **ABM Maestro-Detalle** de Películas (con imágenes de carátula)
- **Autenticación de usuarios** (login y registro)
- **Roles**: Admin y Usuario común (con diferentes permisos)
- **Permisos**: Solo el Admin puede agregar, editar y eliminar registros; el usuario común solo visualiza
- **Buscador** de películas (por título, año, género, descripción)
- **UI moderna** con Bootstrap 5 y Bootstrap Icons
- **Sin base de datos**: datos en memoria, ideal para práctica y prototipo

## 👤 Roles y permisos

| Rol     | Ver películas | Agregar/Editar/Eliminar películas | Ver usuarios | Agregar/Editar/Eliminar usuarios |
|---------|:-------------:|:---------------------------------:|:------------:|:-------------------------------:|
| Admin   |      ✔️       |               ✔️                  |      ✔️      |              ✔️                 |
| Usuario |      ✔️       |               ❌                  |      ✔️      |              ❌                 |


Id = 1, Nombre = "Administrador", Email = "admin@peliculas.com", Rol = "admin", Contraseña = "admin123"

Id = 2, Nombre = "Usuario", Email = "usuario@peliculas.com", Rol = "usuario", Contraseña = "usuario123" 



## 🖥️ Pantallas principales

- **Login y Registro**
- **Listado de Películas** (cards adaptables y buscador)
- **Listado de Usuarios** (tabla)
- **Formulario modal** para ABM (Bootstrap Modal)
- **Confirmación de borrado** (modal)
- **Home con acceso rápido** (botones/iconos)

## ⚙️ Tecnologías utilizadas

- [.NET 8.0 MAUI Blazor Hybrid](https://learn.microsoft.com/en-us/dotnet/maui/)
- [Bootstrap 5](https://getbootstrap.com/)
- [Bootstrap Icons](https://icons.getbootstrap.com/)



## 📚 Créditos / Autor

- **Autor:** Ignacio Agustín Rodríguez Damín
- **Materia:** Programación III - Aplicaciones Móviles 2025
- **Mail:** nachovista@gmail.com
- **Profesor:** Federico Trani
- **Instituto Tecnologico de Educacion Superior - ITES -**

---

> Proyecto de práctica académica.  
> ¡Gracias por visitar el repositorio! 🚀
