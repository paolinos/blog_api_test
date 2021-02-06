using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Blog.Api.Interfaces.Models;
using Blog.Api.Interfaces.Repository;
using Blog.Api.Models;

namespace Blog.Api.Controllers
{
    [ApiController]
    // Not yet for .Net 5 : https://www.nuget.org/packages/Microsoft.AspNetCore.Mvc.Versioning
    //[ApiVersion("1.0")]
    //[Route("api/v{version:apiVersion}/[controller]")]
    [Route("api/v1/[controller]s")]
    public class ArticleController : ControllerBase
    {
        private readonly ILogger<ArticleController> _logger;
        private readonly IArticleRepository _articleRepository;

        public ArticleController(ILogger<ArticleController> logger, IArticleRepository articleRepository)
        {
            _logger = logger;
            _articleRepository = articleRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<IArticleEntity>> GetLastArticles()
        {
            return await _articleRepository.GetLastArticles();

            //return NotFound();
            //return CreatedAtAction(nameof(GetById), new { id = product.Id }, product)
        }

        [HttpGet("{title}")]
        public async Task<ActionResult<IArticleEntity>> GetArticleByTitle(string title)
        {
            //TODO: Delete & implement Repository
            await Task.Delay(1);

            if(String.IsNullOrWhiteSpace(title)){
                return BadRequest("Title is invalid");
            }

            //return model;
            return Ok(await _articleRepository.GetArticleByTitle(title));
            //return CreatedAtAction("Get", new { title = model.Id }, product)
        }

        [HttpPost]
        public async Task<ActionResult> Save(IArticleInput article)
        {
            //TODO: Delete & implement Repository
            await Task.Delay(1);

            return Ok();
            //return CreatedAtRoute(nameof(GetArticleByTitle), new { title = article.Title }, article);
        }

    }
}