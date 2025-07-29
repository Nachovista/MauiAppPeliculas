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

## 🛠️ Cómo correr el proyecto

1. Clonar el repositorio:
    ```bash
    git clone https://github.com/tu-usuario/MauiAppPeliculas.git
    ```
2. Abrir la solución `.sln` en **Visual Studio 2022+**.
3. Ejecutar el proyecto en **modo Windows** o en emulador Android.

> **Nota:** Las imágenes deben estar en la carpeta `wwwroot/Imagenes` del proyecto.

## 📸 Capturas de pantalla

<!-- Podés agregar imágenes de tu app corriendo aquí -->
<img src="wwwroot/Imagenes/captura1.png" width="300" /> 
<img src="wwwroot/Imagenes/captura2.png" width="300" />

## 📚 Créditos / Autor

- **Autor:** [Tu nombre aquí]
- **Materia:** [Nombre de la materia o curso]
- **Mail:** [Tu email de contacto]
- **Profesor:** [Nombre del docente]

---

> Proyecto de práctica académica.  
> ¡Gracias por visitar el repositorio! 🚀
