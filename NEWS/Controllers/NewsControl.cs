using Microsoft.AspNetCore.Mvc;

namespace NEWS.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class NewsControl
    {
        public static List<News> NewsList = new List<News>();

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
        public List<News> infoNews()
        {
            return NewsList;
        }
        [HttpGet("{index}")]
        public News NewsIndex(int index)
        {
            return NewsList[index];
        }
    }
}