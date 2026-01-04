# Sistema de Gestión Veterinaria — “Veterinaria Naricitas” (C# WinForms + SQL Server)

Aplicación de escritorio desarrollada con **Windows Forms** en **C# (.NET Framework)** para la gestión básica de una clínica veterinaria.  
Permite **registrar y administrar clientes y sus mascotas**, además de generar **reportes** por especie/edad/peso y cantidad de mascotas por cliente.

> Proyecto realizado con fines educativos.

## Funcionalidades
- Inicio de sesión y registro de usuarios
- Menú principal:
  - Gestión de clientes
  - Reportes solicitados
- Registro y visualización de clientes
- Asociación de mascotas a cada cliente con vista detallada
- Conexión a base de datos para almacenamiento persistente (SQL Server)

## Estructura / Arquitectura
Proyecto dividido en **dos capas**:
- **Interfaz (WinForms):** formularios y navegación de la app
- **Servicios y datos:** modelos, DAO y lógica de negocio

Además:
- Formulario principal “Padre” y formularios “Hijos”
- Validaciones para evitar errores de uso

## Requisitos
- **Visual Studio** (recomendado)
- **SQL Server Management Studio (SSMS) v20.2** (o compatible)
- **SQL Server**
- **.NET Framework** 

## Instalación (Base de datos)
1. Restaurá la base de datos con el archivo:
   - `db_veterinaria.bak` (incluido en el repositorio)
2. En **SQL Server Management Studio**:
   - Databases → **Restore Database** → seleccioná el `.bak` → Restore

## Configurar conexión (App config)
1. Editá el archivo:
   - `/TP_Veterinaria/bin/Debug/TP_Veterinaria.exe.config`
2. Actualizá el **server** con el nombre/instancia de tu SQL Server (y cualquier dato necesario según tu conexión).

> Tip: si usás `SQLEXPRESS`, muchas veces el server es: `localhost\\SQLEXPRESS`.

## Credenciales demo
- Podés iniciar con:
  - **Usuario:** `admin`
  - **Password:** `admin`
- O registrarte en “Registrarse” y luego iniciar sesión con tus credenciales.

## Guía de uso (pantallas)

### Login
- Registrate en “Registrarse” y luego iniciá sesión.
- Alternativa: ingresar con `admin / admin`.

### Menú principal
- **Gestión de Clientes**
- **Reportes Solicitados**
- **Cerrar Sesión**

### Gestión de clientes
- Registrar un cliente (Nombre + DNI)
- Ver clientes registrados

### Mostrar clientes
- Lista de clientes con botón **“Agregar Mascotas”**
- Seleccioná un cliente y cargá su mascota
- Incluye **2 clientes de prueba** con sus mascotas (están en la DB restaurada)

### Agregar mascota
- Registrar mascota: especie, nombre, peso y edad
- Ver información general de la especie
- Lista de mascotas del cliente (actualizable)
- Botón “Cambiar de Cliente”

### Reportes solicitados
- Reporte de peso (**min / max / promedio**) por **rango de edad** y especie
- Cantidad de mascotas registradas por cliente

## Screenshots
📌 Capturas de pantalla del sistema disponibles en mi LinkedIn:
www.linkedin.com/in/nahuelflorentin-dev

## Estado
Proyecto educativo para práctica de WinForms, capas, DAO, validaciones y persistencia con SQL Server.

## Licencia
Este proyecto está bajo licencia MIT. Ver archivo LICENSE.
