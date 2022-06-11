using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }

    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>()
            {
                new Proyecto
                {
                    Titulo = "Amazon",
                    Descripcion = "E-Commerce realizado en ASP.NET Core",
                    ImageURL = "/imagenes/amazon.png",
                    Link = "https://amazon.com"
                },
                new Proyecto
                {
                    Titulo = "New York Times",
                    Descripcion = "Pagina de noticias en React",
                    ImageURL = "/imagenes/nyt.png",
                    Link = "https://nytimes.com"
                },
                new Proyecto
                {
                    Titulo = "Reddit",
                    Descripcion = "Red social para compartir en comunidades",
                    ImageURL = "/imagenes/reddit.png",
                    Link = "https://reddit.com"
                },
                new Proyecto
                {
                    Titulo = "Steam",
                    Descripcion = "Tienda en linea para comprar videojuegos",
                    ImageURL = "/imagenes/steam.png",
                    Link = "https://store.steampowered.com"
                }
            };
        }
    }
}
