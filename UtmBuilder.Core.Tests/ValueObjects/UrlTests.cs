using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects;

[TestClass]
public class UrlTests
{
    private readonly string _validUrl = "https://balta.io";
    private readonly string _invalidUrl = "abacate";
    [TestMethod]
    [ExpectedException(typeof(InvalidUrlException))]
    [TestCategory("Url Tests")]
    public void ShouldReturnExceptionWhenUrlIsInvalid()
    {
        new Url(_invalidUrl);
      
    }

    [TestMethod]
    [TestCategory("Url Tests")]
    public void ShouldNotReturnExceptionWhenUrlIsValid()
    {
        new Url(_validUrl);

        Assert.IsTrue(true);      
    }

    [TestMethod]
    [TestCategory("Url Tests")]
    [DataRow(" ", true)]
    [DataRow("http", true)]
    [DataRow("banana", true)]
    [DataRow("https://balta.io", false)]
    public void TestUrl(
       string link,
       bool expectException)
    {
        if (expectException)
        {
            try
            {
                new Url(link);
                Assert.Fail();
            }
            catch (InvalidUrlException)
            {
                Assert.IsTrue(true);
            }
        }
        else
        {
            new Url(link);
            Assert.IsTrue(true);
        }
    }
}

