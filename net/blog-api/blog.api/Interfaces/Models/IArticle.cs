using System;

namespace Blog.Api.Interfaces.Models
{
    public interface IArticleInput
    {
        string Title { get; set; }
        string ShortDescription { get; set; }
        string Description { get; set; }   
    }

    public interface IArticleEntity : IArticleInput
    {
        uint Comments { get; set; }

        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
        String CreatedByUser { get; set; }
        uint CreatedByUserId {get; set;}
    }   
}