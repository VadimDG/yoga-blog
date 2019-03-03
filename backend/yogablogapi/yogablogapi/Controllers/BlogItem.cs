using Newtonsoft.Json;

namespace yogablogapi.Controllers
{
    
    public class BlogItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("pictureURL")]
        public string PictureURL { get; set; }
    }

    public class Author
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public int ExperienceTime { get; set; }
    }
}