namespace TeamsCardSender.Models
{
    public class Body
    {
        public string Type { get; set; }
        public string Size { get; set; }
        public string Weight { get; set; }
        public string Text { get; set; }
        public bool? Separator { get; set; }
        public string Spacing { get; set; }
        public bool? Wrap { get; set; }
    }

    public class Mentioned
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class Entity
    {
        public string Type { get; set; }
        public string Text { get; set; }
        public Mentioned Mentioned { get; set; }
    }

    public class Msteams
    {
        public List<Entity> Entities { get; set; }
    }

    public class Content
    {
        public string Type { get; set; }
        public List<Body> Body { get; set; }
        public string Schema { get; set; }
        public string Version { get; set; }
        public Msteams Msteams { get; set; }
    }

    public class Attachment
    {
        public string ContentType { get; set; }
        public Content Content { get; set; }
    }

    public class Root
    {
        public string Type { get; set; }
        public List<Attachment> Attachments { get; set; }
    }
}
