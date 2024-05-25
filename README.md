# GESTION DE NOTAS

### DESARROLLADO PARA DEV'S HOUSE #1

## Objetivo
Desarrollar una aplicación de escritorio que permita registrar y gestionar los estudiantes, los grados, las materias, los docentes y las notas de un colegio para mejorar el seguimiento académico de los estudiantes.

## Lenguaje Utilizado: C# - .NET Framework.
## Arquitectura Implemetada: 3 CAPAS (BLL, DAL, Entity, Presentacion)

# REQUERIMIENTOS

## Gestión de Estudiantes:
 * RF1: Registro de estudiantes con los siguientes datos:
   - Nombre completo
   - Identificación (ID)
   - Fecha de nacimiento
   - Dirección
   - Teléfono de contacto
* RF2: Modificación de los datos de estudiantes.
* RF3: Eliminación de estudiantes del sistema.
* RF4: Búsqueda de estudiantes por nombre y/o ID.

## Gestión de Grados:
* RF5: Registro de grados escolares (Sexto, Séptimo, Octavo, Noveno, Décimo, Once).
* RF6: Asignación de estudiantes a grados específicos.
* RF7: Visualización de la lista de estudiantes por grado.

## Gestión de Materias y Docentes:
* RF8: Registro de materias con los siguientes datos:
    - Nombre de la materia
    - Docente encargado [Filtrar por el tipo de materia y suespecialidad]
* RF9: Asociación de materias a un grado específico.
* RF10: Modificación y eliminación de materias.

## Registro de Notas:
* RF11: Ingreso de notas por materia para cada estudiante (Cada nota debe obtener una observación para el estudiante, esta debe ser tenida en cuenta la momento de imprimir el boletin).
* RF12: Modificación y eliminación de notas (Solo aplica si NO se registro un periodo después, es decir si no se ha registrado nota del PERIDO 2 se puede modificar el PERIODO 1, una vez se registre nota en el PERIODO 2 ya no se puede modificar la nota del PERIODO 1, si quiere hacerlo solo lo puede hacer el superusuario).
* RF13: Consulta de notas por estudiante y materia.

## Reportes:
* RF14: Generación de reportes de notas por estudiante, materia y grado.
* RF15: Reportes de rendimiento por grado y materia [En Graficas y en PDF debe decir el mejor estudiante por salón y ordenarlos del mejor promedio al peor para seleccionar los puestos].

## Gestión de Usuarios:
* RF16: Registro de usuarios para docentes con capacidad de ingresar y modificar notas de las materias que imparten.
* RF17: Registro de un superusuario (directivos) con permisos para administrar todo el sistema y acceso a todos los reportes y funcionalidades.\
* RF18: Login seguro para docentes y directivos (Deseable utilizar JWT para encriptar el inicio, si no es posible hacerlo normal).

## Generación de Boletines:
* RF19: Los estudiantes pueden ingresar al sistema utilizando su cédula para generar un PDF de su boletín académico, el pdf debe ser envía via CORREO ELECTRONICO.
* RF20: Los boletines incluirán la lista de materias, las notas obtenidas en cada periodo académico (Periodo 1, Periodo 2, Periodo 3, Periodo 4) y un promedio final, es decir el estudiante puede seleccionar entre imprimir el Primer, segundo, tercer o cuarto OJO: ESTO DEPENDE DEL PERIODO EL CUAL TENGA REGISTRADO NOTAS, SI NO SE HA REGISTRADO NOTAS PARA EL PERIODO X EN SU TOTALIDAD NO SE PUEDE IMPRIMIR, TODAS LAS MATERIAS DEBEN TENER SU NOTA PARA PODER IMPRIMIR.
* RF21: Funcionalidad para imprimir, descargar y enviar el boletín en formato PDF.

## Gestión de Docentes:
* RF22: Registro de estudiantes con los siguientes datos:
  - Nombre completo
  - Identificación (ID)
  - Fecha de nacimiento
  - Dirección
  - Especialidad [Si es de naturales, física, matemáticas].
  - Teléfono de contacto
* RF23: Modificación de los datos de docente.
* RF24: Eliminación de docente del sistema [NO SE PUEDE ELIMINAR SI TIENE UNA MATERIA ASIGNADA].
* RF25: Búsqueda de DOCENTE por nombre y/o ID.


## ACTUALIZACIONES 
25/5/2024 - CREACION REPOSITORIO, CREACION GESTION DE NOTAS, CREACION SP
