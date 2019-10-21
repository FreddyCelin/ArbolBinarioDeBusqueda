using Clases;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Interfaces
{
	public interface IConstruccioneImpresion
	{
		/// <summary>
		/// En el presente método se contruye el arbol, insertando nodo a nodo
		/// </summary>
		/// <param name="intDato">valor que identifica el dato a intertar en el nodo</param>
		/// <param name="objNodo">objeto de tipo nodo que representa el arbol</param>
		/// <returns>Retorna el árbol</returns>
		Task<Nodo> Insertar(int intDato, Nodo objNodo);
		/// <summary>
		/// Método que imprime los nodos del arbol
		/// </summary>
		/// <param name="objArbol">objeto que representa el arbol a imprimir</param>
		void ImprimirArbol(Nodo objArbol);
	}
}
