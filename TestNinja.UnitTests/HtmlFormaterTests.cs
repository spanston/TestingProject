using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    class HtmlFormaterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWIthStrongElement()
        {
            var formatter = new HtmlFormatter();

            string testString = "hello";

            var result = formatter.FormatAsBold(testString);

            //Specfic Assetion
            //Assert.That(result, Is.EqualTo("<strong>hello</strong>"));

            //More general
            Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("hello"));
        }
    }
}
