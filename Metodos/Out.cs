namespace CLassesCsharp.Metodos{

    public class Out{
        
        static void Dividir(int x, int y, out int resultado, out int resto){
            resultado = x / y;
            resto = x % y;
        }

        static void Dividis(){
            Dividir(10, 3, out int resultado, out int resto);
            System.Console.WriteLine("{0} {1}", resultado, resto); // Escreve "3 1"          
        }
    }
}