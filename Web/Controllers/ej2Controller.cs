using Microsoft.AspNetCore.Mvc;
using web.ej2;

namespace web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej2Controller : ControllerBase
{
    [HttpPost("normal")]
    public int Get(int cantpages = 16, int idalbum = 1)
    {
        PhotoBook libro = new PhotoBook(cantpages, idalbum);
        PhotoBook.AddAlbum(libro);
        return libro.GetNumberPages();
    }

    [HttpGet("ConsultarNormal")]
    public string GetAlbum(int idAlbum)
    {
        return PhotoBook.FindAlbum(idAlbum);
    }

    [HttpGet("ConsultarbigAlbum")]
    public string Getbigalbum(int idalbum)
    {
        return BigPhotoBook.FindAlbum(idalbum);
    }
    [HttpPost("bigAlbum")]
    public int GetBig(int cantpages = 64, int idAlbum = 1)
    {
        BigPhotoBook album = new BigPhotoBook(cantpages, idAlbum);
        BigPhotoBook.AddAlbum(album);
        return album.GetNumberPages();
    }
}
