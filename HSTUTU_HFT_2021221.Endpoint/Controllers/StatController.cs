﻿using HSTUTU_HFT_2021221.Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSTUTU_HFT_2021221.Endpoint.Controllers
{
    [Route("/stat")]
    [ApiController]
    public class StatController : ControllerBase
    {
        IBlogLogic blogLogic;
        ITagLogic tagLogic;
        IPostLogic postLogic;

        public StatController(IBlogLogic blogLogic, ITagLogic tagLogic, IPostLogic postLogic)
        {
            this.blogLogic = blogLogic;
            this.tagLogic = tagLogic;
            this.postLogic = postLogic;
        }

       [HttpGet("blogposttile/{id}")]
        public IEnumerable<string> GetBlogPostTitleById(int id)
        {
            return blogLogic.GetBlogPostTitleById(id);
        }

        [HttpGet("blogtagname/{id}")]
        public IEnumerable<string> GetAllBlogTagNameById(int id)
        {
            return blogLogic.GetAllBlogTagNameById(id);
        }

        [HttpGet("likesum")]
        public IEnumerable<KeyValuePair<string, int>> GetSumOfPostLikesByBlog()
        {
            return blogLogic.GetSumOfPostLikesByBlog();
        }

        [HttpGet("tagsbypost/{id}")]
        public IEnumerable<string> GetTagsByPostId(int id)
        {
            return postLogic.GetTagsByPostId(id);
        }

        [HttpGet("postsbytag/{id}")]
        public IEnumerable<string> GetPostByTagId(int id)
        {
            return tagLogic.GetPostByTagId(id);
        }
    }
}