using Microsoft.AspNetCore.Mvc;

namespace NEWS.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class NewsControl
    {
        public static List<News> NewsList = new List<News>() 
        {
            new News{ news = "Event", judul = "Cegah Banjir", isi = "Bersihkan Saluran Air & Buang Sampah Pada Tempatnya"},
            new News{ news = "Info", judul = "Kebersihan Alam", isi = "Sampah yang dibuang sembarangan akan mencemari lingkungan"},
            new News{ news = "Info", judul = "Cara Mudah Daur Ulang Sampah", isi = "Pelajari cara-cara brilian untuk mendaur ulang"}
        };

        [HttpPost(Name = "PostNews")]
        public void Upload(News News)
        {
            NewsList.Add(News);
        }
        [HttpDelete(Name = "DeleteNews")]
        public void Delete(int index)
        {
            NewsList.RemoveAt(index);          
        }
        [HttpGet(Name = "InfoNews")]


        public List<string> infoNews()
        {
            List<string> str = new List<string>();
            for (int i = 0; i < NewsList.Count; i++)
            {
                str.Add(NewsList[i].judul);

            }
            return str;
        }
        [HttpGet("{index}")]
        public News NewsIndex(int index)
        {
            return NewsList[index];
        }
    }
}