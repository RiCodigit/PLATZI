using static System.Console;

namespace CoreEscuela.Util
{

    /* 
    Al poner static, hacemos que no se puedan crear mas objetos de esta clase.
    ya que digamos, es esta clase ya se comporta como un objeto, por ende podemos usar
    el objeto y todas sus funcionalidades, pero no podemos crear mas objetos.
    
    */
    public static class Printer
    {
        public static void DibujarLinea(int tam = 10)
        {
           
            /* var linea = "".PadLeft(tam,'=');
            WriteLine(linea); 
            
            Es lo mismo que lo de abajo pero mas sencillo.
            */
            
            WriteLine("".PadLeft(tam,'='));
        }
        public static void WriteTitulo(string titulo)
        {   
            var tamaño = titulo.Length + 4;
            DibujarLinea(tamaño);
            WriteLine($"| {titulo} |");
            DibujarLinea(tamaño);

        }
        public static void Beep (int hz = 2000, int tiempo = 500, int cantidad = 1)
        {   
            while (cantidad--  > 0)
            {
                System.Console.Beep(hz, tiempo);
            }

        }
    }

}