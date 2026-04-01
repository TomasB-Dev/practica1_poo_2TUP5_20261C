namespace web.ej2;

using System.Collections.Generic;
public class PhotoBook
{
    public int NumPages { get; set; }

    public int idAlbum { get; set; }

    public PhotoBook(int numPages = 16, int IdAlbum = 1)
    {
        NumPages = numPages;
        idAlbum = IdAlbum;
    }
    public static List<PhotoBook> albumesChicos = new List<PhotoBook>();
    public int GetNumberPages()
    {
        return NumPages;
    }
    public static void AddAlbum(PhotoBook Album)
    {
        albumesChicos.Add(Album);
    }
    public static string FindAlbum(int id)
    {
        foreach (var album in albumesChicos)
        {
            if (album.idAlbum == id)
            {
                return $"La cantidad de paginas es:{album.NumPages}";
            }
            else
            {
                return "No se encontro el album";
            }
        }
        return "error, no se encontro album";

    }

}