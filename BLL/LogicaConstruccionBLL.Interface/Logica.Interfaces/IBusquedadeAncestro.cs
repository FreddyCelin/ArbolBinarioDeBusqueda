using Clases;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Interfaces
{
	public interface IBusquedadeAncestro
	{
		/// <summary>
		/// Método que buscar el ancestro mas cercano en el arbol creado
		/// </summary>
		/// <param name="NRaiz">objeto que representa el arbol</param>
		/// <returns>valor que identifica el ancestro, puede ser null (null especifica que no existe)</returns>
		Task<int?> BuscarAncestro(Nodo NRaiz);
	}
}
