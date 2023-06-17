using Microsoft.AspNetCore.Mvc;

namespace NEWS.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class NewsControl
    {
        public static List<News> newsList = new List<News>()
        {
            new News{ news = "Event", judul = "Cegah Banjir", isi = "Bersihkan Saluran Air & Buang Sampah Pada Tempatnya"},
            new News{ news = "Info", judul = "Kebersihan Alam", isi = "Sampah yang dibuang sembarangan akan mencemari lingkungan"},
            new News{ news = "Info", judul = "Cara Mudah Daur Ulang Sampah", isi = "Pelajari cara-cara brilian untuk mendaur ulang"}
        };

        [HttpPost(Name = "PostNews")]
        public void Upload(News News)
        {
            newsList.Add(News);
        }
        [HttpDelete(Name = "DeleteNews")]
        public void Delete(int index)
        {
            newsList.RemoveAt(index);          
        }
        [HttpGet(Name = "InfoNews")]
        public List<string> infoNews()
        {
            List<string> str = new List<string>();
            for (int i = 0; i < newsList.Count; i++)
            {
                str.Add(newsList[i].judul);

            }
            return str;
        }
        [HttpGet("{index}")]
        public News newsIndex(int index)
        {
            return newsList[index];
        }
    }
}