using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Blog.Api.Interfaces.Models;

namespace Blog.Api.Interfaces.Repository
{
    public interface IArticleRepository
    {
        Task<IEnumerable<IArticleEntity>> GetLastArticles();

        Task<IArticleEntity> GetArticleByTitle(string title);

        Task AddNewArticle(uint userId, string title, IArticleInput article);

        Task UpdateArticle(uint userId, string title, IArticleInput article);

        Task DeleteArticle(uint userId, string title);
    }
}