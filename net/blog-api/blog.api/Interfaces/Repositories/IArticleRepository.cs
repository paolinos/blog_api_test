using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Blog.Api.Interfaces.Models;

namespace Blog.Api.Interfaces.Repository
{
    public interface IArticleRepository
    {
        Task<IEnumerable<IArticleEntity>> GetLastArticles();

        Task<IArticleEntity> GetArticleByPath(string path);

        Task AddNewArticle(uint userId, string path, IArticleInput article);

        Task UpdateArticle(uint userId, string path, IArticleInput article);

        Task DeleteArticle(uint userId, string path);
    }
}