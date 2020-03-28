using System;

namespace laboratorio1
{
    class Cancion
    {
        public string nombre;
        public string album;
        public string artista;
        public string genero;

        public Cancion(string aNombre, string aAlbum, string aArtista, string aGenero)
        {
            nombre = aNombre;
            album = aAlbum;
            artista = aArtista;
            genero = aGenero;
        }

        public string Informacion()
        {
            return "genero:" + genero + "artista:" + artista + "album:" + album + "nombre: " + nombre;
        }

    }
}
