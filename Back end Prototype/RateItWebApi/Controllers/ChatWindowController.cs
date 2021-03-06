﻿using AutoMapper;
using RateIt.Common.Models;
using RateIt.Model;
using RateIt.Services;
using RateIt.Services.Interfaces;
using RateItWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RateItWebApi.Controllers
{
    //Mvc controller to serve page to chrome extension
    //The new version will be an api call and rendered in vue.js (this is just prototype)
    public class ChatWindowController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly ISubDirectoryService _subDirectoryService;
        private readonly IMapper _mapper;
        private readonly ILoggingService _loggingService;
        private readonly IRatingService _ratingService;
        private readonly IUserService _userService;

        public ChatWindowController(ICommentService commentService, ISubDirectoryService subDirectoryService,
            IMapper mapper, ILoggingService loggingService, IRatingService ratingService, IUserService userService)
        {
            _commentService = commentService;
            _subDirectoryService = subDirectoryService;
            _mapper = mapper;
            _loggingService = loggingService;
            _ratingService = ratingService;
            _userService = userService;
        }

        [HttpPost()]
        public ActionResult Index(Page page)
        {
            return Index(page.EncodedUrl);
        }

        //[MoralityAuthenticationFilter]
        [HttpGet()]
        public ActionResult Index(string encodedUrl)
        {
            try
            {
                // Get user and decode url
                var user = _userService.GetUserByEmail(User.Identity.Name);
                var decodedUrl = HttpUtility.UrlDecode(encodedUrl);

                // Basic checks & setup
                if (string.IsNullOrEmpty(decodedUrl))
                    throw new Exception("Error creating/matching directory");
                else if (!decodedUrl.StartsWith("https://") && !decodedUrl.StartsWith("http://"))
                    decodedUrl = $"https://{decodedUrl}";

                // Get the site/directory
                var currentDirectory = _subDirectoryService.FindOrInsertSite(decodedUrl);
                if (currentDirectory == null)
                    throw new Exception("Error creating/matching directory");

                // Get the comments
                var comments = _commentService.GetCommentsBySubDirectory(currentDirectory?.Id ?? -1, 0, 30);
                var commentModel = new CommentListModel()
                {
                    Page = 0,
                    PerPage = 30,
                    Comments = _mapper.Map<IList<RateIt.Common.Models.Comment>>(comments)
                };

                //Set model
                var pageRating = _ratingService.GetRatingBySubDirectoryId(currentDirectory.Id);
                AppModel model = new AppModel()
                {
                    HostName = currentDirectory.Site?.Name,
                    PageName = $"{currentDirectory.Site?.Name}/{currentDirectory.Name}",
                    PageRating = pageRating?.RatingValue ?? 0,
                    PageRatingCount = pageRating?.UserRatings.Count() ?? 0,
                    Comments = commentModel,
                    Profile = _mapper.Map<UserProfile>(user),
                    //Loads more to add
                };

                //Return page with model
                return View("Index", model);
            }
            catch (Exception ex)
            {
                _loggingService.Log(ex.StackTrace);
                return View("Error");
            }
        }

    }
}