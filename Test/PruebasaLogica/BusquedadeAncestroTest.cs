using Clases;
using Logica;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebasaLogica
{
	public class BusquedadeAncestroTest
	{
		private Nodo raiz ;
		private BusquedadeAncestro impresion;
		private ConstruccioneImpresion arbol;
		[SetUp]
		public void Setup()
		{
			raiz = new Nodo();
			impresion = new BusquedadeAncestro();
			arbol = new ConstruccioneImpresion();
		}
		[Test]
		public async System.Threading.Tasks.Task BuscarAncestroTestAsync()
		{
			//Arranque
			int? intRespuesta;
			raiz = await arbol.Insertar(49, null);
			await arbol.Insertar(49, raiz);
			await arbol.Insertar(25, raiz);
			await arbol.Insertar(3, raiz);
			await arbol.Insertar(30, raiz);
			await arbol.Insertar(27, raiz);
			await arbol.Insertar(28, raiz);
			await arbol.Insertar(32, raiz);
			await arbol.Insertar(58, raiz);
			await arbol.Insertar(63, raiz);
			await arbol.Insertar(75, raiz);
			await arbol.Insertar(64, raiz);
			await arbol.Insertar(79, raiz);
			await arbol.Insertar(99, raiz);
			impresion.intCantidadNodos = 14;
			impresion.intValorNodo1 = 27;
			impresion.intValorNodo2 = 64;
			//Act
			intRespuesta = await impresion.BuscarAncestro(raiz);
			//Assert
			Assert.IsNotNull(intRespuesta);
		}
	}
}
