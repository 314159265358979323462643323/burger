using System;
using Xunit;
using Moq;
using WilliamToddSite.Models;
using Microsoft.AspNetCore.Mvc;
using WilliamToddSite.Controllers;
using System.Collections.Generic;

namespace QuizTests
{
    public class RepositoryTests
    {
        //Im sorry I couldnt find any good controller methods to test
        //that deal with my repository, these are what i got.
        [Fact]
        public void TestSelect()
        {
            var fakeRepo = new TestRepository();
            var controller = new HomeController(fakeRepo);

            var comment1 = new ForumModel() { CommentId = 1 };
            fakeRepo.Insert(comment1);
            var comment2 = new ForumModel() { CommentId = 2 };
            fakeRepo.Insert(comment2);

            var viewResult = (ViewResult)controller.Forum();
            var comments = (List<ForumModel>)viewResult.ViewData.Model;

            Assert.Equal(2, comments.Count);
            Assert.Equal(0, comment1.CommentId);

        }

        [Fact]
        public void TestInsert()
        {
            var fakeRepo = new TestRepository();
            var controller = new HomeController(fakeRepo);
            var comment = new ForumModel();

            controller.Insert(comment);

            var repoComment = fakeRepo.SelectByID(0);
            Assert.Equal(0, repoComment.CommentId);

        }
    }
}
