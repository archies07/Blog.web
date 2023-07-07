namespace Blog.web.Models.Domin
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }

        public ICollection<blogpost> Tags { get; set; }
    }
}
