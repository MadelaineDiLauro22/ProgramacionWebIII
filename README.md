
# ProgramacionWebIII

## Descripción

**ProgramacionWebIII** es un proyecto desarrollado en el contexto de la asignatura Programación Web III. Este proyecto abarca conceptos avanzados de desarrollo web, utilizando tecnologías modernas y aplicando buenas prácticas de programación para crear aplicaciones web robustas.

## Requisitos

Antes de ejecutar el proyecto, asegúrate de tener lo siguiente instalado:

- **Visual Studio 2022** (o una versión compatible) con soporte para ASP.NET y C#.
- **.NET SDK 6.0** o superior.
- **SQL Server** o cualquier otro sistema de gestión de bases de datos compatible (si es necesario).

## Instalación y Ejecución

### Paso 1: Clonar el repositorio

Clona el repositorio en tu máquina local con el siguiente comando:

```bash
git clone https://github.com/MadelaineDiLauro22/ProgramacionWebIII.git
```

### Paso 2: Abrir el proyecto en Visual Studio

1. Abre **Visual Studio**.
2. Selecciona **Open a Project or Solution** (Abrir proyecto o solución) desde el menú.
3. Navega hasta la carpeta donde clonaste el repositorio y selecciona el archivo de solución `.sln`.
4. Visual Studio cargará el proyecto y sus dependencias.

### Paso 3: Ejecutar el proyecto

1. Configura el proyecto como **Proyecto de inicio**. Haz clic derecho en la solución y selecciona **Set as StartUp Project**.
2. Verifica que la base de datos (si se utiliza) esté configurada y corriendo.
3. Ejecuta el proyecto haciendo clic en el botón **Run** o presionando `F5`.
4. El navegador se abrirá automáticamente en la URL del servidor local, que por defecto es:

   ```
   https://localhost:5001/
   ```

### Paso 4: Configuración de base de datos (opcional)

Si el proyecto incluye una base de datos, asegúrate de que tu **SQL Server** esté corriendo y de actualizar las cadenas de conexión en el archivo `appsettings.json` con los detalles correctos de tu servidor y base de datos.

## Estructura del Proyecto

- **`Controllers/`**: Controladores que manejan las solicitudes HTTP y coordinan las respuestas.
- **`Models/`**: Contiene las clases de modelo que representan los datos de la aplicación.
- **`Views/`**: Archivos de vista (Razor) que generan el HTML enviado al navegador.
- **`wwwroot/`**: Carpeta donde se alojan los archivos estáticos como CSS, JS e imágenes.

## Contribuciones

Si deseas colaborar con este proyecto:

1. Haz un **fork** del repositorio.
2. Crea una nueva rama para tus modificaciones: `git checkout -b mi-nueva-rama`.
3. Realiza tus cambios y haz un **commit**: `git commit -m "Descripción de los cambios"`.
4. Envía los cambios a tu repositorio: `git push origin mi-nueva-rama`.
5. Abre un **pull request** para que tus cambios sean revisados.
