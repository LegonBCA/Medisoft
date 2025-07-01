# Sistema de Gestión Médico

Este proyecto es una aplicación de escritorio desarrollada en C# (.NET Framework) para la gestión integral de usuarios, sesiones y documentos en un entorno médico. El sistema está diseñado para facilitar la administración tanto para usuarios como para administradores, permitiendo un control eficiente y seguro de la información.

## Características principales

- **Inicio de sesión seguro** para usuarios y administradores.
- **Recuperación de contraseña** mediante formulario de contacto.
- **Gestión de usuarios:** registro, actualización y eliminación de usuarios y administradores.
- **Gestión de sesiones:** visualización y control de sesiones médicas.
- **Gestión documental:** subida, visualización y administración de documentos asociados a cada usuario.
- **Roles diferenciados:** funcionalidades específicas para administradores y usuarios.
- **Interfaz intuitiva** y fácil de usar.

## Estructura de la aplicación

### 1. Login
- Ingreso de nombre y contraseña.
- Botones para inicio de sesión como administrador o usuario.

### 2. Recuperar Contraseña
- Formulario para ingresar nombre, correo, contacto y motivo.
- Envío de mensaje para recuperación de acceso.

### 3. Inicio Administrador
- Visualización de grilla de usuarios y sesiones.
- Registro de nuevos administradores y usuarios.
- Acceso a gestión de documentos y sesiones.

### 4. Registro de Administrador/Usuario
- Formulario con campos: nombre, contraseña, RUT, contacto, dirección.
- Para usuarios: campos adicionales de familiar y contacto familiar.
- Gestión de documentos y sesiones futuras.
- Botones para agregar, actualizar y eliminar registros.

### 5. Inicio Usuario
- Vista de información personal y documentos asociados.
- Acceso a documentos y sesiones programadas.

## Instalación y ejecución

1. **Requisitos previos:**
   - Visual Studio 2022 o superior.
   - .NET Framework 4.7.2 o superior.

2. **Clonar el repositorio:**
   ```sh
   git clone <URL_DEL_REPOSITORIO>
   ```

3. **Abrir la solución:**
   - Abre el archivo `proyectoprogra.sln` en Visual Studio.

4. **Compilar y ejecutar:**
   - Selecciona la configuración `Debug` y ejecuta el proyecto (`F5`).

## Uso

- Inicia sesión con tus credenciales.
- Accede a las funcionalidades según tu rol (usuario o administrador).
- Gestiona usuarios, sesiones y documentos desde el panel correspondiente.
- Utiliza la opción de recuperación de contraseña si es necesario.

## Contribuciones

Las contribuciones son bienvenidas. Por favor, abre un issue o pull request para sugerencias o mejoras.

## Licencia

Este proyecto está bajo la licencia MIT.
