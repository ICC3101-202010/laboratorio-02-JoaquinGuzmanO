using System;
using System.Collections.Generic;
using System.Text;

namespace laboratorio1
{
    class Espotifai
    {
        public string nombreS;
        public string albumS;
        public string artistaS;
        public string generoS;

        public Espotifai(string aNombre, string aAlbum, string aArtista, string aGenero)
        {
            nombreS = aNombre;
            albumS = aAlbum;
            artistaS = aArtista;
            generoS = aGenero;
        }
        
        string[] new_song = {"cancion4", "album4", "artista4", "genero4"};

        public bool AgregarCancion()

        {
            string[] new_song = { "cancion4", "album4", "artista4", "genero4" };// cancion que se desea agregar
            if (nombreS == new_song[0] && albumS == new_song[1] && artistaS == new_song[2] && generoS == new_song[0])
            {
                return false;
            }
            return true;

        }

        public void VerCanciones()
        {
            
        }

        public Cancion[] CancionesPorCriterio(String criterio, String valor)
        {
            string[] array_vacio = {};
            if (criterio == "nombre")
            {
              
            }
            if (criterio == "album")
            {

            }
            if (criterio == "artista")
            {

            }
            if (criterio == "genero")
            {

            }
            else
            {
                return array_vacio;
            }




        }
            

    }

  
}
