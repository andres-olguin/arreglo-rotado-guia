# Ejercicio 2 - Arreglo Rotado

Este repositorio contiene la implementación del algoritmo para encontrar el elemento mínimo en un arreglo rotado y la resolución de las preguntas teóricas de la guía.

## Pregunta a: Identificación y Justificación de la Técnica

### Técnica de Diseño Utilizada
**Divide y Vencerás** (aplicada mediante una variante de la Búsqueda Binaria).

### Justificación
El algoritmo utiliza esta técnica debido a los siguientes puntos clave de su funcionamiento:

1. **División:** En cada iteración del ciclo, calcula un punto medio (`centro`) dividiendo el espacio de búsqueda actual en dos mitades.
2. **Reducción del problema:** Mediante la comparación condicional `A[centro] > A[fin]`, el algoritmo determina con total certeza en cuál de las dos mitades se encuentra el punto de rotación (el elemento mínimo).
3. **Descarte:** Al identificar la mitad correcta, modifica los punteros (`inicio = centro + 1` o `fin = centro`), descartando por completo la otra mitad. Esto reduce el tamaño del problema a la mitad en cada paso, logrando una eficiencia de tiempo de O(log n).


## Demostración web (frontend propio)

Se incorporó una [interfaz experimental en docs/index.html](docs/index.html) que puede utilizarse como fuente de GitHub Pages. **No se ha confirmado aún la activación ni la URL pública de GitHub Pages.**

Para publicarla, configurar GitHub Pages con rama main y carpeta /docs, verificar el sitio y agregar su URL comprobada a la sección About del repositorio. La interfaz es una adaptación o visualización didáctica; consultar sus límites en la propia página.

[Estudio de evolución y requisitos de seguridad](docs/ESTUDIO_DE_EVOLUCION_2026-10-30.md).
