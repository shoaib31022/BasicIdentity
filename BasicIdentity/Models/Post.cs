namespace BasicIdentity.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string LineOne { get; set; }
        public string LineTwo { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
        public int Category { get; set; }
        public bool status { get; set; }
    }
}
