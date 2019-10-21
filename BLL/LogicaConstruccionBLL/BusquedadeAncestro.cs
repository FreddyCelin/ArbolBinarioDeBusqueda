using Clases;
using Logica.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
	public class BusquedadeAncestro: IBusquedadeAncestro
	{
		#region "Atributos"
		/// <summary>
		/// Valor del primer nodo para buscar el ancestro
		/// </summary>
		private int _intValorNodo1;
		/// <summary>
		/// Valor del segundo nodo para buscar el ancestro
		/// </summary>
		private int _intValorNodo2;
		/// <summary>
		/// Valor que representa el indice del camino de la ruta para ubicar un nodo
		/// </summary>
		private int _intIndiceRuta;
		/// <summary>
		/// Matriz de entero que identifica los caminos para ubicar el nodo1 y nodo2
		/// </summary>
		private int[,] _RecorridodeDatos;
		/// <summary>
		/// Entero que identifica la cantidad de nodos que se encuentra
		/// </summary>
		private int _intCantidadNodos;
		#endregion

		#region "Propiedades"
		/// <summary>
		/// Propiedad que encapsula el valor del primer nodo para buscar el ancestro
		/// </summary>
		public int intValorNodo1
		{
			get { return _intValorNodo1; }
			set { _intValorNodo1 = value; }
		}
		/// <summary>
		/// Propiedad que encapsula el segundo valor del nodo para buscar el ancestro
		/// </summary>
		public int intValorNodo2
		{
			get { return _intValorNodo2; }
			set { _intValorNodo2 = value; }
		}
		/// <summary>
		/// Propiedad que encapsula el valor de la cantidad de nodos que se presenta en el arbol
		/// </summary>
		public int intCantidadNodos
		{
			get { return _intCantidadNodos; }
			set { _intCantidadNodos = value; }
		}
		#endregion
		#region "Constructor"
		/// <summary>
		/// Constructor de la clase
		/// </summary>
		public BusquedadeAncestro()
		{
			_intIndiceRuta = 0;
		}
		#endregion
		#region "Método público"
		/// <summary>
		/// Método que buscar el ancestro mas cercano en el arbol creado
		/// </summary>
		/// <param name="NRaiz">objeto que representa el arbol</param>
		/// <returns>valor que identifica el ancestro, puede ser null (null especifica que no existe)</returns>
		public async Task<int?> BuscarAncestro(Nodo NRaiz)
		{
			if (intValorNodo1 == 0 || intValorNodo2 == 0 || intCantidadNodos ==0)
				return null;

			if (intValorNodo1 == intValorNodo2)
				return intValorNodo2;
			_RecorridodeDatos = new int[2, intCantidadNodos];
			if (!RutaPorNodo(NRaiz, intValorNodo1, 0))
				return null;
			_intIndiceRuta = 0;
			if (!RutaPorNodo(NRaiz, intValorNodo2, 1))
				return null;			
			else
			{				
				int intValorIndice;
				for (intValorIndice = 0; intValorIndice <= _intIndiceRuta; intValorIndice++)
				{
					if (_RecorridodeDatos[0, intValorIndice] != _RecorridodeDatos[1, intValorIndice])
						break;
				}
				return _RecorridodeDatos[0, intValorIndice - 1];
			}
		}
		#endregion
		#region "Método privado"
		/// <summary>
		/// Identifica la ruta hasta encontrar el valor del nodo
		/// </summary>
		/// <param name="objNArbol">objeto que representa el arbol</param>
		/// <param name="intValorNodo">valor del nodo (1 o 2)</param>
		/// <param name="intIndicedeNodo">indice que establece si es la ruta del nodo1 o 2</param>
		/// <returns>valor booleano que identifica si control el nodo o false si no lo encontro</returns>
		private bool RutaPorNodo(Nodo objNArbol,int intValorNodo,int intIndicedeNodo)
		{
			_RecorridodeDatos[intIndicedeNodo, _intIndiceRuta] = objNArbol.Dato;

			if (objNArbol.Dato > intValorNodo && objNArbol.Izq!= null)
			{
				_intIndiceRuta++;
				if (RutaPorNodo(objNArbol.Izq, intValorNodo, intIndicedeNodo))
					return true;
				else
					return false;
			}
			if (objNArbol.Dato < intValorNodo && objNArbol.Der != null)
			{
				_intIndiceRuta++;
				if(RutaPorNodo(objNArbol.Der, intValorNodo, intIndicedeNodo))
					return true;
				else
					return false;

			}
			if (objNArbol.Dato == intValorNodo)
				return true;
			else
				return false;
		}
		#endregion
	}
}
