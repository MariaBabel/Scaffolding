# Scaffold Base de Datos SQL

Para obtener las tablas de una base de datos (SQL en este caso) hay que poner el siguiente comando en una terminal (.NET CLI o PowerShell) sustituyendo los valores en mayúsculas:

## .NET Core CLI
```
dotnet ef dbcontext scaffold CONNECTION_STRING Microsoft.EntityFrameworkCore.SqlServer --output-dir CARPETA_ENTIDADES --table TABLA_1 ... --table TABLA_N --context-dir CARPETA_CONTEXT --context NOMBRE_CONTEXT --context-namespace NAMESPACE_CONTEXT
```

*Si se elige esta opción hay que posicionarse en la carpeta que incluya el proyecto*

## Visual Studio
```
Scaffold-DbContext CONNECTION_STRING Microsoft.EntityFrameworkCore.SqlServer -OutputDir CARPETA_ENTIDADES -Tables TABLA_1,TABLA_N -ContextDir CARPETA_CONTEXT -Context NOMBRE_CONTEXT  -ContextNamespace NAMESPACE_CONTEXT
```
Los parámetros arriba utilizados son los más genéricos. Por ejemplo, se usa el parámetro *--table* o *-tables* para indicar tablas concretas. Si se desea toda la base de datos, se puede omitir.

Para volver a insertar una tabla tenida en cuenta previamente se incluye el parámetro *--force* o *-force*

Se incluye en este proyecto un caso ya pre-construido con un contexto de base de datos y dos tablas de ejemplo

Más información:

https://docs.microsoft.com/es-es/ef/core/managing-schemas/scaffolding?tabs=dotnet-core-cli
https://docs.microsoft.com/es-es/ef/core/cli/powershell

