// Leer numeros de consola y almacenarlos en una array y luego   imprimirlos
internal class Program
{
    private static void Main(string[] args)
    {
        //Leer el tamaño del array
    Console.WriteLine ("Ingrese el tamaño del array: ");
    string tamanoArrayComoString = Console.ReadLine();
    //String a Int
    int tamanoArray = Int32.Parse(tamanoArrayComoString);
        
    //Crear el array
    int[] array1 = new int[tamanoArray];

    //llenar el array
    Console.WriteLine ("Ingrese numeros para llenar el array: ");
    llenarArray (array1, tamanoArray);
    
    //Imprimier el array
    ImprimirArray(array1, tamanoArray);
   
    Console.ReadKey();
    }

    //Funcion llenar el array
     public static void llenarArray (int [] array, int tamano1)
     {
         // llenar los elementos del array
      for (int i=0; i<tamano1; i++)
        {
          //Asignamos los valores al array
          array[i] = int.Parse(Console.ReadLine()); 
        }
     }
  
     // Funcion imprimir el array
     public static void ImprimirArray (int[] array, int tamanoA)
     {
         for (int index=0; index < tamanoA; index++)
         {
            //Imprimimos el array
           Console.Write(array[index]);
           //no imprime la ultima coma
           if (index < (tamanoA -1))
           {
           Console.Write(", ");
           }
         }
     }    
}