using Clases;
using Logica;
using Logica.Interfaces;
using System;

namespace ArbolBinario
{
	public class IniciodelPrograma
	{
		#region "Atributos"
		/// <summary>
		/// Variable entera que representa el primer nodo para buscar el ancestro
		/// </summary>
		private static int intPrimerNodoaComparar;
		/// <summary>
		/// Variable entera que representa el segundo nodo para buscar el ancestro
		/// </summary>
		private static int intSegundoNodoaComparar;
		/// <summary>
		/// Variable entera que representa las veces que se va a iterar 
		/// para construir el arbol, dependiendo a la cantidad de nodos
		/// </summary>
		private static int intContador;
		/// <summary>
		/// Resultado de la buscqueda del ancestro entre el nodo1 y nodo2
		/// </summary>
		private static int? intValorAncestro;
		/// <summary>
		/// objeto que representa las propiedades del arbol, como raíz, izquierda o derecha
		/// </summary>
		private static Nodo objNodo;
		/// <summary>
		/// Objeto que representa la clase para poder contruir el arbol e imprimirlo
		/// </summary>
		private static IConstruccioneImpresion objContruccionImpresion;
		/// <summary>
		/// Variable de tipo random para contruir el arbol con el valor de nodos aleatorio
		/// </summary>
		private static Random rdmValor;
		/// <summary>
		/// Variable de tipo booleano que se utiliza para iterar repetidamente 
		/// hasta que el usuario ingrese un valor correcto
		/// </summary>
		private static bool boolValorAceptable = false;
		/// <summary>
		/// Variable entera que se utiliza para comparar que el dato que ingreso el usuario
		/// sea entero
		/// </summary>
		private static Int16 intValorAceptable;
		/// <summary>
		/// Variable que identifica el valor que el usuario ingresa para el número de nodos
		/// </summary>
		private static string strNumNodoACrear;
		/// <summary>
		/// Variable que identifica si el usuario desea imprimir el arbol?
		/// </summary>
		private static string strDeseaImprimirArbol;
		/// <summary>
		/// Valor digitado por el usuario
		/// </summary>
		private static string strValorDigitado;
		/// <summary>
		/// Constante que identifica el valor máximo que puede ingresar el usuario
		/// </summary>
		private const string ConstValorMaxAIngresar = "El valor ingresado debe ser un número entero entre 1 y 32767";
		#endregion
		#region "Main"
		/// <summary>
		/// Inicio de la aplicación
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			Console.WriteLine("Arbol binario de busqueda\r");
			Console.WriteLine("------------------------\n");
			IngresoCantidadNodos();

			Console.Write("Arbol creado!. ");

			ImprimirArbol();
			Console.WriteLine("");

			DigitarNodosParaBuscarAncestro();

			Console.Write("Precione una tecla para finalizar la aplicación...");
			Console.ReadKey();
		}
		#endregion
		#region "Métodos privados"
		/// <summary>
		/// Método para solicitar la cantidad de nodos para el arbol.
		/// </summary>
		private static async void IngresoCantidadNodos()
		{
			strNumNodoACrear = PreguntaraUsuario("Cuantos nodos desea ingresar aleatoriamente? ");

			intContador = 1;
			rdmValor = new Random();
			objContruccionImpresion = new ConstruccioneImpresion();
			objNodo = new Nodo();
			while (intContador <= Convert.ToInt32(strNumNodoACrear))
			{
				if (intContador == 1)
					objNodo = await objContruccionImpresion.Insertar(rdmValor.Next(1, Int16.MaxValue), null);
				else
					await objContruccionImpresion.Insertar(rdmValor.Next(1, Int16.MaxValue), objNodo);
				intContador++;
			}
		}
		/// <summary>
		/// Método para solicitar al usuario si desea imprimir el arbol o no
		/// </summary>
		private static void ImprimirArbol()
		{
			boolValorAceptable = false;
			while (!boolValorAceptable)
			{
				Console.Write("Desea imprimir el arbol (Y/N): ");
				strDeseaImprimirArbol = Console.ReadLine();
				if (strDeseaImprimirArbol.ToUpper() == "Y" || strDeseaImprimirArbol.ToUpper() == "N")
				{
					boolValorAceptable = true;
				}
				else
					Console.WriteLine("El valor ingresado debe ser Y o N");
			}
			if (strDeseaImprimirArbol.ToUpper() == "Y")
				objContruccionImpresion.ImprimirArbol(objNodo);
		}
		/// <summary>
		/// Método para solicitar al usuario el primer y segundo nodo para buscar el ancestro mas cercano
		/// </summary>
		private async static void DigitarNodosParaBuscarAncestro()
		{
			intPrimerNodoaComparar = Convert.ToInt16(PreguntaraUsuario("Digite el primer nodo para ubicar el ancestro: "));
			intSegundoNodoaComparar = Convert.ToInt16(PreguntaraUsuario("Digite el segundo nodo para ubicar el ancestro: "));
			Console.WriteLine("");

			IBusquedadeAncestro objBusquedadeAncestro = new BusquedadeAncestro
			{
				intValorNodo1 = intPrimerNodoaComparar,
				intValorNodo2 = intSegundoNodoaComparar,
				intCantidadNodos = Convert.ToInt32(strNumNodoACrear)
			};
			intValorAncestro =await objBusquedadeAncestro.BuscarAncestro(objNodo);
			Console.WriteLine(intValorAncestro == null ? "No hay ancestro común." : "El valor del ancestro es: " + intValorAncestro);
		}
		/// <summary>
		/// Método que se encarga de consultarle al usuario los parametros que necesita para continuar en la aplicación
		/// </summary>
		/// <param name="strPreguntaraUsuario">mensaje que identifica el dato que necesita para continuar en la aplicación</param>
		/// <returns>retorna el valor ingresado por el usuario</returns>
		private static string PreguntaraUsuario(string strPreguntaraUsuario)
		{
			boolValorAceptable = false;
			while (!boolValorAceptable)
			{
				Console.Write(strPreguntaraUsuario);
				strValorDigitado = Console.ReadLine();
				if (Int16.TryParse(strValorDigitado, out intValorAceptable))
				{
					if (Convert.ToInt16(strValorDigitado) > 0)
						boolValorAceptable = true;
				}
				if (!boolValorAceptable)
					Console.WriteLine(ConstValorMaxAIngresar);
			}
			return strValorDigitado;
		}
		#endregion
	}
}
