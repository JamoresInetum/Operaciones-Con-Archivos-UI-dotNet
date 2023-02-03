using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones_Con_Archivos
{
    internal class Helper
    {
        
        public static void GuardarEnArchivo(string nombreArchivo, string texto)
        {
            File.WriteAllText(nombreArchivo, texto);
            Console.WriteLine("\nTexto guardado correctamente en: " + nombreArchivo);
        }
        public static void AñadirEnArchivo(string nombreArchivo, string texto)
        {
            File.AppendAllText(nombreArchivo, texto);
            Console.WriteLine("\nTexto añadido correctamente en: " + nombreArchivo);
        }
        public static string LeerDeArchivo(string nombreArchivo)
        {
            string textoLeido = File.ReadAllText(nombreArchivo);
            return textoLeido;
        }
        public static void GuardarSumaEnArchivo(string nombreArchivoEntrada, string nombreArchivoSalida)
        {

            string[] lineas = File.ReadAllLines(nombreArchivoEntrada);
            int[] numeros = new int[lineas.Length];

            int suma = 0;
            for (int i = 0; i < lineas.Length; i++)
            {
                numeros[i] = Convert.ToInt32(lineas[i]);
                suma += numeros[i];
            }
            GuardarEnArchivo(nombreArchivoSalida, suma.ToString());
        }

    }
}
