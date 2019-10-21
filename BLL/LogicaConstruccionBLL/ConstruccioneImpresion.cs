using Clases;
using Logica.Interfaces;
using System;
using System.Threading.Tasks;

namespace Logica
{
	public class ConstruccioneImpresion: IConstruccioneImpresion
	{
		#region "Atributos"
		/// <summary>
		/// identifica el nodo raiz
		/// </summary>
		#endregion
		#region "Constructor"
		/// <summary>
		/// Constructor de la clase que inicializa el nodo raiz en null
		/// </summary>
		public ConstruccioneImpresion()
		{
		}
		#endregion
		#region "Método público"
		/// <summary>
		/// En el presente método se contruye el arbol, insertando nodo a nodo
		/// </summary>
		/// <param name="intDato">valor que identifica el dato a intertar en el nodo</param>
		/// <param name="objNodo">objeto de tipo nodo que representa el arbol</param>
		/// <returns>Retorna el árbol</returns>
		public async Task<Nodo> Insertar(int intDato, Nodo objNodo)
		{
			Nodo temp = null;

			if (objNodo == null)
			{
				temp = new Nodo
				{
					Dato = intDato
				};
				return temp;
			}
			if (intDato < objNodo.Dato)
			{
				objNodo.Izq = await Insertar(intDato, objNodo.Izq);
			}
			if (intDato > objNodo.Dato)
			{
				objNodo.Der =await Insertar(intDato, objNodo.Der);
			}
			return objNodo;
		}
		/// <summary>
		/// Método que imprime los nodos del arbol
		/// </summary>
		/// <param name="objArbol">objeto que representa el arbol a imprimir</param>
		public void ImprimirArbol(Nodo objArbol)
		{
			if (objArbol != null)
			{
				Console.Write(objArbol.Dato + " ");
				if (objArbol.Izq != null)
				{
					ImprimirArbol(objArbol.Izq);
				}
				if (objArbol.Der != null)
				{
					ImprimirArbol(objArbol.Der);
				}
			}
		}
		#endregion
	}
}
