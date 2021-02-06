using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Blog.Api.Interfaces.Repository;
using Blog.Api.Interfaces.Models;
using Blog.Api.Models;

namespace Blog.Api.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        private static readonly IArticleEntity[] Artiles = new[]
        {
            new Article(){ Title="Freezing" },
            new Article(){ Title="Bracing" }
        };

        public async Task<IEnumerable<IArticleEntity>> GetLastArticles()
        {
            await Task.Delay(1);

            //return new List<IArticleEntity>();
            return Artiles;
        }
        
        public async Task<IArticleEntity> GetArticleByPath(string path)
        {
            await Task.Delay(1);

            return new Article(){
                Path=path
            };
        }

        public async Task AddNewArticle(uint userId, string path, IArticleInput article)
        {
            await Task.Delay(1);
        }

        public async Task UpdateArticle(uint userId, string path, IArticleInput article)
        {
            await Task.Delay(1);
        }

        public async Task DeleteArticle(uint userId, string path)
        {
            await Task.Delay(1);
        }
    }
}