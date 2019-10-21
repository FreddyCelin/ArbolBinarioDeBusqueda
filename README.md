# Arbol Binario
Árbol binario que busca el ancestro común mas cercano


Introducción del proyecto 🚀
--------------------------
El proyecto árbol binario de busqueda permite encontra el ancestro mas cercano mediante la ubicación de dos nodos previamente ingresados por el usuario, este proyecto fue desarrollado en cuatro capas que consta:
	1. Capa de presentación, en este proyecto se capturan los datos por parte del usuario para que la app pueda encontrar el ancestro mas cercano.
	2. Capa de lógica, se encuentra del proyecto para contruir, imprimir y encontrar el ancestro común para el árbol construido.
	3. Capa transversal, aquí se encuentra las propiedades del nodo y sus atributos.
	4. Capa de pruebas unitarias, en este proyecto se pueden ejecutar las pruebas para verificar el correcto funcionamiento de los métodos que se encuentrar en la lógica.


Ejecución del proyecto 🔧
------------------------
Para ejecutar el proyecto, el usuario debe establece como proyecto de inicio el proyecto "ArbolBinario" que se encuentra en la carpeta 1.Main, luego ejecutar la App mediante F5


Ejecutando las pruebas ⚙️
-------------------------
Para ejecutar las pruebas unitarias, el usuario debe ubicarse sobre un método de la clase BusquedadeAncestroTest o ConstruccioneImpresionTest, dar clic derecho y seleccionar la opción "Depurar pruebas"


Análisis de pruebas end-to-end 🔩
--------------------------------
Para verificar las pruebas unitarias, al ejecutar el método BuscarAncestroTestAsync que se encuentra en la clase BusquedadeAncestroTest, debe retornar un valor entero que identificar el ancestro mas cercano luego de crear el arbol y el nodo1 y nodo2
Para verificar las pruebas de CrearArboldeFormaManualTestAsync y CrearArboldeFormaAleatoriaTestAsync que se encuentra en la clase ConstruccioneImpresionTest, el método no debe retorar un null como nodo principal luego de haber creado el árbol binario.


Estilo de codificación ⌨️
-------------------------
Personalmente desarrollo este proyecto de tal manera que los atributos pueden ser ubicados mediante un guión bajo y se encuentran privados, estos atributos solo pueden ser accesible de otras clases desde sus propiedades públicas, adicionalmente en este proyecto establezco comentarios tanto de métodos públicos como privados, propiedades y atributos, organizo el código en regiones.


Construido con 🛠️
-----------------
El proyecto fue desarrollado en visual studio .net core 2.2 en aplicación de consola.


Autor ✒️
--------
Desarrollado por el ingeniero Freddy Celin

