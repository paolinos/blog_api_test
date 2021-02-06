using System;
using Xunit;
using System.Collections.Generic;
using System.Threading.Tasks;

using Blog.Api.Repository;
using Blog.Api.Models;

namespace Blog.Api.Test
{
    public class ArticleRepositoryTest
    {
        [Fact]
        public async Task GetLastArticles_And_ResultShouldNotBeEmpty()
        {
            // Arrange
            var repo = new ArticleRepository();

            // Act
            var result1 = await repo.GetLastArticles();

            // Assert
            Assert.NotEmpty(result1);
        }


        [Fact]
        public async Task GetArticleByPath_And_ResultShouldNotBeEmpty()
        {
            // Arrange
            var repo = new ArticleRepository();

            // Act
            var result1 = await repo.GetArticleByPath("some title");

            // Assert
            Assert.NotNull(result1);
        }

        [Fact]
        public async Task AddNewArticle_And_ResultShouldNotThrow()
        {
            // Arrange
            var repo = new ArticleRepository();

            // Act

            // Assert
            await repo.AddNewArticle(0,"title", new Article());
        }

        [Fact]
        public async Task UpdateArticle_And_ResultShouldNotThrow()
        {
            // Arrange
            var repo = new ArticleRepository();

            // Act

            // Assert
            await repo.UpdateArticle(0,"title", new Article());
        }

        [Fact]
        public async Task DeleteArticle_And_ResultShouldNotThrow()
        {
            // Arrange
            var repo = new ArticleRepository();

            // Act

            // Assert
            await repo.DeleteArticle(0,"title");
        }
    }
}
