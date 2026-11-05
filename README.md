# Rotated Array Search Lab — Búsqueda binaria modificada

Ejercicio académico en **C#** sobre búsqueda del mínimo en un arreglo originalmente ordenado y después rotado. El programa [`Program.cs`](Program.cs) muestra las decisiones de un algoritmo tipo *divide y vencerás* paso a paso en consola.

> **Estado:** demostración educativa con un arreglo fijo. No es una biblioteca general, un servicio web ni un módulo probado para todas las clases de entrada.

## Problema y ejemplo

Dado el arreglo rotado:

```text
[21, 38, 45, 2, 16]
```

el mínimo es **2**, ubicado en el **índice 3** (basado en cero). El código usa dos límites, `inicio` y `fin`, y los reduce comparando `A[centro]` con `A[fin]`.

**Complejidad:** en la entrada asumida (valores distintos, arreglo ordenado y rotado), el procedimiento reduce el rango y alcanza **O(log n)** de tiempo y **O(1)** de memoria adicional. El algoritmo actual **no maneja correctamente todos los casos de duplicados o arreglos vacíos**, por lo que no debe presentarse como búsqueda binaria general.

## Ejecutar localmente

La versión original contiene `Program.cs`, pero no un proyecto `.csproj`. En Visual Studio o VS Code con el SDK .NET, crea un proyecto de consola de desarrollo y reemplaza su `Program.cs` por el archivo de este repositorio:

```bash
dotnet new console -n RotatedArrayDemo
```

Copia `Program.cs` dentro de `RotatedArrayDemo/` y ejecuta `dotnet run --project RotatedArrayDemo`. El archivo existente requiere un SDK compatible con sintaxis moderna de C#.

## Organización

| Recurso | Contenido |
|---|---|
| [`Program.cs`](Program.cs) | Ejemplo y trazas de búsqueda |
| [`docs/index.html`](docs/index.html) | Visualización didáctica para previsualización estática |
| [`docs/ENGINEERING_ROADMAP_2026-11-04.md`](docs/ENGINEERING_ROADMAP_2026-11-04.md) | Plan de pruebas y modularización |
| [`docs/ARCHITECTURE_SCALABILITY_2026-11-04.md`](docs/ARCHITECTURE_SCALABILITY_2026-11-04.md) | Análisis de complejidad y límites |

La demo web puede configurarse con GitHub Pages, pero **no se ha comprobado aquí que exista un despliegue público activo**.

## Evolución técnica

- Extraer `BuscarPosicionMinimo` a una clase reutilizable con precondiciones documentadas.
- Añadir tests de arreglo vacío, no rotado, un elemento, rotaciones sucesivas y duplicados.
- Comparar búsqueda lineal de referencia y búsqueda binaria modificada en casos replicables.
- Incorporar un proyecto .NET y CI antes de declarar una librería reutilizable.

**Propósito:** aprendizaje de algoritmos. No se justifica infraestructura de servidores ni promesas de alto rendimiento sin pruebas.
