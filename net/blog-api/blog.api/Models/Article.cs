using System;

using Blog.Api.Interfaces.Models;

namespace Blog.Api.Models
{
    public class Article : IArticleEntity
    {
        public uint? Id { get; set; }
        public string Path { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public uint Comments { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public String CreatedByUser { get; set; }
        public uint CreatedByUserId {get; set;}   
    }
}