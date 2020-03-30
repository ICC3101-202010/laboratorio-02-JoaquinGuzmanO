using System;

namespace laboratorio1
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Cancion cancion1 = new Cancion("cancion1", "album1", "artista1", "genero1");
            Cancion cancion2 = new Cancion("cancion2", "album2", "artista2", "genero2");
            Cancion cancion3 = new Cancion("cancion3", "album3", "artista3", "genero3");

            Espotifai cancion1S = new Espotifai("cancion1", "album1", "artista1", "genero1");
            Espotifai cancion2S = new Espotifai("cancion2", "album2", "artista2", "genero2");
            Espotifai cancion3S = new Espotifai("cancion3", "album3", "artista3", "genero3");

            Console.WriteLine("bienvenidos a espotifai!!, a continuacion se veran todas sus canciones...");
            Console.WriteLine(cancion1.Informacion());
            Console.WriteLine(cancion2.Informacion());
            Console.WriteLine(cancion3.Informacion());

            Console.WriteLine("Se esta verificando si la cancion se puede añadir a las playlist...");

            if (cancion1S.AgregarCancion() == true && cancion2S.AgregarCancion() == true && cancion2S.AgregarCancion() == true)
            {
                Cancion cancion4 = new Cancion("cancion4", "album4", "artista4", "genero4");
                Console.WriteLine("Cancion añadida a la playlist, las canciones actuales son las siguientes");
                Console.WriteLine(cancion1.Informacion());
                Console.WriteLine(cancion2.Informacion());
                Console.WriteLine(cancion3.Informacion());
                Console.WriteLine(cancion4.Informacion());

             }
            else
            {
                Console.WriteLine("Cancion no valida");
            }
            

        }
        
    }     
}
