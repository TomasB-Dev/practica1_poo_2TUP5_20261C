namespace web.ej2;

public class BigPhotoBook : PhotoBook
{
    public BigPhotoBook(int numPages = 64, int IdAlbum = 1)
    {
        NumPages = numPages;
        idAlbum = IdAlbum;
    }
    public static List<PhotoBook> albumesGrandes = new List<PhotoBook>();

    public static void AddAlbum(BigPhotoBook Album)
    {
        albumesGrandes.Add(Album);
    }

    new public static string FindAlbum(int id)
    {
        foreach (var album in albumesGrandes)
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