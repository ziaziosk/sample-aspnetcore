using AspNetCoreSample.Web.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace AspNetCoreSample.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void About()
        {
            var controller = new HomeController();
            var result = controller.About() as ViewResult;

            result.Should().NotBeNull();
            result.ViewData["Message"].Should().Be("Your application description page.");
        }

        [Fact]
        public void Contact()
        {
            var controller = new HomeController();
            var result = controller.Contact() as ViewResult;

            result.Should().NotBeNull();
            result.ViewData["Message"].Should().Be("Your contact page.");
        }
    }
}
