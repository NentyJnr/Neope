using System.Collections;

namespace Blog.Models.Domain
{
    public class BlogPost
    {


        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime PublicationDate { get; set; }

        public string PostImageUrl { get; set; }

        public string Author { get; set; }


        public ICollection<Tag> Tags { get; set; }
    }
}
