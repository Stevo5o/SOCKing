﻿using SOCKing.Data;
using SOCKing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SOCKing.Areas.Admin.Controllers
{
    // /admin/post

    [RouteArea("Admin")]
    [RoutePrefix("post")]
    public class PostController : Controller
    {
        private readonly IPostRepository _repository;
        public PostController(IPostRepository repository)
        {
            _repository = repository;
        }
        
        // GET: Admin/Post
        public ActionResult Index()
        {
            return View();
        }

        // /admin/post/create/
        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            var model = new Post();

            return View(model);
        }

        // /admin/post/create/
        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Post model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // TODO: update model in data store

            return RedirectToAction("index");
        }

        // /admin/post/edit/post-to-edit
        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(string id)
        {
            // TODO: to retieve the model from the data store
            var post = _repository.Get(id);

            if (post == null)
            {
                return HttpNotFound();
            } 
            return View(post);
        }

        // /admin/post/edit/post-to-edit
        [HttpPost]
        [Route("edit/{id}")]
        public ActionResult Edit(Post model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // TODO: update model in data store

            return RedirectToAction("index");
        }
    }
}