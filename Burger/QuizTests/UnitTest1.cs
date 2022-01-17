using System;
using Xunit;
using Moq;
using WilliamToddSite.Models;
using Microsoft.AspNetCore.Mvc;
using WilliamToddSite.Controllers;
using System.Collections.Generic;

namespace QuizTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestWrongAnswer()
        {
            QuizModel model = new QuizModel();
            model.rScore = 0;
            Assert.Equal("False", model.checkAnswer());
        }

        [Fact]
        public void TestRightAnswer()
        {
            QuizModel model = new QuizModel();
            model.rScore = 3;
            Assert.Equal("True", model.checkAnswer());
        }

        [Fact]
        public void IndexTest()
        {
            TestRepository repository = new TestRepository();
            HomeController controller = new HomeController((IForumRepository)repository);
            var result = (ViewResult)controller.Index();
            List<ForumModel> data = (List<ForumModel>)result.ViewData.Model;
            Assert.True(data.Count == 0);
        }

        [Fact]
        public void InsertTest()
        {
            TestRepository repository = new TestRepository();
            HomeController controller = new HomeController((IForumRepository)repository);
            var result = (ViewResult)controller.Index();
            List<ForumModel> data = (List<ForumModel>)result.ViewData.Model;
            Assert.True(data.Count == 0);
        }
    }
}
