using System;
using Xunit;
using DotNetCoreWebAppAPI.Controllers;
using System.Linq;

namespace XUnitTesting
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var controller = new valuesController();
            var result = controller.Get();
            Assert.Equal(2, result.Count());

        }
    }

 
}
