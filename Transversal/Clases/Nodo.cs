using System;

namespace Clases
{
	public class Nodo
	{
		#region "Atributos"
		/// <summary>
		/// Identifica el valor de un nodo
		/// </summary>
		private int dato;
		/// <summary>
		/// Movimiento del nodo a la izquierda
		/// </summary>
		private Nodo izq;
		/// <summary>
		/// Movimiento del nodo a la derecha
		/// </summary>
		private Nodo der;
		#endregion
		#region "Propiedades"
		/// <summary>
		/// Propiedad que encapsula el valor del dato del nodo
		/// </summary>
		public int Dato { get => dato; set => dato = value; }
		/// <summary>
		/// Propiedad que encapsula el movimiento a la izquierda
		/// </summary>
		public Nodo Izq { get => izq; set => izq = value; }
		/// <summary>
		/// Propiedad que encapsula el movimiento a la derecha
		/// </summary>
		public Nodo Der { get => der; set => der = value; }
		#endregion
		#region "Constructor"
		public Nodo()
		{
			dato = 0;
			izq = null;
			der = null;
		}
		#endregion
	}
}
