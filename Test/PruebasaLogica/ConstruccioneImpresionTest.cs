using Clases;
using Logica;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace Tests
{
	public class ConstruccioneImpresionTest
	{
		private Nodo raiz;
		private ConstruccioneImpresion arbol;
		
		[SetUp]
		public void Setup()
		{
			raiz = new Nodo();
			arbol = new ConstruccioneImpresion();			
		}

		[Test]
		public async Task CrearArboldeFormaManualTestAsync()
		{
			//Arranque
			
			raiz = await arbol.Insertar(Int16.MaxValue, null);
			await arbol.Insertar(49, raiz);
			await arbol.Insertar(25, raiz);
			await arbol.Insertar(3, raiz);
			await arbol.Insertar(30, raiz);
			await arbol.Insertar(27, raiz);
			await arbol.Insertar(28, raiz);
			await arbol.Insertar(32, raiz);
			await arbol.Insertar(59, raiz);
			await arbol.Insertar(63, raiz);
			await arbol.Insertar(75, raiz);
			await arbol.Insertar(64, raiz);
			await arbol.Insertar(79, raiz);
			await arbol.Insertar(98, raiz);

			Assert.NotNull(raiz.Dato);
		}
		[Test]
		public async Task CrearArboldeFormaAleatoriaTestAsync()
		{
			//Arranque
			int intContador, intCantidaddeNodos;
			Random rdmValor = new Random();

			intContador = 1;
			intCantidaddeNodos = 10;
			while (intContador <= intCantidaddeNodos)
			{
				if (intContador == 1)
					raiz =await  arbol.Insertar(Convert.ToInt32(rdmValor.Next(1, Int32.MaxValue)), null);
				else
					await arbol.Insertar(Convert.ToInt32(rdmValor.Next(1, Int32.MaxValue)), raiz);
				intContador++;
			}
			//Assert
			Assert.NotNull(raiz.Dato);
		}				
	}
}