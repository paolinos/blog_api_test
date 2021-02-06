using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Blog.Api.Interfaces.Models;
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

        public ArticleController(ILogger<ArticleController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<IArticleEntity>> GetLastArticles()
        {
            //TODO: Delete & implement Repository
            await Task.Delay(1);


            return new List<IArticleEntity>();

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

            var model = new Article();
            model.Title = title;
            //return model;
            return Ok(model);
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