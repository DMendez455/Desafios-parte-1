using System;

class Juego
{
    private int puntajeRecord = 0;
    private string jugadorRecord = "";

    public void ActualizarPuntaje(int puntaje, string nombreJugador)
    {
        if (puntaje > puntajeRecord)
        {
            puntajeRecord = puntaje;
            jugadorRecord = nombreJugador;
            Console.WriteLine("La nueva puntuación más alta es " + puntajeRecord);
            Console.WriteLine("La puntuación más alta fue lograda por " + jugadorRecord);
        }
        else
        {
            Console.WriteLine("La puntuación más alta de " + puntajeRecord + " no se ha podido superar, y aún está en manos de " + jugadorRecord);
        }
    }

    static void Main(string[] args)
    {
        Juego juego = new Juego();

        juego.ActualizarPuntaje(150, "Pepito");  
        juego.ActualizarPuntaje(100, "Duki"); 
        juego.ActualizarPuntaje(200, "Khea");   
    }
}
